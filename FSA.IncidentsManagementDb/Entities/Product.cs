using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class ProductDb : BaseEntityDb
    {
        public string Title { get; set; }
        public int ProductTypeId { get; set; }
        public ProductTypeDb ProductType { get; set; }
        public int CountryId { get; set; }
        public CountryDb Country { get; set; }
        public int QuantityOfProductsMade { get; set; }
        public int QuantityOfUnitsMade { get; set; }
        public int PackSize { get; set; }
        public string PackDescription { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime? UseByDate { get; set; }
        public DateTime? BestBeforeDate { get; set; }
        public DateTime? DisplayUntil { get; set; }
        public ICollection<OrganisationDb> FboFebo { get; set; }
        public string BatchCodes { get; set; }
    
    }
}
