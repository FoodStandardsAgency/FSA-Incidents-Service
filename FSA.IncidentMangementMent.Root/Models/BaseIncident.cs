﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    /// <summary>
    /// Base means the most simple parts, 
    /// excluding some collections and other information.
    /// </summary>
    public class BaseIncident
    {
        private readonly int _Id;

        ///Full record
        public BaseIncident(int id, Guid mostUniqueId, string incidentTitle, string incidentDescription, int incidentTypeId, int contactMethodId, int statusId, int? signalStatusId, int? notifierId, int? principalFBOId, int priorityId, int classificationId, int dataSourceId, int productTypeId, string leadOfficer, string leadOffice, int adminLeadId, string fieldOfficer, int? leadLocalAuthorityId, bool lAAdvised, int deathIllnessId, DateTime? receivedOn, DateTime incidentCreated, DateTime? incidentClosed, string lastChangedBy, DateTime lastChangedDate)
        {
            _Id = id;
            MostUniqueId = mostUniqueId;
            IncidentTitle = incidentTitle;
            IncidentDescription = incidentDescription;
            IncidentTypeId = incidentTypeId;
            ContactMethodId = contactMethodId;
            SignalStatusId = signalStatusId;
            StatusId = statusId;
            NotifierId = notifierId;
            PrincipalFBOId = principalFBOId;
            PriorityId = priorityId;
            ClassificationId = classificationId;
            DataSourceId = dataSourceId;
            ProductTypeId = productTypeId;
            LeadOfficer = leadOfficer;
            LeadOffice = leadOffice;
            AdminLeadId = adminLeadId;
            FieldOfficer = fieldOfficer;
            LeadLocalAuthorityId = leadLocalAuthorityId;
            LAAdvised = lAAdvised;
            DeathIllnessId = deathIllnessId;
            ReceivedOn = receivedOn;
            IncidentCreated = incidentCreated;
            IncidentClosed = incidentClosed;
            LastChangedBy = lastChangedBy;
            LastChangedDate = lastChangedDate;
        }

        // New record
        public BaseIncident(string incidentTitle, string incidentDescription, int incidentTypeId, int contactMethodId, int statusId, int? signalStatusId, int? notifierId, int? principalFBOId, int priorityId, int classificationId, int dataSourceId, int productTypeId, string leadOfficer, string leadOffice, int adminLeadId, string fieldOfficer, int? leadLocalAuthorityId, bool lAAdvised, int deathIllnessId, DateTime? receivedOn, DateTime incidentCreated, DateTime? incidentClosed, string lastChangedBy, DateTime lastChangedDate) : this(0, Guid.Empty, incidentTitle, incidentDescription, incidentTypeId, contactMethodId, statusId, signalStatusId, notifierId, principalFBOId, priorityId, classificationId, dataSourceId, productTypeId, leadOfficer, leadOffice, adminLeadId, fieldOfficer, leadLocalAuthorityId, lAAdvised, deathIllnessId, receivedOn, incidentCreated, incidentClosed, lastChangedBy, lastChangedDate)
        {

        }


        public string Id => this.FormatId();
        public int CommonId => this._Id;

        public Guid MostUniqueId { get; }
        public string IncidentTitle { get; }
        public string IncidentDescription { get; }
        public int IncidentTypeId { get; }
        public int ContactMethodId { get; }
        public int StatusId { get; }
        public int? SignalStatusId { get; }
        public int? NotifierId { get; }

        public int? PrincipalFBOId { get; }
        public int PriorityId { get; }
        public int ClassificationId { get; }
        public int DataSourceId { get; }
        public int ProductTypeId { get; }
        public string LeadOfficer { get; }
        public string LeadOffice { get; }
        public int AdminLeadId { get; }
        public string FieldOfficer { get; }
        public int? LeadLocalAuthorityId { get; }
        public bool LAAdvised { get; }
        public int DeathIllnessId { get; }
        public DateTime? ReceivedOn { get; }
        public DateTime IncidentCreated { get; }
        public DateTime? IncidentClosed { get; }
        public string LastChangedBy { get; }
        public DateTime LastChangedDate { get; }

        private string FormatId()
        {
            return GeneralExtensions.GenerateIncidentId(this._Id);
        }

        //public ICollection<IncidentCommentDb> Comments {get;}

    }

    public static class BaseIncidentExtensions
    {
        public static BaseIncident WithStatus(this BaseIncident @this, int newStatusId) => new BaseIncident(
                 @this.CommonId,
                mostUniqueId: @this.MostUniqueId,
                incidentTitle: @this.IncidentTitle,
                incidentDescription: @this.IncidentDescription,
                incidentTypeId: @this.IncidentTypeId,
                contactMethodId: @this.ContactMethodId,
                statusId: newStatusId,
                signalStatusId: @this.SignalStatusId,
                notifierId: @this.NotifierId,
                principalFBOId: @this.PrincipalFBOId,
                priorityId: @this.PriorityId,
                classificationId: @this.ClassificationId,
                dataSourceId: @this.DataSourceId,
                productTypeId: @this.ProductTypeId,
                leadOfficer: @this.LeadOfficer,
                leadOffice: @this.LeadOffice,
                adminLeadId: @this.AdminLeadId,
                fieldOfficer: @this.FieldOfficer,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId,
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId,
                receivedOn: @this.ReceivedOn,
                incidentCreated: @this.IncidentCreated,
                incidentClosed: @this.IncidentClosed,
                lastChangedBy: @this.LastChangedBy,
                lastChangedDate: @this.LastChangedDate
                );

        public static BaseIncident WithLeadOfficer(this BaseIncident @this, string officer) => new BaseIncident(
                @this.CommonId,
               mostUniqueId: @this.MostUniqueId,
               incidentTitle: @this.IncidentTitle,
               incidentDescription: @this.IncidentDescription,
               incidentTypeId: @this.IncidentTypeId,
               contactMethodId: @this.ContactMethodId,
               statusId: @this.StatusId,
               signalStatusId: @this.SignalStatusId,
               notifierId: @this.NotifierId,
               principalFBOId: @this.PrincipalFBOId,
               priorityId: @this.PriorityId,
               classificationId: @this.ClassificationId,
               dataSourceId: @this.DataSourceId,
               productTypeId: @this.ProductTypeId,
               leadOfficer: officer,
               leadOffice: @this.LeadOffice,
               adminLeadId: @this.AdminLeadId,
               fieldOfficer: @this.FieldOfficer,
               leadLocalAuthorityId: @this.LeadLocalAuthorityId,
               lAAdvised: @this.LAAdvised,
               deathIllnessId: @this.DeathIllnessId,
               receivedOn: @this.ReceivedOn,
               incidentCreated: @this.IncidentCreated,
               incidentClosed: @this.IncidentClosed,
               lastChangedBy: @this.LastChangedBy,
                lastChangedDate: @this.LastChangedDate
                );

        public static BaseIncident WithMostUnique(this BaseIncident @this, Guid newGuid) => new BaseIncident(
                @this.CommonId,
               mostUniqueId: newGuid,
               incidentTitle: @this.IncidentTitle,
               incidentDescription: @this.IncidentDescription,
               incidentTypeId: @this.IncidentTypeId,
               contactMethodId: @this.ContactMethodId,
               statusId: @this.StatusId,
               signalStatusId: @this.SignalStatusId,
               notifierId: @this.NotifierId,
               principalFBOId: @this.PrincipalFBOId,
               priorityId: @this.PriorityId,
               classificationId: @this.ClassificationId,
               dataSourceId: @this.DataSourceId,
               productTypeId: @this.ProductTypeId,
               leadOfficer: @this.LeadOfficer,
               leadOffice: @this.LeadOffice,
               adminLeadId: @this.AdminLeadId,
               fieldOfficer: @this.FieldOfficer,
               leadLocalAuthorityId: @this.LeadLocalAuthorityId,
               lAAdvised: @this.LAAdvised,
               deathIllnessId: @this.DeathIllnessId,
               receivedOn: @this.ReceivedOn,
               incidentCreated: @this.IncidentCreated,
               incidentClosed: @this.IncidentClosed,
               lastChangedBy: @this.LastChangedBy,
                lastChangedDate: @this.LastChangedDate
                );

        public static BaseIncident WithPriority(this BaseIncident @this, int priorityType) => new BaseIncident(
                @this.CommonId,
               mostUniqueId: @this.MostUniqueId,
               incidentTitle: @this.IncidentTitle,
               incidentDescription: @this.IncidentDescription,
               incidentTypeId: @this.IncidentTypeId,
               contactMethodId: @this.ContactMethodId,
               statusId: @this.StatusId,
               signalStatusId: @this.SignalStatusId,
               notifierId: @this.NotifierId,
               principalFBOId: @this.PrincipalFBOId,
               priorityId: priorityType,
               classificationId: @this.ClassificationId,
               dataSourceId: @this.DataSourceId,
               productTypeId: @this.ProductTypeId,
               leadOfficer: @this.LeadOfficer,
               leadOffice: @this.LeadOffice,
               adminLeadId: @this.AdminLeadId,
               fieldOfficer: @this.FieldOfficer,
               leadLocalAuthorityId: @this.LeadLocalAuthorityId,
               lAAdvised: @this.LAAdvised,
               deathIllnessId: @this.DeathIllnessId,
               receivedOn: @this.ReceivedOn,
               incidentCreated: @this.IncidentCreated,
               incidentClosed: @this.IncidentClosed,
               lastChangedBy: @this.LastChangedBy,
                lastChangedDate: @this.LastChangedDate
                );

    }
}
