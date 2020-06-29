using FSA.IncidentsManagementDb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Repositories
{
    public abstract class CoreRepositoryActions 
    {
        protected readonly FSADbContext ctx;
        protected readonly string editor;

        public CoreRepositoryActions(FSADbContext ctx, string editor)
        {
            this.ctx = ctx;
            this.editor = editor;
        }

        internal void UpdateAuditInfo(BaseEntityDb entity, DateTime? setCurrentDate = null)
        {
            var currentDate = setCurrentDate ?? DateTime.UtcNow;
            entity.ModifiedBy = this.editor;
            entity.Modified = currentDate;
        }

        internal void SetAuditData(BaseEntityDb entity, DateTime? setCurrentDate = null)
        {
            var currentDate = setCurrentDate ?? DateTime.UtcNow;

            entity.Created = currentDate;
            entity.CreatedBy = this.editor;
            this.UpdateAuditInfo(entity, currentDate);
        }

    }
}
