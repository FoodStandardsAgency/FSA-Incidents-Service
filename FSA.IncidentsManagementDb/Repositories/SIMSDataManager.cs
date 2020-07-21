﻿using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSA.IncidentsManagementDb.Repositories
{
    public class SIMSDataManager : ISIMSManager
    {
        private readonly FSADbContext ctx;
        private readonly string editor;

        public SIMSDataManager(FSADbContext ctx, string editor)
        {
            this.ctx = ctx;
            this.editor = editor;
            ctx.SetEditor(editor);
        }
        
        public IIncidentsManagement Incidents => new IncidentsManagement(ctx);
        public IIAddressManagement Addresses => new AddressManagement(ctx);
        public IProductsManagement Products => new ProductsManagement(ctx);
    }
}