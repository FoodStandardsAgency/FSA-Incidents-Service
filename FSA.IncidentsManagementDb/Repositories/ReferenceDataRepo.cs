using FSA.IncidentsManagement.Root.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb.Repositories
{
    // This is a basic repo for pureley getting and transforming.
    // You will need to define a mapping operations.
    internal class ReferenceDataRepo<T, Db> : IReferenceDataRepo<T> 
                        where Db : class
    {
        private readonly FSADbContext ctx;
        private readonly Func<Db, T> toClient;

        internal ReferenceDataRepo(FSADbContext ctx, Func<Db,T> ToClient)
        {
            this.ctx = ctx;
            toClient = ToClient;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var items = await this.ctx.Set<Db>().ToListAsync();
            return items.Select(toClient).ToList();
        }

        public async Task<T> GetById(int id)
        {
            var item = this.ctx.Set<Db>().Find(id);
            return toClient(item);
        }
    }
}
