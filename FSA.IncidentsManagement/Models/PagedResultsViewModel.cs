using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class PagedResultsViewModel<T>
    {
        public IEnumerable<T> Results { get; set; }
        public  int  TotalRecords { get; set; }
    }
}
