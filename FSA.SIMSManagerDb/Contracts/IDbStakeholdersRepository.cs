using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbStakeholdersRepository
    {
        Task<SimsStakeholder> Add(int hostId, SimsStakeholder stakeholder);
        Task<List<SimsStakeholder>> GetAll(int hostId);
        Task Remove(int stakeholderId);
        Task<SimsStakeholder> Update(SimsStakeholder stakeholder);
    }
}