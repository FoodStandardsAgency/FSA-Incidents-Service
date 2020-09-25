using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    /// <summary>
    /// Simple interface for the lookup data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISimsReferenceData<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> GetAll();
        Task<T> Find(string title);
    }
}
