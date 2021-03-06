﻿using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using Microsoft.Extensions.Logging;
using Sims.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sims.Application.OnlineForm
{
    internal class OnlineFormImporter
    {
        private readonly ISimsDbHost host;
        private readonly ILogger<OnlineFormImporter> logger;

        internal OnlineFormImporter(ISimsDbHost host, ILogger<OnlineFormImporter> logger)
        {
            this.host = host;
            this.logger = logger;
        }

        public async Task Process(JsonDocument formDocument)
        {
            var refNo = formDocument.RootElement.GetProperty("Incidents").GetProperty("IncidentTitle").GetString();

            var jsonOpts = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                AllowTrailingCommas = false,
                IgnoreReadOnlyFields = true,
                IgnoreReadOnlyProperties = true,
            };
            // Nullable date times are used in the ProductDates
            jsonOpts.Converters.Add(new NullableDateTimeConverter());

            // Create a new Online form!
            // convert into local objects, and then transgorm into SIMS.. objects for pushing into the db.
            logger.LogInformation("Processing form input");
            var newForm = JsonSerializer.Deserialize<ExternalOnlineForm>(formDocument.RootElement.GetProperty("Incidents").GetRawText(), jsonOpts);
            newForm.ReferenceNo = refNo;
            var stakeHolder = JsonSerializer.Deserialize<ExternalStakeholder>(formDocument.RootElement.GetProperty("IncidentStakeholders").GetRawText(), jsonOpts);
            // There is only address in this here addresses area.
            var stakeHolderAddress = JsonSerializer.Deserialize<ExternalAddress>(formDocument.RootElement.GetProperty("Addresses").GetRawText(), jsonOpts);
            // Products are a collection
            var allProducts = new List<ExternalProduct>();
            var companyContactBing = new List<ExternalCompany>();
            foreach (var product in formDocument.RootElement.GetProperty("IncidentProducts").EnumerateArray())
            {
                var newProduct = JsonSerializer.Deserialize<ExternalProduct>(product.GetRawText(), jsonOpts);
                foreach (var address in product.GetProperty("Companies").EnumerateArray())
                {
                    var companyContact = JsonSerializer.Deserialize<ExternalCompany>(address.GetRawText(), jsonOpts);
                    companyContact.ProductName = newProduct.Name;
                    companyContactBing.Add(companyContact);
                }

                allProducts.Add(newProduct);
            }

            await CreateNewOnlineForm(refNo, newForm, stakeHolder, stakeHolderAddress, allProducts, companyContactBing);
            //this.host.OnlineForms.Add()
        }

        private async Task CreateNewOnlineForm(string refId, ExternalOnlineForm externalFrom, ExternalStakeholder notifier, ExternalAddress notifierAddress, List<ExternalProduct> allProducts, List<ExternalCompany> contacts)
        {
            logger.LogDebug("Creating new online form.");
            var countries = this.host.Lookups.Countries.ToList();
            var newForm = ToOnlineForm(externalFrom, refId);
            var stakeHolder = ToOnlineStakeHolder(notifier);
            var stakeholderAddressNote = NotifierAddress(notifierAddress, countries);
            var products = allProducts.Select(p => ToOnlineProduct(p));
            SimsOnlineForm addedForm = null;
            try
            {
                logger.LogDebug("Adding onlineform - base");
                addedForm = await this.host.OnlineForms.Add(newForm);
            }
            catch (Exception ex)
            {
                logger.LogCritical("Failed to add basic form", ex);
                throw ex;
            }
            try
            {
                logger.LogDebug("Adding onlineform - stakeholders");
                //  var stakeholders = await this.host.OnlineForms.Stakeholders.Add(addedForm.CommonId, stakeHolder);
                await this.host.OnlineForms.Notes.Add(addedForm.CommonId, $"Stakeholder Address\n{stakeHolder.Name}\n{stakeHolder.Role}\n{stakeHolder.Phone}\n{stakeholderAddressNote.Note}", 5);
            }
            catch (Exception ex)
            {
                logger.LogCritical("Failed to add stakeholders", ex);
                throw ex;
            }
            try
            {
                logger.LogDebug($"Adding onlineform - products {products.Count()}");
                await this.host.OnlineForms.Products.BulkAdd(addedForm.CommonId, products);
            }
            catch (Exception ex)
            {
                logger.LogCritical("Failed to add products", ex);
                throw ex;

            }

            // unfurl the FBO Types
            var contactNotes = new List<(string text, int tags)>();
            foreach (var contact in contacts)
            {
                var contactAddressNote = NotifierAddress(contact.Addresses, countries);
                var FboTypes = String.Join("\n", host.OnlineForms.Products.Fbos.GetNamesFromId(contact.FbosTypes.ToList()));
                var updatedNoteText = $"Product Address\nProduct : {contact.ProductName}\nFBOTypes : {FboTypes}\nAddress : {contactAddressNote.Note}";
                contactNotes.Add((updatedNoteText, 0));
            }

            try
            {
                logger.LogDebug($"Adding onlineform - notes");
                await this.host.OnlineForms.Notes.BulkAdd(addedForm.CommonId, contactNotes);
            }
            catch (Exception ex)
            {
                logger.LogCritical("Failed to add notes", ex);
                throw ex;
            }

        }

        public SimsNote NotifierAddress(ExternalAddress externalAddress, List<Country> countries) => new SimsNote
        {
            Note = $"{externalAddress.AddressLine1}\n{externalAddress.AddressLine2}\n{externalAddress.County}\n{externalAddress.TownCity}\n{externalAddress.Postcode}\n{countries.FirstOrDefault(cnt => cnt.Id == externalAddress.CountryId)?.Title}"
        };

        public SimsProduct ToOnlineProduct(ExternalProduct product) => new SimsProduct
        {
            Added = DateTime.Now,
            AdditionalInfo = product.AdditionalInfo,
            Amount = product.Amount.ToString(),
            AmountUnitTypeId = product.AmountUnitTypeId,
            BatchCodes = product.BatchCodes,
            Brand = product.Brand,
            CountryOfOriginId = product.CountryOfOriginId,
            Name = product.Name,
            PackDescription = product.PackDescription,
            ProductTypeId = product.ProductTypeId,
            ProductDates = ToOnlineProductDates(product.IncidentProductDates),
            PackSizes = new[]{new SimsProductPackSize{
                 Size = product.IncidentProductPackSizes.Size,
                 UnitId=product.IncidentProductPackSizes.UnitId
            }}
        };

        public IEnumerable<SimsProductDate> ToOnlineProductDates(ExternalProductDates productDates)
        {
            var pDates = new List<SimsProductDate>();
            if (productDates.BestBeforeDate.HasValue)
                pDates.Add(new SimsProductDate
                {
                    Date = productDates.BestBeforeDate.Value,
                    DateTypeId = 2
                });
            if (productDates.DisplayUntil.HasValue)
                pDates.Add(new SimsProductDate
                {
                    Date = productDates.DisplayUntil.Value,
                    DateTypeId = 4
                });
            if (productDates.UseByDate.HasValue)
                pDates.Add(new SimsProductDate
                {
                    Date = productDates.UseByDate.Value,
                    DateTypeId = 1
                });
            return pDates;
        }

        public SimsStakeholder ToOnlineStakeHolder(ExternalStakeholder notifier) => new SimsStakeholder
        {
            AddressTitle = "",
            DiscriminatorId = 3,
            Email = notifier.Email,
            GovDept = notifier.GovDept,
            Name = notifier.Name,
            Phone = notifier.Phone,
            Role = notifier.Role
        };

        public SimsOnlineForm ToOnlineForm(ExternalOnlineForm onlineForm, string refId) => new SimsOnlineForm
        {
            Title = refId,
            ReferenceNo = refId,
            Description = onlineForm.NatureOfProblem,
            Action = onlineForm.ActionTaken,
            DistributionDetails = onlineForm.DistributionDetails,
            AdditionalInformation = onlineForm.AdditionalInformation,
            DeathIllness = onlineForm.IllnessDetails,
            LADetails = onlineForm.LocalAuthorityNotified,
            IsClosed = false,
            NotifierTypeId = onlineForm.Notifierid,
        };
    }
}
