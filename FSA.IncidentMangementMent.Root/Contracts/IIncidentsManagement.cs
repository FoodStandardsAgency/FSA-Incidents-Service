using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IIncidentsManagement
    {
        Task<Incident> Get(int Id);

        Task<IEnumerable<Incident>> GetAll();

        Task<IncidentsDisplayModel> GetDisplayItem(int id);

        Task<Incident> UpdateStatus(int Id, int statusId);

        Task<Incident> AssignLeadOfficer(int id, string user);

        Task<Incident> UpdateClassification(int id, int ClassificationId);

        Task LinkIncident(int from, int to);

        Task<Incident> Add(Incident incident);

        Task<Incident> UpdateIncident(Incident incident);
    }
}
