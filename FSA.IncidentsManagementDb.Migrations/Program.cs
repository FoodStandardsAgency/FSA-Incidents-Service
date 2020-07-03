using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FSA.IncidentsManagementDb.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var reg = new Regex("[I-i]?(?<number>[0-9]{3,})");
            var reg2 = new Regex("(^|-)(?<number>[0-9]+)");// [I-i]?(?<number>[0-9]{1,})");

            var string1 = "I-000-001";
            var string2 = "I-000-140";

            var string3 = "i-000-000";

            var string4 = "000-008";
            var string5 = "0003000";
            var string6 = "ipeck9";
            var string7 = "i9peck9";


            GottaNumber(string1, reg2);
            GottaNumber(string2, reg2);
            GottaNumber(string3, reg2);
            GottaNumber(string4, reg2);
            GottaNumber(string5, reg2);
            GottaNumber(string6, reg2);
            GottaNumber(string7, reg2);

            //Console.WriteLine($"String 1 {matches.}");


            //Console.WriteLine($"{matches.Groups["number"].Value}");

            //matches = reg.Match(string2);
            //Console.WriteLine($"String 2 {matches.Success}");
            //Console.WriteLine($"{matches.Groups["number"].Value}");

            //matches = reg.Match(string3);
            //Console.WriteLine($"String 3 {matches.Success}");
            //Console.WriteLine($"{matches.Groups["number"].Value}");

            //matches = reg.Match(string4);
            //Console.WriteLine($"String 4 {matches.Success}");
            //Console.WriteLine($"{matches.Groups["number"].Value}");

            //matches = reg.Match(string5);
            //Console.WriteLine($"String 5 {matches.Success}");
            //Console.WriteLine($"{matches.Groups["number"].Value}");

        }

        private static void GottaNumber(string srchTerms, Regex matcher)
        {
            var mc = matcher.Matches(srchTerms);

            if (mc.Count > 0)
            {
                var result = String.Join("", mc.Select(o => o.Groups["number"].Value));
                var finalForm = int.TryParse(result, out var num) ? num : 0;
                Console.WriteLine(finalForm);
            }
            else
            {
                
                Console.WriteLine($"No match : ${srchTerms}");
            }
            
        }
    }
}
