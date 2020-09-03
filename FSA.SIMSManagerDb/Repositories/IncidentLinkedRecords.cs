using AutoMapper;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDbEntities.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    public class IncidentLinkedRecords : IDbLinkedRecordsRepository
    {
        private readonly SimsDbContext ctx;
      
        internal GeneralLinkedRecordsRepository<IncidentLinkDb, IncidentNoteDb> LinksManager { get; }

        public IncidentLinkedRecords(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.LinksManager = new GeneralLinkedRecordsRepository<IncidentLinkDb, IncidentNoteDb>(ctx, mapper);
        }

        public async Task<IEnumerable<SimsLinkedRecord>> Add(int from, IEnumerable<int> tos, string reason)
        {
            var addedLinks = await LinksManager.Add(from, tos, reason);

            var WhereFromClause = String.Join(" OR ", addedLinks.Select(o => $"Id={o.From}"));
            var WhereToClause = String.Join(" OR ", addedLinks.Select(o => $"Id={o.To}"));

            // Grab the incidents, as long as they are not closed.
            var closeStatus = (int)IncidentStatusTypes.Closed;
            var incidentsFrom = ctx.Incidents.FromSqlRaw($"SELECT * from Incidents where ({WhereFromClause}) AND IncidentStatusId <> {closeStatus}");
            var incidentsTo = ctx.Incidents.FromSqlRaw($"SELECT * from Incidents where ({WhereToClause}) AND IncidentStatusId <> {closeStatus}");
            foreach (var item in incidentsFrom)
            {
                ctx.Incidents.Update(item);
            }
            foreach (var item in incidentsTo)
            {
                ctx.Incidents.Update(item);
            }

            await ctx.SaveChangesAsync();
            return addedLinks;
        }

        public async Task<SimsLinkedRecord> Remove(int from, int to)
        {
            // Incidents that are linked must also be updated
            // unless they closed.
            var removedLink = await LinksManager.Remove(from, to);
            // Grab the incidents, as long as they are not closed.
            var fromIncident = ctx.Incidents.FirstOrDefault(i => i.Id == removedLink.From && i.IncidentStatusId != (int)IncidentStatusTypes.Closed);
            var toIncident = ctx.Incidents.FirstOrDefault(i => i.Id == removedLink.To && i.IncidentStatusId != (int)IncidentStatusTypes.Closed);
            if (fromIncident != null)
                ctx.Incidents.Update(fromIncident);
            if (toIncident != null)
                ctx.Incidents.Update(toIncident);
            await ctx.SaveChangesAsync();
            return removedLink;
        }
    }
}
