using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IFSATermStore
    {
        Task EnsureIncidentIdExists(string incidentId, string tkn);
    }
}
