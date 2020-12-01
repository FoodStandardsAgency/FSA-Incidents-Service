namespace Sims.Application.OnlineForm
{
    internal class ExternalStakeholder
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string GovDept { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int StakeholderDiscriminatorId => 2;
    }
}
