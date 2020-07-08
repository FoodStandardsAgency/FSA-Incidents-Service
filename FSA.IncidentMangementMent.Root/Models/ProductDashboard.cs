using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class ProductDashboard
    {
        public ProductDashboard()
        {
            AddressNames = new List<string>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set; }
        public string BatchCodes { get; set; }
        public DateTime LastUpdated { get; set; }
        public IEnumerable<string> AddressNames { get; set; }
    }
}
