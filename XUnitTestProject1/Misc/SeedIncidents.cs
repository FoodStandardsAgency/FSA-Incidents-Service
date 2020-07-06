using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA.UnitTests.Misc
{
    class SeedIncidents
    {
        protected string[] userIds => new string[]
        {
            "2f65582c-5970-4848-9020-d65b6df2dc04", //me
            "9a8dda39-78ec-496d-8625-f8b24d83aa57",
            "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", // FSA.Test
            "8cc321a9-fea4-4689-a127-c5e141e2810c" // miller
        };

        public IEnumerable<BaseIncident> GetNewIncidents() => new List<BaseIncident>
        {
                 new BaseIncident(
                   incidentTitle: "New Incident",
                   incidentDescription: String.Empty,
                   incidentTypeId: 1,
                   contactMethodId: 3,
                   statusId: (int)IncidentStatus.Unassigned,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 1,
                   productTypeId: 3,
                   leadOfficer: "",
                   adminLeadId: 1,
                   leadOffice: "",
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 3,
                   receivedOn: null,
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null),

                new BaseIncident(
                   incidentTitle: "Mislabelled ingredients omit peanuts",
                   incidentDescription: String.Empty,
                   incidentTypeId: 1,
                   contactMethodId: 3,
                   statusId: (int)IncidentStatus.Open,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 1,
                   productTypeId: 3,
                   leadOfficer: "",
                   adminLeadId: 1,
                   leadOffice: this.userIds[1],
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 3,
                   receivedOn: DateTime.Now.ToUniversalTime(),
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null),

                new BaseIncident(
                   incidentTitle: "Salmonella poisoning cases at local GP",
                   incidentDescription: String.Empty,
                   incidentTypeId: 1,
                   contactMethodId: 3,
                   statusId: (int)IncidentStatus.Open,
                   priorityId: 1,
                   classificationId: 1,
                   dataSourceId: 1,
                   productTypeId: 3,
                   leadOfficer: "",
                   adminLeadId: 1,
                   leadOffice: this.userIds[2],
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 2,
                   receivedOn: DateTime.Now.ToUniversalTime(),
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null),

                new BaseIncident(
                   incidentTitle: "Chinese Restaurant takeaway pinpointed as likely source for salmonella poisoning (unverified)",
                   incidentDescription: String.Empty,
                   incidentTypeId: 1,
                   contactMethodId: 3,
                   statusId: (int)IncidentStatus.Open,
                   priorityId: 1,
                   classificationId: 1,
                   dataSourceId: 1,
                   productTypeId: 3,
                   leadOfficer: "",
                   adminLeadId: 2,
                   leadOffice: this.userIds[3],
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 2,
                   receivedOn: DateTime.Now.ToUniversalTime(),
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null)
        };

    }
}
