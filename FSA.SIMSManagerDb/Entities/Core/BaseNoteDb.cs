﻿using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDbEntities.Helpers;
using System;

namespace FSA.SIMSManagerDbEntities
{
    internal abstract class BaseNoteDb : BaseEntityDb
    {
        public int Id{ get; set; }
        public string Note { get; set; }
        public int HostId { get; set; }
        public int TagFlags { get; set; }
    }
}
