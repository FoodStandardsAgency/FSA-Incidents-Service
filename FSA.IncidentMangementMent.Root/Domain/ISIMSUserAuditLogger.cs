using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSUserAuditLogger
    {
        public Task AddIncidentLog(string page, int id);
        public Task AddSignalLog(string page, int id);
    }
}
