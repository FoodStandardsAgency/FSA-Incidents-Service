using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb
{
    /// <summary>
    /// The complete DbContext defintion is split between two files.
    /// </summary>
    public partial class SimsDbContext : DbContext
    {
        private string _Editor;

        public SimsDbContext(DbContextOptions options) : base(options)
        {
        }

        internal void SetEditor(string editor)
        {
            this._Editor = editor ?? throw new ArgumentNullException("Must have an editor name.");
        }

        internal String Editor => _Editor;

        private void SetAuditData()
        {
            var items = ChangeTracker
                            .Entries<BaseEntityDb>()
                            .Where(o => o.State == EntityState.Modified || o.State == EntityState.Added);
            var now = DateTime.Now;
            foreach (var item in items)
            {
                item.Property(o => o.Modified).CurrentValue = now;
                item.Property(o => o.ModifiedBy).CurrentValue = _Editor;
                if (item.State == EntityState.Added)
                {
                    item.Property(o => o.Created).CurrentValue = now;
                    item.Property(o => o.CreatedBy).CurrentValue = _Editor;
                }
            }
        }

        public override int SaveChanges()
        {
            this.SetAuditData();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            this.SetAuditData();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
