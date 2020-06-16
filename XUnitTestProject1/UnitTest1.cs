using FSA.IncidentsManagement.Root.Models;
using System;
using Xunit;

namespace FSA.UnitTests.IncidentTests
{
    public class IncidentT
    {
        [Fact]
        public void Test1()
        {
            var s = new Incident("New Title", "New Description", 1, 4, 2, 1, 1, 1, 4, 2, 2, 2, 3, null, false, 1, null, DateTime.Now, null, 1, DateTime.Now);
            var j = System.Text.Json.JsonSerializer.Serialize(s);
            Console.WriteLine(j);
        }
    }
}
