using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
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
            var refNo = formDocument.RootElement.GetProperty("ReferenceNo").GetString();

            var jsonOpts = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                AllowTrailingCommas = false,
                IgnoreReadOnlyFields = true,
                IgnoreReadOnlyProperties = true
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
            var allProducts = new List<ExternalProducts>();
            foreach (var product in formDocument.RootElement.GetProperty("IncidentProducts").EnumerateArray())
            {
                var newProduct = JsonSerializer.Deserialize<ExternalProducts>(product.GetRawText(), jsonOpts);
                allProducts.Add(newProduct);
            }


            //this.host.OnlineForms.Add()
        }

        public SimsOnlineForm ToOnlineForm(ExternalOnlineForm onlineForm, string refId) => new SimsOnlineForm
        {
            Title = refId,
            Action = onlineForm.ActionTaken,
            AdditionalInformation = onlineForm.AdditionalInformation,
            LADetails = onlineForm.LocalAuthorityNotified,
            DeathIllness = onlineForm.IllnessDetails,
            IsClosed = false,
            NotifierTypeId = onlineForm.NotifierTypeId
        };
    }
}
