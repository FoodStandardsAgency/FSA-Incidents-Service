using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IIAddressManagement
    {
        Task<int> AddFbo(FboAddress newAddress);
        Task<FboAddress> UpdateFbo(FboAddress address);
        Task<FboAddress> GetFbo(int FboId);
        Task<int> AddNotifier(NotifierTypes notifier, OrganisationAddress newAddress);
        Task<NotifierAddress> GetNotifier(int NotifierId);

        Task<OrganisationAddress> Get(int OrganisationId);
        Task<OrganisationAddress> Add(OrganisationAddress address);
        Task<OrganisationAddress> Update(OrganisationAddress address);

        Task Add(IEnumerable<OrganisationAddress> addresses);

        
        Task<int> AssignNotifier(NotifierTypes notifier, int addressId);

        Task<int> AssignFbo(FboTypes notifier, int addressId);
        Task AssignNotifiers(NotifierTypes fboTypes, IEnumerable<int> addressesId);
        Task AssignFbos(FboTypes fboTypes, IEnumerable<int> addressesId);
    }
}
