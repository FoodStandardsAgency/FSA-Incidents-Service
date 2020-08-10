using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class SIMSTerm
    {
        public string Title { get; set; }
        public Guid Id { get; set; }
        public IList<SIMSTerm> Children => new List<SIMSTerm>();
    }
}
