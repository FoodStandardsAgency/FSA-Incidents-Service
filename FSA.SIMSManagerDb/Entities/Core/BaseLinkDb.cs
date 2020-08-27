namespace FSA.SIMSManagerDb.Entities.Core
{
    internal abstract class BaseLinkDb<T> : BaseEntityDb where T : IDbId<int>
    {
        public int FromId { get; set; }
        public int ToId { get; set; }
        public T From { get; set; }
        public T To { get; set; }
    }
}
