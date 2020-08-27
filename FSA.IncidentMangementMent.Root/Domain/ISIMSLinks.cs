using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSLinks
    {
        Task AddLinks(int from, IEnumerable<int> to, string reason);
        Task RemoveLink(int from, int to);
    }
}
