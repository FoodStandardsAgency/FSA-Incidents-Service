using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbAttachmentsRepository
    {
        Task<IEnumerable<(string fileUrl, DocumentTagTypes tags)>> GetAttachmentTags(int hostId);
        Task UpdateAttachmentTags(int id, string docUrl, DocumentTagTypes tags);
    }
}