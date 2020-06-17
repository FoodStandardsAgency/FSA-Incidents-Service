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
        protected readonly FSADbContext ctx;
        protected readonly Func<Db, T> toClient;
        protected readonly Func<FSADbContext, Task<List<Db>>> _customFetch;

        internal ReferenceDataRepo() { }

        internal ReferenceDataRepo(FSADbContext ctx, Func<Db, T> toClient)
        {
            this.ctx = ctx;
            this.toClient = toClient;
        }


        internal ReferenceDataRepo(FSADbContext ctx, Func<FSADbContext, Task<List<Db>>> customFetch, Func<Db, T> toClient) : this(ctx, toClient)
        {
            this._customFetch = customFetch;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var items = _customFetch == null ? 
                            await this.ctx.Set<Db>().AsNoTracking().ToListAsync() : 
                            await _customFetch(this.ctx);
            return items.Select(toClient).ToList();
        }

        public async Task<T> GetById(int id)
        {
            var item = this.ctx.Set<Db>().Find(id);
            return toClient(item);
        }
    }
}
