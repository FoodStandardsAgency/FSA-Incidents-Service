﻿using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbLookups
    {
        IEnumerable<Country> Countries { get; }

        LookupsHost GetAll();
        SimsExternalLookups GetExternalLookups();
    }

}
