using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSAddress
    {

        Task<Address> Get(int OrganisationId);
        Task<Address> Add(Address address);
        Task<Address> Update(Address address);

        Task Add(IEnumerable<Address> addresses);


        Task<IEnumerable<Address>> FindAddress(string search);
    }
}
