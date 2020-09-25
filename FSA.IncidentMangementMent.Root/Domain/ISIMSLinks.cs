using FSA.IncidentsManagement.Root.DTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSLinks
    {
        Task<IEnumerable<SimsLinkedRecord>> Add(int from, IEnumerable<int> to, string reason);
        Task<SimsLinkedRecord> Remove(int from, int to);
    }
}
