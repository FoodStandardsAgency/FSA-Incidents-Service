using FSA.SIMSManagerDb.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities
{
    internal class SignalLinkDb : BaseLinkDb
    {
        public SignalDb From { get; set; }
        public SignalDb To { get; set; }
    }
}
