using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSLookups
    {
        LookupsHost GetAll();
    }
}
