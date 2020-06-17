using FSA.IncidentsManagementDb.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSA.IncidentsManagement.Root.Models;

namespace FSA.IncidentsManagementDb.Repositories
{
    /// <summary>
    /// This version of the look is being used in more than one location.
    /// So makes ense to create a specific class for it.
    /// </summary>
    internal class OrganisationLookupManager : ReferenceDataRepo<OrganisationLookup, OrganisationLookupDb>
    {
        internal OrganisationLookupManager(FSADbContext ctx) : base(ctx,
                (ctx) => ctx.Organisations.Select(o => new OrganisationLookupDb { Id = o.Id, Organisation = o.Organisation })
                                            .ToListAsync(),
                (itm) => itm.ToLookup())
        {
        }

        internal async Task<Dictionary<int, OrganisationLookup>> FindAllLookups(HashSet<int> ids)
        {
            if (ids == null || ids.Count == 0) return new Dictionary<int, OrganisationLookup>();


            // build a list of predicates
            var predicates = new List<IQueryable<OrganisationDb>>();
            IQueryable<OrganisationDb> dd = null;
            foreach (var id in ids)
            {
                if (dd == null)
                    dd = ctx.Organisations.Where(o => o.Id == id);
                else
                    dd = dd.Where(o => o.Id == id);
            }

            return await dd.Select(o => o.ToLookup()).ToDictionaryAsync(k => k.Id, v => new OrganisationLookup { Id = v.Id, Name = v.Name });
        }

    }
}
