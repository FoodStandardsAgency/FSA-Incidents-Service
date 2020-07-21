using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IIAddressManagement
    {
        Task<FboAddress> GetFbo(int FboId);
        Task<FboAddress> AddFbo(FboAddress newAddress);
        Task<FboAddress> UpdateFbo(FboAddress address);
        Task AssignFbos(FboTypes fboTypes, IEnumerable<int> addressesId);

        Task<int> AssignFbo(FboTypes notifier, int addressId);
        Task<int> AddNotifier(NotifierTypes notifier, OrganisationAddress newAddress);
        Task<int> AssignNotifier(NotifierTypes notifier, int addressId);
        Task AssignNotifiers(NotifierTypes fboTypes, IEnumerable<int> addressesId);
        Task<NotifierAddress> GetNotifier(int NotifierId);

        Task<OrganisationAddress> Get(int OrganisationId);
        Task<OrganisationAddress> Add(OrganisationAddress address);
        Task<OrganisationAddress> Update(OrganisationAddress address);

        Task Add(IEnumerable<OrganisationAddress> addresses);

        Task<IEnumerable<FboAddress>> FindFbo(string search);
        Task<IEnumerable<NotifierAddress>> FindNotifier(string search);
        Task<IEnumerable<NotifierAddress>> FindLocalAuthority(string search);
        Task<IEnumerable<OrganisationAddress>> FindAddress(string search);



    }
}
