using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIMS.OnlineForm.Functions.Models
{
    public class BasicLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return $"{Id}:{Title}";
        }
    }

    public class SimsLookupsHost
    {
        public IEnumerable<BasicLookup> Countries { get; set; }
        public IEnumerable<BasicLookup> ProductTypes { get; set; }
        public IEnumerable<BasicLookup> FBOTypes { get; set; }
        public IEnumerable<BasicLookup> Units { get; set; }
        public IEnumerable<BasicLookup> NotifierTypes { get; set; }
        public override string ToString()
        {
            return $"Countries : {Countries.Count()}\nProduct Types : {ProductTypes.Count()}\nFBOTypes : {FBOTypes.Count()}\nUnits : {Units.Count()}\nNotifier Types : {NotifierTypes.Count()}";
        }
    }

}
