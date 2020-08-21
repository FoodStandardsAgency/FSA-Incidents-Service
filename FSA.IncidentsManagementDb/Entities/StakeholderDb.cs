namespace FSA.IncidentsManagementDb.Entities
{
    internal class StakeholderDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public IncidentDb Incident { get; set; }
        public string FirstNameDept { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int StakeholderDiscriminatorId { get; set; }
        public StakeholderDiscriminatorDb StakeholderDiscriminator { get; set; }
        public int? AddressId { get; set; }
    }
}
