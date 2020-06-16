﻿using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb.Repositories
{
    public class IncidentsManagement : IIncidentsManagement
    {
        private readonly FSADbContext ctx;
        private readonly string userIdent;

        public IncidentsManagement(FSADbContext ctx, string userIdent)
        {
            this.ctx = ctx;
            this.userIdent = userIdent;
        }

        public async Task<Incident> Add(Incident incident)
        {
            if (incident.CommonId != 0) throw new ArgumentOutOfRangeException("This item has already been added.");

            var dbItem = incident.ToDb();

            var dbPonder = this.ctx.Incidents.Add(dbItem);
            await this.ctx.SaveChangesAsync();
            return dbPonder.Entity.ToClient();
        }

        public Task<Incident> AssignIncident(int id, string user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns incident from its numercal id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Incident</returns>
        /// <exception cref="NullReferenceException" />
        public async Task<Incident> Get(int Id)
        {
            var itm = await this.ctx.Incidents.AsNoTracking().FirstAsync(f => f.Id == Id);
            return itm.ToClient();
        }

        public async Task<IEnumerable<Incident>> GetAll()
        {
            return (await this.ctx.Incidents.AsNoTracking().ToListAsync()).ToClient().ToList();
        }
        /// <summary>
        /// Joins two incidents
        /// As long as they have not already been joined.
        /// We check in both directions.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public async Task LinkIncident(int from, int to)
        {
            var fromTo = ctx.IncidentLinks.Find(new { FromIncidentId = from, ToIncidentId = to });
            var toFrom = ctx.IncidentLinks.Find(new { FromIncidentId = to, ToIncidentId = from });

            if (fromTo == null && toFrom == null)
                ctx.IncidentLinks.Add(new Entities.IncidentLinkDb { FromIncidentId = from, ToIncidentId = to });

            await ctx.SaveChangesAsync();
        }

        /// <summary>
        /// Update only a classification in an incident
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ClassificationId"></param>
        /// <returns>
        /// The updated incident
        /// </returns>
        /// <exception cref="NullReferenceException" />
        public async Task<Incident> UpdateClassification(int id, int ClassificationId)
        {
            var itm = await ctx.Incidents.FindAsync(id);
            itm.ClassificationId = ClassificationId;
            await ctx.SaveChangesAsync();
            return itm.ToClient();
        }

        public async Task<Incident> UpdateIncident(Incident incident)
        {
            var dbItem = incident.ToDb();
            var updatedDbItem = this.ctx.Incidents.Update(dbItem);
            await this.ctx.SaveChangesAsync();
            return updatedDbItem.Entity.ToClient();
        }

        /// <summary>
        /// Update only a Stats in an incident
        /// </summary>
        /// <param name="id"></param>
        /// <param name="statusId">Must match</param>
        /// <returns>
        /// The updated incident
        /// </returns>
        /// <exception cref="NullReferenceException" />
        public async Task<Incident> UpdateStatus(int id, int statusId)
        {
            var itm = await ctx.Incidents.FindAsync(id);
            itm.StatusId = statusId;
            await ctx.SaveChangesAsync();
            return itm.ToClient();
        }

    }
}
