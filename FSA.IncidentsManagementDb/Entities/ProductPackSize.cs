using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class ProductPackSizeDb : BaseEntityDb
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public int UnitId { get; set; }
        public UnitQuantityDb Unit { get; set; }
        public int ProductId { get; set; }
        public ProductDb Product {get;set;}
    }
}
 