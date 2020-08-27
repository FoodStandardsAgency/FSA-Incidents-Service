using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface ISIMSAttachments
    {
        Task UpdateTags(int id, string docUrl, DocumentTagTypes tags);
        Task<IEnumerable<(string fileUrl, DocumentTagTypes tags)>> GetAllTags(int hostId);
        Task<IEnumerable<AttachmentFileInfo>> FetchAllAttchmentsLinks(string hostId);
    }
}
