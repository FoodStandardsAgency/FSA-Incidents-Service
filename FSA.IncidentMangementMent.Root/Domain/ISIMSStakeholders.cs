using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSStakeholders
    {
        Task<SimsStakeholder> Add(int hostId, SimsStakeholder stakeholder);
        Task<SimsStakeholder> GetAll (int hostId, int Stakeholder);
        Task<SimsStakeholder> Update(SimsStakeholder stakeholder);
        Task<SimsStakeholder> Remove(SimsStakeholder stakeholder);
    }
}
