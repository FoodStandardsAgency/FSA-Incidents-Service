using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class ProductDisplayModel : Product
    {
        public ProductDisplayModel()
        {
            PackSizes = new List<ProductPackSize>();
            ProductDates = new List<ProductDate>();
        }

        public string DataSource { get; set; }
        public string SignalUrl { get; set; }

    
    }
}
