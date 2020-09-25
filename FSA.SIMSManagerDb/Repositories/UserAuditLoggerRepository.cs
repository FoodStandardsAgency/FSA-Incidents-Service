using FSA.IncidentsManagement.Root.DTOS.Lookups;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    class UserAuditLoggerRepository : IDbUserAudit
    {
        private SimsDbContext ctx;

        public UserAuditLoggerRepository(SimsDbContext ctx)
        {
            this.ctx = ctx;
        }

        public Task LogEntry(string IncidentOrSignal, string PageRef, int ItemId)
        {
            ctx.UserAccessLog.Add(new UserAccessAuditDb
            {
                UserId = ctx.Editor,
                Scope = IncidentOrSignal,
                Page = PageRef,
                ScopeId = ItemId
            }) ;

            return ctx.SaveChangesAsync();
        }
    }
}
