using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class FBODb : BaseEntityDb
    {
        public int Id { get; set; }
        public FboTypes FBOTypeId { get; set; }
        //public FBOTypeDb FBOType { get; set; }
        public int OrganisationId { get; set; }
        public AddressDb Organisation { get; set; }
        public ICollection<ProductFBODb> RelatedProducts { get; set; }
    }
}
