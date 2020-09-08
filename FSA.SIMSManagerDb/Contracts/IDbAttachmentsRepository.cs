using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbAttachmentsRepository
    {
        Task<SimsAttachmentFileInfo> Add(string docUrl, int hostId);
        Task<IEnumerable<SimsAttachmentFileInfo>> Get(int hostId);
        Task<SimsAttachmentFileInfo> Update(string docUrl, int tags);
        Task<SimsAttachmentFileInfo> Rename(string existingUrl, string fileName);
    }
}