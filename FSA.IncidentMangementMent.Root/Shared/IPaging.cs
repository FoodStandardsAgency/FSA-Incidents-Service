using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Shared
{
    public interface IPaging<T>: IEnumerable<T>
    {
        int TotalResults { get;}
    }

}
