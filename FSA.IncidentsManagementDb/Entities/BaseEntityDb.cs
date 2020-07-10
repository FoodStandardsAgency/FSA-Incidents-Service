using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    /// <summary>
    ///  All entities will required this information in one form or another.
    /// </summary>
    internal abstract class BaseEntityDb
    {
        public string ModifiedBy { get; set; }
        public DateTime Modified { get; set; }

        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }

        public byte[] Timestamp { get; set; }
    }

}
