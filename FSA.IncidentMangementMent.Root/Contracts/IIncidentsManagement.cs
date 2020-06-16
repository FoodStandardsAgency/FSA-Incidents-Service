using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    interface IIncidentsManagement
    {
        public Task<Incident> Get(int Id);

        public Task<IEnumerable<Incident>> GetAll();

        public Task<Incident> UpdateStatus(int Id, int statusId);

        public Task<Incident> AssignIncident(int id, string user);

        public Task<Incident> UpdateClassification(int id, int ClassificationId);

        public void LinkIncident(int from, int to);
    }
}
