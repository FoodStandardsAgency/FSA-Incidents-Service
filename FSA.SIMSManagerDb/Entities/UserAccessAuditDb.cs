using FSA.SIMSManagerDb.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities
{
    internal class UserAccessAuditDb :BaseEntityDb
    {
        public int Id {get;set;}
        public string UserId { get; set; }
        public string Scope { get; set; } //incident signal
        public string Page { get; set; }
        public int ScopeId { get; set; }
    }
}
