namespace FSA.SIMSManagerDb.Entities.Core
{
    internal abstract class BaseLinkDb : BaseEntityDb
    {
        public int FromId { get; set; }
        public int ToId { get; set; }
    }
}
