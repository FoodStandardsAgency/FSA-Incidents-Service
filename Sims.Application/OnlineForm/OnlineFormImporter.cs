using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
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

        internal OnlineFormImporter(ISimsDbHost host)
        {
            this.host = host;
        }

        public async Task Process(JsonDocument formDocument)
        {
            var refNo = formDocument.RootElement.GetProperty("Incidents").GetProperty("IncidentTitle").GetRawText();

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
            var newForm = ToOnlineForm(externalFrom, refId);
            var stakeHolder = ToOnlineStakeHolder(notifier);
            var stakeholderAddressNote = NotifierAddress(notifierAddress);
            var products = allProducts.Select(p => ToOnlineProduct(p));

            var addedForm = await this.host.OnlineForms.Add(newForm);
            var stakeholders = await this.host.OnlineForms.Stakeholders.Add(addedForm.CommonId, stakeHolder);
            await this.host.OnlineForms.Notes.Add(addedForm.CommonId, stakeholderAddressNote.Note);
            await this.host.OnlineForms.Products.BulkAdd(addedForm.CommonId, products);
            // unfurl the FBO Types
            var contactNotes = new List<string>();
            foreach (var contact in contacts)
            {
                var contactAddressNote = NotifierAddress(contact.Addresses);
                var FboTypes = String.Join("\n", host.OnlineForms.Products.Fbos.GetNamesFromId(contact.FbosTypes.ToList()));
                var updatedNoteText = $"Product : {contact.ProductName}\nFBOTypes:{FboTypes}\nAddress: {contactAddressNote.Note}";
                contactNotes.Add(updatedNoteText);
            }
            await this.host.OnlineForms.Notes.BulkAdd(addedForm.CommonId, contactNotes);

        }

        public SimsNote NotifierAddress(ExternalAddress externalAddress) => new SimsNote
        {
            Note = $"{externalAddress.AddressLine1}\n{externalAddress.AddressLine2}\n{externalAddress.County}\n{externalAddress.TownCity}\n{externalAddress.Postcode}\n{externalAddress.CountryId}"
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
            PackSizes = new[]{new SimsProductPackSize
            {
                 Size = product.IncidentProductPackSizes.Size,
                 UnitId=1
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
            Action = onlineForm.ActionTaken,
            AdditionalInformation = onlineForm.AdditionalInformation,
            LADetails = onlineForm.LocalAuthorityNotified,
            DeathIllness = onlineForm.IllnessDetails,
            IsClosed = false,
            NotifierTypeId = onlineForm.Notifierid,
            Description = onlineForm.NatureOfProblem,
            DistributionDetails = onlineForm.DistributionDetails
        };
    }
}
