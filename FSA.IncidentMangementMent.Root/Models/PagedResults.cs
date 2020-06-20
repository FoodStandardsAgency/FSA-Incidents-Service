using FSA.IncidentsManagement.Root.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class PagedResult<T> : IPaging<T>
    {
        
        public int TotalResults { get; }
        public IEnumerable<T> Results { get; }
        public PagedResult(IEnumerable<T> results, int totalResults)
        {
            this.Results = results;
            TotalResults = totalResults;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var itm in Results) yield return itm;
        }

        IEnumerator IEnumerable.GetEnumerator() => this.Results.GetEnumerator();
    }
}
