using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IFSAAttachments
    {
        Task<bool> ReplaceAttachment(FileStream filem, string url);
        Task<(string fileName, string url)> RenameAttachment(string fileName, string url);
        Task<(string filename, string url)> AddAttachment(string filePath, string filename, string incidentId);
        Task<IEnumerable<AttachmentFileInfo>> FetchAllAttchmentsLinks(string incidentId);
        Task<IncidentAttachment> FetchAttachment(string url);
        Task<AttachmentLibraryInfo> EnsureLibrary(string stringId);
    }
}
