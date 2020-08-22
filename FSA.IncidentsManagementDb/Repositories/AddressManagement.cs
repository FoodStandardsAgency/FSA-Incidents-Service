﻿using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb.Repositories
{
    public class AddressManagement : IIAddressManagement
    {
        private FSADbContext ctx;

        public AddressManagement(FSADbContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<SimsAddress> Add(SimsAddress address)
        {
            var newDbItem = address.ToDb();
            //newDbItem.Contacts = address.Contacts.ToDb().ToList();
            this.ctx.Addresses.Add(newDbItem);
            await this.ctx.SaveChangesAsync();
            return newDbItem.ToClient();
        }

        public async Task Add(IEnumerable<SimsAddress> addresses)
        {
            var newDbItems = new List<AddressDb>(addresses.ToDb());
            this.ctx.Addresses.AddRange(newDbItems);
            await this.ctx.SaveChangesAsync();
        }



        public async Task<int> AddNotifier(NotifierTypes notifier, SimsAddress newAddress)
        {
            var dbAddress = newAddress.ToDb();
            var dbNotifier = new NotifierDb
            {
                NotifierTypeId = (int)notifier,
                Organisation = dbAddress,
            };

            this.ctx.Notifiers.Add(dbNotifier);
            await ctx.SaveChangesAsync();
            return dbNotifier.Id;
        }

        public async Task<SimsAddress> Get(int OrganisationId)
        {
            var addr = await ctx.Addresses.AsNoTracking().FirstAsync(a => a.Id == OrganisationId);
            return addr.ToClient();
        }
        /// <summary>
        /// TO DO !!!!
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<SimsAddress> Update(SimsAddress address)
        {
            var dbItem = await ctx.Addresses.FindAsync(address.Id);
            address.ToDb(dbItem);
            ctx.Addresses.Update(dbItem);
            return dbItem.ToClient();
        }

        public async Task<NotifierAddress> GetNotifier(int NotifierId)
        {
            var notifer = await this.ctx.Notifiers
                    .Include(o => o.Organisation)
                    .Include(o => o.NotifierType)
                    .AsNoTracking()
                .FirstAsync(o => o.Id == NotifierId);
            return notifer.ToClient();
        }

        public async Task<int> AssignNotifier(NotifierTypes notifier, int addressId)
        {
           var ent =  ctx.Notifiers.Add(new NotifierDb
            {
                NotifierTypeId  = (int) notifier,
                OrganisationId = addressId
            });

            await ctx.SaveChangesAsync();
             return ent.Entity.Id;
        }

        public async Task AssignNotifiers(NotifierTypes notifier, IEnumerable<int> addressesId)
        {
            var ents = addressesId.Select(o => new NotifierDb
            {
                NotifierTypeId = (int)notifier,
                OrganisationId = o
            });
            await ctx.Notifiers.AddRangeAsync(ents);
            await ctx.SaveChangesAsync();
        }
        
        public async Task AssignFbos(FboTypes fboTypes, IEnumerable<int> addressesId)
        {
            var ents = addressesId.Select(o =>new FBODb
            {
                //FBOTypeId = fboTypes,
                OrganisationId = o
            });
            await ctx.FBOs.AddRangeAsync(ents);
            await ctx.SaveChangesAsync();
        }

        public async Task<int> AssignFbo(FboTypes fboTypes, int addressId)
        {
            var ent = ctx.FBOs.Add(new FBODb
            {
                // FBOTypeId = fboTypes,
                OrganisationId = addressId
            });
            await ctx.SaveChangesAsync();
            return ent.Entity.Id;
        }


        public async Task<IEnumerable<SimsAddress>> FindAddress(string search)
        {
            var qryAddr = this.ctx
                     .Addresses.Include(o=>o.Contacts)
                     .AsNoTracking()
                     .Where(o => EF.Functions.Like(o.Title, $"%{search}%")
                                || EF.Functions.Like(o.AddressLine1, $"%{search}%")
                                || EF.Functions.Like(o.PostCode, $"%{search}%")
                                || o.Contacts.Any(ac=> EF.Functions.Like(ac.Name, $"%{search}")));

            return await qryAddr.Select(o => o.ToClient()).ToListAsync();
        }

        public async Task<FboAddress> AddFbo(FboAddress newAddress)
        {
            // create a new db Address
            var dbAddress = newAddress.ToDb();
            var dbFBO = new FBODb
            {
                //FBOTypeId = newAddress.FboTypes,
                Organisation = dbAddress
            };
            this.ctx.FBOs.Add(dbFBO);
            await ctx.SaveChangesAsync();
            return dbFBO.ToClient();
        }

        public async Task<FboAddress> GetFbo(int FboId)
        {
            var fboOrg = await this.ctx.FBOs
                    .Include(o => o.Organisation)
                    .AsNoTracking()
                    .FirstAsync(o => o.Id == FboId);
            return fboOrg.ToClient();
        }

        public async Task<FboAddress> UpdateFbo(FboAddress address)
        {
            //// update the types
            //var fbo = ctx.FBOs.Find(address.FboId);
            //fbo.FBOTypeId = address.FboTypes;
            //var org = ctx.Addresses.Find(fbo.OrganisationId);
            //// update the address
            //address.ToDb(org);

            //ctx.Addresses.Update(org);
            //ctx.FBOs.Update(fbo);
            //await ctx.SaveChangesAsync();
            //return (await ctx.FBOs
            //        .Include(o => o.Organisation)
            //        .AsNoTracking().FirstAsync(f => f.Id == address.FboId)).ToClient();
            throw new NotImplementedException();
        }
    }

}
