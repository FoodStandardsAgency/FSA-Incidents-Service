using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISimSpAttachments
    {
        Task<(string fileName, string url)> RenameAttachment(string fileName, string url);
        Task<(string filename, string url)> AddAttachment(string filePath, string filename, string library);
        Task<IEnumerable<SimsAttachmentFileInfo>> FetchAllAttchmentsLinks(string hostId);
        Task<IncidentAttachment> FetchAttachment(string url);
        Task<AttachmentLibraryInfo> EnsureLibrary(string hostId);
    }
}
