using System.Collections;
using System.Collections.Generic;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class StakeholderDiscriminatorDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<StakeholderDb> Stakeholders { get; set; }
    }
}
