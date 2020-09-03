using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class DashboardSearchViewModel
    {
        public string Search { get; set; }
        public int? PageSize { get; set; }
        public int PageNo { get; set; }
    }
}
