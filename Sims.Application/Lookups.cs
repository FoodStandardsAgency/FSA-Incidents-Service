using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;

namespace Sims.Application
{
    internal class Lookups : ISIMSLookups
    {
        private ISimsDbHost simsDbHOst;

        public Lookups(ISimsDbHost simsDbHOst)
        {
            this.simsDbHOst = simsDbHOst;
        }

        public LookupsHost GetAll() => this.simsDbHOst.Lookups.GetAll();

        public SimsExternalLookups GetExternalLookups() => this.simsDbHOst.Lookups.GetExternalLookups();
    }
}