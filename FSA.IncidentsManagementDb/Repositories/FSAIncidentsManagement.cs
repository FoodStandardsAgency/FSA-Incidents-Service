using FSA.IncidentsManagement.Root.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Repositories
{
    public class FSAIncidentsManagement : IFSAIncidentsData
    {
        private readonly FSADbContext ctx;
        private readonly string editor;

        public FSAIncidentsManagement(FSADbContext ctx, string editor)
        {
            this.ctx = ctx;
            this.editor = editor;
        }

        public IIncidentsManagement Incidents => new IncidentsManagement(ctx, editor);
    }
}
