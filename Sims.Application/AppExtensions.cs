using System;
using System.Collections.Generic;
using System.Linq;

namespace Sims.Application
{
    internal static class AppExtensions
    {
        public static string GenerateIncidentId(int Id) => GetFormattedNumber("I", Id.ToString("D6"));
        public static string GenerateSignalsId(int Id) => GetFormattedNumber("S", Id.ToString("D6"));
        private static string GetFormattedNumber(string prefix, string paddedNumber) => $"{prefix}-{paddedNumber.Substring(0, 3)}-{paddedNumber.Substring(3, 3)}";
    }
}
