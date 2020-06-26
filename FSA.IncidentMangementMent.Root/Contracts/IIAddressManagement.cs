using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IIAddressManagement
    {
        Task<int> AddFBOAddress(FboTypes addressType, string companyName, string MainContact, string AddressLine1, string AddressLine2, string TownCity);
        Task<FboAddress> GetFBOAddress(int FboId);
        Task<OrganisationAddress> GetAddress(int OrganisationId);
        Task<NotifierAddress> GetNotifierAddress(int NotifierId);

    }
}
