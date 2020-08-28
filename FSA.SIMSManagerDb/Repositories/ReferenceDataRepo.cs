using AutoMapper;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    /// <summary>
    ///  This is a basic repo for purely getting and transforming lookup data. Or data to qbe used as lookups.
    /// You will need to define a mapping operations.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Db"></typeparam>
    internal class ReferenceDataRepo<T, Db> : IReferenceDataRepo<T>
                        where Db : class, IIDbLookup
    {
        protected readonly SimsDbContext ctx;
        protected readonly Func<Db, T> toClient;
        protected readonly Func<SimsDbContext, Task<List<Db>>> _customAsyncFetch;
        private readonly Func<SimsDbContext, List<Db>> _customFetch;

        internal ReferenceDataRepo(SimsDbContext ctx, Mapper mapper)
        {
            this.ctx = ctx;
            this.toClient = (itm) => mapper.Map<Db, T>(itm);
        }

        internal ReferenceDataRepo(SimsDbContext ctx, Func<SimsDbContext, List<Db>> customFetch, Mapper mapper) :this(ctx, mapper){
            this._customFetch = customFetch;
        }

        internal ReferenceDataRepo(SimsDbContext ctx, Func<SimsDbContext, Task<List<Db>>> customAsyncFetch, Mapper mapper):this(ctx, mapper)
        {
            this._customAsyncFetch = customAsyncFetch;
        }

        internal ReferenceDataRepo(SimsDbContext ctx, Func<Db, T> toClient)
        {
            this.ctx = ctx;
            this.toClient = toClient;
        }

        internal ReferenceDataRepo(SimsDbContext ctx, Func<SimsDbContext, Task<List<Db>>> customAsyncFetch, Func<Db, T> toClient) : this(ctx, toClient)
        {
            this._customAsyncFetch = customAsyncFetch;
        }

        internal ReferenceDataRepo(SimsDbContext ctx, Func<SimsDbContext, List<Db>> customFetch, Func<Db, T> toClient) : this(ctx, toClient)
        {
            this._customFetch = customFetch;
        }

        public async Task<T> Find(string title)
        {
            var item = await this.ctx.Set<Db>().FirstAsync(f => f.Title == title);
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
            var item = await this.ctx.Set<Db>().AsNoTracking().FirstAsync(f => f.Id == id);
            return toClient(item);
        }
    }
}
