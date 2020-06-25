using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class FBODb : BaseEntityDb
    {
        public int Id { get; set; }
        public int FBOTypeId { get; set; }
        public FBOTypeDb FBOType { get; set; }
        public int OrganisationId { get; set; }
        public OrganisationDb Organisation { get; set; }
        public ICollection<ProductFBODb> RelatedProducts { get; set; }
    }
}
