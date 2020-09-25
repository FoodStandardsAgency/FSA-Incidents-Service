using FSA.IncidentsManagement.Root.DTOS;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSAttachmentHost
    {
        ISPAttachmentManagement Incidents { get; }
        ISPAttachmentManagement Signals { get; }
     //   Task<SimsAttachmentFileInfo> RenameFile(string filename, string fileUrl);
    }
}
