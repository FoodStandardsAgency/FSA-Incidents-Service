using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbAttachmentsRepository
    {
        Task<SimsAttachmentFileInfo> Add(int hostId, string docUrl, int tags=0);
        
        /// <summary>
        /// Allows registering multiple files at once.
        /// </summary>
        /// <param name="hostId"></param>
        /// <param name="UrlTags"></param>
        /// <returns></returns>
        Task BulkAdd(int hostId, Dictionary<string, int> UrlTags);

        Task<IEnumerable<SimsAttachmentFileInfo>> Get(int hostId);
        Task<SimsAttachmentFileInfo> Update(string docUrl, int tags);
        Task<SimsAttachmentFileInfo> Rename(string existingUrl, string fileName);
    }
}