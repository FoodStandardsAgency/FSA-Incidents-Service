using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagementDb.Entities;
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
                        where Db : class, IIDbLookup
    {
        protected readonly FSADbContext ctx;
        protected readonly Func<Db, T> toClient;
        protected readonly Func<FSADbContext, Task<List<Db>>> _customAsyncFetch;
        private readonly Func<FSADbContext, List<Db>> _customFetch;

        internal ReferenceDataRepo() { }

        internal ReferenceDataRepo(FSADbContext ctx, Func<Db, T> toClient)
        {
            this.ctx = ctx;
            this.toClient = toClient;
        }


        internal ReferenceDataRepo(FSADbContext ctx, Func<FSADbContext, Task<List<Db>>> customAsyncFetch, Func<Db, T> toClient) : this(ctx, toClient)
        {
            this._customAsyncFetch = customAsyncFetch;
        }

        internal ReferenceDataRepo(FSADbContext ctx, Func<FSADbContext, List<Db>> customFetch, Func<Db, T> toClient): this(ctx, toClient)
        {
            this._customFetch = customFetch;
        }

        public async Task<T> Find(string title)
        {
            var item = await this.ctx.Set<Db>().FirstAsync(f=>f.Title == title);
            return toClient(item);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var items = _customAsyncFetch == null ? 
                            await this.ctx.Set<Db>().AsNoTracking().ToListAsync() : 
                            await _customAsyncFetch(this.ctx);
            return items.Select(toClient).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            var items = _customFetch == null ? this.ctx.Set<Db>().AsNoTracking().ToList() :
                            _customFetch(this.ctx);
            return items.Select(toClient).ToList();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var item = await this.ctx.Set<Db>().AsNoTracking().FirstAsync(f=>f.Id==id);
            return toClient(item);
        }
    }
}
