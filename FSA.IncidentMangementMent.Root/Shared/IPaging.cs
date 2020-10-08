using System.Collections.Generic;

namespace FSA.IncidentsManagement.Root.Shared
{
    public interface IPaging<T>: IEnumerable<T>
    {
        int TotalResults { get;}
    }

}
