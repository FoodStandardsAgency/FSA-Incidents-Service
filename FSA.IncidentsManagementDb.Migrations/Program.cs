using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FSA.IncidentsManagementDb.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringData = File.OpenText("./orgs.json").ReadToEnd();
            var addresses = System.Text.Json.JsonSerializer.Deserialize<List<SimsAddress>>(stringData);

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
