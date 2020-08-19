using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class NotifierAddress :SimsAddress
    {
        public int NotifierId { get; set; }
        public string NotifierType { get; set; }
    }
}
