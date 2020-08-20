using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb.Repositories.ScratchRepos
{
    public class FBOLookups : IReferenceDataRepo<OrganisationLookup>
    {
        private FSADbContext ctx;

        public FBOLookups(FSADbContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<OrganisationLookup> Find(string title)
        {
            var items = this.ctx.FBOs.AsNoTracking().Include(o => o.Organisation)
                .Where(k => EF.Functions.Like(k.Organisation.Title, $"%{title}%") || EF.Functions.Like(k.Organisation.PostCode, $"%{title}%"));
            if (items.Count() > 0)
                return items.Select(o => new OrganisationLookup
                {
                    Id = o.Id,
                    Name = o.Organisation.Title
                }).First();
            return null;
        }

        public async Task<IEnumerable<OrganisationLookup>> GetAllAsync()
        {
            return await this.ctx.FBOs.AsNoTracking()
                 .Include(o => o.Organisation)
                 .Select(o => new OrganisationLookup
                 {
                     Id = o.Id,
                     Name = o.Organisation.Title
                 }).ToListAsync();
        }


        public IEnumerable<OrganisationLookup> GetAll()
        {
            return this.ctx.FBOs.AsNoTracking()
                 .Include(o => o.Organisation)
                 .Select(o => new OrganisationLookup
                 {
                     Id = o.Id,
                     Name = o.Organisation.Title
                 }).ToList();
        }

        public async Task<OrganisationLookup> GetByIdAsync(int id)
        {
            var itm = await this.ctx.FBOs.AsNoTracking()
               .Include(o => o.Organisation)
               .FirstAsync();
            return new OrganisationLookup
            {
                Id = itm.Id,
                Name = itm.Organisation.Title
            };
        }
    }
}
