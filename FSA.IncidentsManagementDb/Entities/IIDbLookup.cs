using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal interface IIDbLookup
    {
        int Id { get; }
        string Title { get; }
    }
}
