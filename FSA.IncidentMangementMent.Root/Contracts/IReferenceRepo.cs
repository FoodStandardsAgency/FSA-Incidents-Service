﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IReferenceDataRepo<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> GetAll();
        Task<T> Find(string title);
    }
}
