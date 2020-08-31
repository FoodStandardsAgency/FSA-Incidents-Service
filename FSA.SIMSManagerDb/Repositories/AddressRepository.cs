using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    internal class AddressRepository : IDbAddressRepository
    {
        private SimsDbContext ctx;
        private readonly IMapper mapper;

        public AddressRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
        }

        public async Task<SimsAddress> Add(SimsAddress address)
        {
            var newDbAddress = mapper.Map<SimsAddress, AddressDb>(address);
            //newDbItem.Contacts = address.Contacts.ToDb().ToList();
            this.ctx.Addresses.Add(newDbAddress);
            await this.ctx.SaveChangesAsync();
            return mapper.Map<AddressDb, SimsAddress>(newDbAddress);
        }

        public async Task Add(IEnumerable<SimsAddress> addresses)
        {

            var newDbItems = new List<AddressDb>(mapper.Map<IEnumerable<SimsAddress>, IEnumerable<AddressDb>>(addresses));

            this.ctx.Addresses.AddRange(newDbItems);
            await this.ctx.SaveChangesAsync();
        }

        public async Task<SimsAddress> Get(int addressId)
        {
            var addr = await ctx.Addresses.
                Include(o => o.Contacts)
                .AsNoTracking().FirstAsync(a => a.Id == addressId);
            return mapper.Map<AddressDb, SimsAddress>(addr);
        }
        /// <summary>
        /// TO DO !!!!
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<SimsAddress> Update(SimsAddress address)
        {
            var dbItem = await ctx.Addresses.Include(i => i.Contacts).SingleAsync(s => s.Id == address.Id);
            // Updates the address details
            this.mapper.Map(address, dbItem);
            //address.ToDb(dbItem);

            ctx.Addresses.Update(dbItem);
            // Main Contact. We don't have the key for contacins.
            // Currently (25/08/2020) you may only add one contact.
            // so hear we either update an existing contact (is always main), or add a new one.
            if (address.Contacts.Count() > 0)
            {
                var firstContact = address.Contacts.First();
                if (dbItem.Contacts.Count() > 0)
                {
                    var dbContact = dbItem.Contacts.First();
                    this.mapper.Map(firstContact, dbContact);
                    //firstContact.ToDb(dbContact);
                }
                else
                {
                    var newDbContact = mapper.Map<SimsAddressContact, AddressContactDb>(firstContact);
                    dbItem.Contacts.Add(newDbContact);
                }
                await ctx.SaveChangesAsync();
            }

            return mapper.Map<AddressDb, SimsAddress>(dbItem);
        }

        public async Task<IEnumerable<SimsAddress>> FindAddress(string search)
        {
            var qryAddr = this.ctx
                     .Addresses.Include(o => o.Contacts)
                     .AsNoTracking()
                     .Where(o => EF.Functions.Like(o.Title, $"%{search}%")
                                || EF.Functions.Like(o.AddressLine1, $"%{search}%")
                                || EF.Functions.Like(o.PostCode, $"%{search}%")
                                || o.Contacts.Any(ac => EF.Functions.Like(ac.Name, $"%{search}")));

            return await qryAddr.Select(o => mapper.Map<AddressDb, SimsAddress>(o)).ToListAsync();
        }

    }
}
