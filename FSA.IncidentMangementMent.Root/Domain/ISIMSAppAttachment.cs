using FSA.IncidentsManagement.Root.DTOS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSAppAttachment
    {
        Task UpdateTags(string docUrl, IEnumerable<int> tags);
        Task<SimsAttachmentFileInfo> Rename(string fileName, string url);
    }
}
