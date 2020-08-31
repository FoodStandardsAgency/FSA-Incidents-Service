using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.DTOS
{
   
    public class SimsProductDisplayModel : SimsProduct
    {
        public SimsProductDisplayModel()
        {
            PackSizes = new List<SimsProductPackSize>();
            ProductDates = new List<SimsProductDate>();
        }

        public string DataSource { get; set; }
        public string SignalUrl { get; set; }


    }
}
