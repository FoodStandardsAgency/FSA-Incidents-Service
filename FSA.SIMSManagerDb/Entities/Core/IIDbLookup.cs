﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal interface IIDbLookup
    {
        int Id { get; }
        string Title { get; }
    }
}
