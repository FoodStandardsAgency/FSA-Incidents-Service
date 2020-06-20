using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root
{
    public static class GeneralExtensions
    {
        public static string GenerateIncidentId(int Id)
        {
            var paddedNumber = Id.ToString("D6");
            return $"I-{paddedNumber.Substring(0, 3)}-{paddedNumber.Substring(3, 3)}";
        }
    }
}
