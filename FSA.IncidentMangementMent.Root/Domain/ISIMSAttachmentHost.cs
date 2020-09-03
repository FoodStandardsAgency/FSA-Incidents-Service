using FSA.IncidentsManagement.Root.DTOS;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSAttachmentHost
    {
        ISimsAttachments Incidents { get; }
        ISimsAttachments Signals { get; }
        Task<SimsAttachmentFileInfo> RenameFile(string filename, string fileUrl);
    }
}
