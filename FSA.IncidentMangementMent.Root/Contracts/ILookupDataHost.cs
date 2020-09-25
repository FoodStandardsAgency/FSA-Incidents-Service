using FSA.IncidentsManagement.Root.Models;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface ILookupDataHost
    {
        // IReferenceDataRepo<Category> Categories { get; }
        // IReferenceDataRepo<Classification> Classifications { get; }
        // IReferenceDataRepo<Priority> Priorities { get; }
        //IReferenceDataRepo<IncidentStatusLkUp> IncidentStatus { get; }
        //IReferenceDataRepo<ContactMethod> ContactMethods { get; }
        //IReferenceDataRepo<Country> Countries { get; }
        //IReferenceDataRepo<DataSource> DataSources { get; }
        //IReferenceDataRepo<DeathIllness> DeathIllnesses { get; }
        //IReferenceDataRepo<ProductType> ProductTypes { get; }
        //IReferenceDataRepo<SignalStatus> SignalStatus { get; }
        //IReferenceDataRepo<UnitQuantity> Units { get; }
        //IReferenceDataRepo<OMITGroup> OMITGroups { get; }
        //IReferenceDataRepo<PersonaRole> PersonaRoles { get; }
        //IReferenceDataRepo<OrganisationRole> OrganisationsRoles { get; }
        //IReferenceDataRepo<OrganisationLookup> Organisations { get; }
        //IReferenceDataRepo<OrganisationLookup> FBOs { get; }
        //IReferenceDataRepo<OrganisationLookup> Notifiers { get; }
        //IReferenceDataRepo<OrganisationLookup> LocalAuthorities { get; }
        //IReferenceDataRepo<AttachmentTagLkup> AttachmentTags { get; }
        //IReferenceDataRepo<FBOType> FBOTypes { get; }
        //IReferenceDataRepo<NotifierType> NotifierTypes { get; }
        //IReferenceDataRepo<AdminLead> AdminLeads { get; }
        //IReferenceDataRepo<ProductDateType> ProductDateTypes { get; }
        //IReferenceDataRepo<StakeholderType> StakeholderTypes { get; }
        //IReferenceDataRepo<StakeholderIncidentRole> StakeholderIncidentRoles { get; }

        LookupsHost GetAll();
    }
}
