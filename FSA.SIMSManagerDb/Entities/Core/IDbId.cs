using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal interface IDbId<T>
    {
        T Id { get; }
    }
}
