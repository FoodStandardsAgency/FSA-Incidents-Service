using System.Collections;
using System.Collections.Generic;

namespace FSA.IncidentsManagement.Root.Shared
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
