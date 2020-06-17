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
            var s = new Incident("New Title", "New Description", 1, 4, 2, null, 1, 1, 1,2, 4, 2, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), null, false, 1, null, DateTime.Now, null, Guid.NewGuid().ToString(), DateTime.Now);
            var j = System.Text.Json.JsonSerializer.Serialize(s);
            Console.WriteLine(j);
        }
    }
}
