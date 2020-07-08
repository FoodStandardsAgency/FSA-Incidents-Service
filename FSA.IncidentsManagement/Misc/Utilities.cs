using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Misc
{
    public static class Utilities
    {
        public static IEnumerable<T> DecomposeEnum<T>() where T : System.Enum
        {
            var arr = Enum.GetValues(typeof(T));
            return new List<T>(arr.OfType<T>());
        }

        public static IEnumerable<ENUM> SelectedFlags<ENUM>(ENUM input) where ENUM : System.Enum
        {
            var enumValues = DecomposeEnum<ENUM>();
            foreach(var item in enumValues)
            {
                if (input.HasFlag(item))
                    yield return item;
            }
        }
    }
}
