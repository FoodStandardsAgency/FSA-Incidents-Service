using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class Signal
    {
        public int CommonId { get; set; }
        public string Id => GeneralExtensions.GenerateSignalsId(CommonId);
        public string Title { get; set; }
    }
}
