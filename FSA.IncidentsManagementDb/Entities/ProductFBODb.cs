using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class ProductFBODb : BaseEntityDb
    {
        public int ProductId { get; set; }
        public ProductDb Product {get;set;}
        public int AddressId { get; set; }
        public FboTypes FBOTypeId { get; set; }
        public AddressDb Address { get; set; }
    }
}
