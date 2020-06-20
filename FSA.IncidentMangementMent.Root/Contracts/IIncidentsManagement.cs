using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
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

        Task AddLink(int from, int to, string reason);

        Task<IncidentNote> AddNote(int incidentId, string note);

        Task<IPaging<IncidentDashboardView>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1);
        
        Task<Incident> Add(Incident incident);

        Task<Incident> UpdateIncident(Incident incident);
    }
}
