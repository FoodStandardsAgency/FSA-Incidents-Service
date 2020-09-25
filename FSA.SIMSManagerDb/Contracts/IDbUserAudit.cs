using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbUserAudit
    {
        Task LogEntry(string IncidentOrSignal, string PageRef, int ItemId);
    }
}
