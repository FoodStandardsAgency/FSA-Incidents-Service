namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsAddressContact
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool IsMain { get; set; } = false;
    }
}
