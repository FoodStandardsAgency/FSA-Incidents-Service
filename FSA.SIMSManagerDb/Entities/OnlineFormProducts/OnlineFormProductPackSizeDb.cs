﻿using FSA.SIMSManagerDb.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities
{
    internal class OnlineFormProductPackSizeDb : BaseProductPackSizeDb
    {
        public OnlineFormProductDb Product { get; set; }
    }
}
