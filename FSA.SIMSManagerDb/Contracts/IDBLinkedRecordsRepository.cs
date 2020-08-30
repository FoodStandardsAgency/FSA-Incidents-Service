﻿using FSA.IncidentsManagement.Root.DTOS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    internal interface IDBLinkedRecordsRepository
    {
        Task<IEnumerable<LinkedRecord>> AddLinks(int from, IEnumerable<int> tos, string reason);
        Task<LinkedRecord> RemoveLink(int from, int to);
    }
}