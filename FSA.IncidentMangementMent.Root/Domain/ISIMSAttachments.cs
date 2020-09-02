using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSAttachments
    {
        //Task UpdateTags(int id, string docUrl, DocumentTagTypes tags);
        Task<IEnumerable<SimsAttachmentFileInfo>> GetAllTags(int hostId);
        Task<IEnumerable<SimsAttachmentFileInfo>> FetchAllAttchmentsLinks(int hostId);
        Task<SimsAttachmentFileInfo> AddAttachment(string filePath, string filename, int hostId);
        Task<AttachmentLibraryInfo> EnsureLibrary(int stringId);
    }
}
