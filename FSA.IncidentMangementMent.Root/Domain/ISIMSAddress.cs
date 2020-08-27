using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSAddress
    {

        Task<SimsAddress> Get(int OrganisationId);
        Task<SimsAddress> Add(SimsAddress address);
        Task<SimsAddress> Update(SimsAddress address);

        Task Add(IEnumerable<SimsAddress> addresses);


        Task<IEnumerable<SimsAddress>> FindAddress(string search);
    }
}
