using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class ProductFBODb : BaseEntityDb
    {
        public int ProductId { get; set; }
        public ProductDb Product {get;set;}
        public int FBOId { get; set; }
        public FBODb FBO { get; set; }
    }
}
