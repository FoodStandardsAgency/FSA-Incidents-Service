using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSStakeholders { 
        Task<SimsStakeholder> Add(int hostId, SimsStakeholder SimsStakeholder);
        Task<IEnumerable<SimsStakeholder>> GetAll (int hostId);
        Task<SimsStakeholder> Update(SimsStakeholder SimsStakeholder);
        Task Remove(int SimsStakeholder);
    }
}
