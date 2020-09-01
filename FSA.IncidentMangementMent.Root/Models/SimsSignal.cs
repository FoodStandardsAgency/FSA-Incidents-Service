using System;

namespace FSA.IncidentsManagement.Root.Models
{
    [Obsolete]
    public class OldSimsSignal
    {
        public int CommonId { get; set; }
        public string Id => GeneralExtensions.GenerateSignalsId(CommonId);
        public string Title { get; set; }
    }
}
