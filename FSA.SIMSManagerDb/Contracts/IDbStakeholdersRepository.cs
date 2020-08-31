using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    public interface IDbStakeholdersRepository
    {
        Task<Stakeholder> Add(int hostId, Stakeholder stakeholder);
        Task<List<Stakeholder>> GetAll(int hostId);
        Task Remove(int stakeholderId);
        Task<Stakeholder> Update(Stakeholder stakeholder);
    }
}