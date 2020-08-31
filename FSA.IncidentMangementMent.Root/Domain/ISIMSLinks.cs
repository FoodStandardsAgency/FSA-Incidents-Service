using FSA.IncidentsManagement.Root.DTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSLinks
    {
        Task<IEnumerable<SimsLinkedRecord>> AddLinks(int from, IEnumerable<int> to, string reason);
        Task<SimsLinkedRecord> RemoveLink(int from, int to);
    }
}
