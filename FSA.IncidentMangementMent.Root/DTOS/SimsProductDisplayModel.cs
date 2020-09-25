using System.Collections.Generic;

namespace FSA.IncidentsManagement.Root.DTOS
{

    public class SimsProductDisplayModel : SimsProduct
    {
        public SimsProductDisplayModel()
        {
            PackSizes = new List<SimsProductPackSize>();
            ProductDates = new List<SimsProductDate>();
        }
        
        public int DataSourceId { get; set; }
        public string SignalUrl { get; set; }
        public string SignalDataSource { get; set; }

    }
}
