using FSA.IncidentsManagementDb.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSA.IncidentsManagement.Root.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Internal;

namespace FSA.IncidentsManagementDb.Repositories
{
    /// <summary>
    /// This version of the look is being used in more than one location.
    /// So makes ense to create a specific class for it.
    /// </summary>
    internal class OrganisationLookupManager : ReferenceDataRepo<OrganisationLookup, OrganisationLookupDb>
    {
        internal OrganisationLookupManager(FSADbContext ctx) : base(ctx,
                (ctx) => ctx.Organisations.Select(o => new OrganisationLookupDb { Id = o.Id, Title = o.Title})
                                            .ToListAsync(),
                (itm) => itm.ToLookup())
        {
        }

        internal async Task<Dictionary<int, OrganisationLookup>> FindAllLookups(HashSet<int> ids)
        {
            if (ids == null || ids.Count == 0) return new Dictionary<int, OrganisationLookup>();


            var whereClause = string.Join(" OR ", ids.ToList().Select(a => $"Id={a}"));

            var allTheOrgs = await ctx.Organisations.FromSqlRaw($"Select * FROM dbo.Organisations WHERE {whereClause}")
                            .AsNoTracking().ToDictionaryAsync(k => k.Id, v => new OrganisationLookup { Id = v.Id, Name = v.Title});
            return allTheOrgs;
        }

    }
}
