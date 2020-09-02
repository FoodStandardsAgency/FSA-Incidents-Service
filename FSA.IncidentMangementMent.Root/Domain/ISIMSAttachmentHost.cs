using FSA.IncidentsManagement.Root.DTOS;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSAttachmentHost
    {
        ISimSpAttachments Incidents { get; }
        ISimSpAttachments Signals { get; }
        Task<SimsAttachmentFileInfo> RenameFile(string filename, string fileUrl);
    }
}
