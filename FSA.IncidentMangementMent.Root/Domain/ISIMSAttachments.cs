using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSAttachments
    {
        Task UpdateTags(int id, string docUrl, DocumentTagTypes tags);
        Task<IEnumerable<AttachmentFileInfo>> GetAllTags(int hostId);
        Task<IEnumerable<AttachmentFileInfo>> FetchAllAttchmentsLinks(int hostId);
        Task<AttachmentFileInfo> AddAttachment(string filePath, string filename, int hostId);
        Task<AttachmentLibraryInfo> EnsureLibrary(int stringId);
    }
}
