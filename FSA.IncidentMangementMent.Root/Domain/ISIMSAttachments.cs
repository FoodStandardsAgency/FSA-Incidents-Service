using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSAttachments
    {
        Task<SimsAttachmentFileInfo> AddAttachment(string filePath, string filename, int hostId);
        Task<SimsAttachmentFileInfo> Update(string filePath, SimsDocumentTagTypes docTagTypes);
        Task<IEnumerable<SimsAttachmentFileInfo>> GetAllTags(int hostId);
        Task<IEnumerable<SimsAttachmentFileInfo>> FetchAllAttchmentsLinks(int hostId);
        Task<SimsAttachmentLibraryInfo> EnsureLibrary(int stringId);
        Task<SimsAttachmentFileInfo> RegisterAttachment(string fileUrl, int hostId);
        Task<SimsAttachmentFileInfo> Rename(string existingUrl, string fileName);
    }
}
