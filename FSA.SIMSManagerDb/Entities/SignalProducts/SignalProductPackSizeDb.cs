using FSA.SIMSManagerDb.Entities.Core.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities
{
    internal class SignalProductPackSizeDb : CoreProductPackSizeDb
    {
        public SignalProductDb Product { get; set; }
    }
}
