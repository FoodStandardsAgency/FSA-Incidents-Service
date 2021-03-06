﻿using FSA.SIMSManagerDb.Entities.Lookups;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal abstract class BaseStakeholderDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int HostId { get; set; }
        //public HostDb Host { get; set; }
        public string Name { get; set; }
        public string GovDept { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int StakeholderDiscriminatorId { get; set; }
        public StakeholderDiscriminatorDb StakeholderDiscriminator { get; set; }
        public int? AddressId { get; set; }
        public AddressDb Address {get;set;}
    }
}
