using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb.Repositories
{
    public class AddressManagement : CoreRepositoryActions, IIAddressManagement
    {
        public AddressManagement(FSADbContext ctx, string editor) : base(ctx, editor)
        {
        }

        public async Task<int> AddFBOAddress(FboTypes addressType, string companyName, string MainContact, string AddressLine1, string AddressLine2, string TownCity)
        {
            var orgAddress = new OrganisationDb
            {
                AddressLine1 = AddressLine1,
                AddressLine2 = AddressLine2,
                TownCity = TownCity,
                MainContact = MainContact,
                Title = companyName,
                ContactMethodId = 4
            };
            this.SetAuditData(orgAddress);
            var fboAddress = new FBODb
            {
                FBOTypeId = addressType,
                Organisation = orgAddress
            };
            this.SetAuditData(fboAddress);
            ctx.FBOs.Add(fboAddress);
            await ctx.SaveChangesAsync();
            return fboAddress.Id;
        }

        public Task<OrganisationAddress> GetAddress(int OrganisationId)
        {
            throw new NotImplementedException();
        }

        public async Task<FboAddress> GetFBOAddress(int FboId)
        {
            var fboOrg = await this.ctx.FBOs
                    .Include(o => o.Organisation)
                .AsNoTracking()
                .FirstAsync(o => o.Id == FboId);
            return fboOrg.ToClient();
        }

        public async Task<NotifierAddress> GetNotifierAddress(int NotifierId)
        {
            var notifer = await this.ctx.Notifiers
                    .Include(o => o.Organisation)
                    .Include(o => o.NotifierType)
                    .AsNoTracking()
                .FirstAsync(o => o.Id == NotifierId);
            return notifer.ToClient();
        }
    }
}
