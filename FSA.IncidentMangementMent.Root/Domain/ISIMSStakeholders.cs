using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSStakeholders
    {
        Task<Stakeholder> Add(int hostId, Stakeholder stakeholder);
        Task<Stakeholder> GetAll (int hostId, int Stakeholder);
        Task<Stakeholder> Update(Stakeholder stakeholder);
        Task<Stakeholder> Remove(Stakeholder stakeholder);
    }
}
