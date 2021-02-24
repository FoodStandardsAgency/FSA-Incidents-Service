using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSA.IncidentsManagement.Root.Shared
{
    public static class AppExtensions
    {
        public static IEnumerable<T> DecomposeEnum<T>() where T : System.Enum
        {
            var arr = Enum.GetValues(typeof(T));
            return new List<T>(arr.OfType<T>());
        }

        public static IEnumerable<ENUM> SelectedFlags<ENUM>(this ENUM input) where ENUM : System.Enum
        {
            var enumValues = DecomposeEnum<ENUM>();
            foreach (var item in enumValues)
            {
                if (input.HasFlag(item))
                    yield return item;
            }
        }

        public static IEnumerable<int> ConvertToFlagArray(this int input)
        {
            if (input == 0) return new[] { 0 };
            var result = new List<int>();

            BitArray bits = new BitArray(new[] { input });

            for (var x = 0; x < 32; ++x)
            {
                if (bits[x] == true)
                {
                    result.Add((int)Math.Pow(2, x));
                }
            }

            return result.ToList();
        }
    }
}
