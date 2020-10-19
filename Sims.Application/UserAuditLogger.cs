using FSA.IncidentsManagement.Root.Domain;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Repositories;
using Sims.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class UserAuditLogger : ISIMSUserAuditLogger
    {
        private ISimsDbHost DbHost;

        public UserAuditLogger(ISimsDbHost dbHost) => this.DbHost = dbHost;

        public Task AddIncidentLog(string page, int id)
        {
            return this.LogEntry("Incident", page, id);
        }

        public Task AddSignalLog(string page, int id)
        {
            return this.LogEntry("Signal", page, id);
        }

        private Task LogEntry(string incidentOrSignal, string page, int id)
        {

            if (incidentOrSignal.ToLowerInvariant() == "incident" || incidentOrSignal.ToLowerInvariant() == "signal")
            {

                return this.DbHost.Audit.LogEntry(incidentOrSignal, page, id);
            }
            else
                throw new SIMSException("Incident/Signal missing from db");
        }
    }
}
