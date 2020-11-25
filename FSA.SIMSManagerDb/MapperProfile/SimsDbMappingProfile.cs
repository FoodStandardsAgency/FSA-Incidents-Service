using AutoMapper;
using AutoMapper.EquivalencyExpression;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.DTOS.Lookups;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Lookups;
using FSA.SIMSManagerDbEntities.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FSA.SIMSManagerDb.MapperProfile
{
    public class SimsDbMappingProfile : Profile
    {
        public SimsDbMappingProfile()
        {

            CreateMap<HazardGroupDb, HazardGroup>(MemberList.Destination);
            CreateMap<ClassificationDb, Classification>(MemberList.Destination);
            CreateMap<PriorityDb, Priority>(MemberList.Destination);
            CreateMap<IncidentStatusDb, IncidentStatusLkUp>(MemberList.Destination);
            CreateMap<ContactMethodDb, ContactMethod>(MemberList.Destination);
            CreateMap<CountryDb, Country>(MemberList.Destination);
            CreateMap<DataSourceDb, DataSource>(MemberList.Destination);

            CreateMap<DeathIllnessDb, DeathIllness>(MemberList.Destination);
            CreateMap<ProductTypeDb, ProductType>(MemberList.Destination);
            CreateMap<SignalStatusDb, SignalStatus>(MemberList.Destination);
            CreateMap<UnitQuantityDb, UnitQuantity>(MemberList.Destination);
            CreateMap<IncidentSourceDb, IncidentSource>(MemberList.Destination);
            CreateMap<DocumentTagDb, AttachmentTagLkup>(MemberList.Destination);

            CreateMap<FBOTypeDb, FBOType>(MemberList.Destination);
            CreateMap<NotifierTypeDb, NotifierType>(MemberList.Destination);
            CreateMap<AdminLeadDb, AdminLead>(MemberList.Destination);
            CreateMap<DateTypeDb, ProductDateType>(MemberList.Destination);
            CreateMap<StakeholderDiscriminatorDb, StakeholderType>(MemberList.Destination);
            CreateMap<StakeholderIncidentRoleDb, StakeholderIncidentRole>(MemberList.Destination);

            CreateMap<CloseSignalReasonDb, CloseSignalReason>(MemberList.Destination);
            CreateMap<CloseSignalTeamDb, CloseSignalTeam>(MemberList.Destination);

            CreateMap<IncidentLinkDb, SimsLinkedRecord>()
                    .ForMember(o => o.From, m => m.MapFrom(a => a.FromId))
                    .ForMember(o => o.To, m => m.MapFrom(a => a.ToId));
            CreateMap<SignalLinkDb, SimsLinkedRecord>()
                    .ForMember(o => o.From, m => m.MapFrom(a => a.FromId))
                    .ForMember(o => o.To, m => m.MapFrom(a => a.ToId));


            CreateMap<SignalStakeholderDb, SimsStakeholder>(MemberList.Destination)
                .ForMember(a => a.DiscriminatorId, m => m.MapFrom(a => a.StakeholderDiscriminatorId))
                .ForMember(a => a.AddressTitle, m => m.MapFrom(a => $"{(a.Address != null ? a.Address.Title : String.Empty)}"));

            CreateMap<IncidentStakeholderDb, SimsStakeholder>(MemberList.Destination)
                .ForMember(a => a.DiscriminatorId, m => m.MapFrom(a => a.StakeholderDiscriminatorId))
                .ForMember(a => a.AddressTitle, m => m.MapFrom(a => $"{(a.Address != null ? a.Address.Title : String.Empty)}"));

            CreateMap<OnlineFormStakeholderDb, SimsStakeholder>(MemberList.Destination)
                .ForMember(a => a.DiscriminatorId, m => m.MapFrom(a => a.StakeholderDiscriminatorId))
               .ForMember(a => a.AddressTitle, m => m.MapFrom(a => $"{(a.Address != null ? a.Address.Title : String.Empty)}"));


            CreateMap<SignalStakeholderDb, IncidentStakeholderDb>(MemberList.Destination)
                .ForMember(a => a.Timestamp, m => m.Ignore())
                .ForMember(a => a.Id, m => m.Ignore());

            CreateMap<OnlineFormStakeholderDb, IncidentStakeholderDb>(MemberList.Destination)
                .ForMember(a => a.Timestamp, m => m.Ignore())
                .ForMember(a => a.Id, m => m.Ignore());

            CreateMap<IncidentNoteDb, SimsNote>(MemberList.Destination);
            CreateMap<SignalNoteDb, SimsNote>(MemberList.Destination);
            CreateMap<OnlineFormNoteDb, SimsNote>(MemberList.Destination);

            CreateMap<SimsAddress, AddressDb>(MemberList.Source);
            CreateMap<AddressDb, SimsAddress>(MemberList.Destination);

            CreateMap<SimsAddressContact, AddressContactDb>(MemberList.Source);
            CreateMap<AddressContactDb, SimsAddressContact>(MemberList.Destination);

            CreateMap<SimsStakeholder, IncidentStakeholderDb>(MemberList.Source)
                .ForMember(a => a.StakeholderDiscriminatorId, m => m.MapFrom(a => a.DiscriminatorId));

            CreateMap<SimsStakeholder, SignalStakeholderDb>(MemberList.Source)
                .ForMember(a => a.StakeholderDiscriminatorId, m => m.MapFrom(a => a.DiscriminatorId));

            CreateMap<SimsStakeholder, OnlineFormStakeholderDb>(MemberList.Source)
                .ForMember(a => a.StakeholderDiscriminatorId, m => m.MapFrom(a => a.DiscriminatorId));

            CreateMap<IncidentAttachmentDb, SimsAttachmentFileInfo>(MemberList.Destination)
                    .ForMember(a => a.UserId, m => m.MapFrom(o => o.CreatedBy))
                    .ForMember(a => a.Url, m => m.MapFrom(o => o.DocUrl))
                    .ForMember(a => a.Tags, m => m.MapFrom(o => (int)o.TagFlags))
                    .ForMember(o => o.FileName, m => m.MapFrom(o => Path.GetFileName(o.DocUrl)));

            CreateMap<SignalAttachmentDb, SimsAttachmentFileInfo>(MemberList.Destination)
                    .ForMember(a => a.UserId, m => m.MapFrom(o => o.CreatedBy))
                    .ForMember(a => a.Url, m => m.MapFrom(o => o.DocUrl))
                    .ForMember(a => a.Tags, m => m.MapFrom(o => (int)o.TagFlags))
                    .ForMember(o => o.FileName, m => m.MapFrom(o => Path.GetFileName(o.DocUrl)));

            CreateMap<IncidentDb, IncidentsDisplayModel>(MemberList.Destination)
                .ForCtorParam("statusId", o => o.MapFrom(a => a.IncidentStatusId))
                .ForCtorParam("adminLeadId", o => o.MapFrom(@this => @this.AdminLeadId ?? 0))
                .ForCtorParam("lastChangedBy", o => o.MapFrom(a => a.ModifiedBy))
                .ForCtorParam("lastChangedDate", o => o.MapFrom(a => a.Modified))
                .ForCtorParam("incidentTypeId", o => o.MapFrom(@this => @this.IncidentTypeId))
                .ForCtorParam("signalStatus", o => o.MapFrom(a => a.IncidentStatus.Title))
                .ForCtorParam("incidentType", o => o.MapFrom(a => a.IncidentType.Title))
                .ForCtorParam("incidentStatus", o => o.MapFrom(a => a.IncidentStatus.Title))
                .ForCtorParam("incidentSource", o => o.MapFrom(a => a.IncidentSource.Title))
                .ForCtorParam("notifier", o => o.MapFrom(a => a.NotifierId.HasValue ? a.Notifier.Title : "Unassigned"))
                .ForCtorParam("priority", o => o.MapFrom(a => a.Priority != null ? a.Priority.Title : ""))
                .ForCtorParam("classification", o => o.MapFrom(a => a.Classification != null ? a.Classification.Title : ""))
                .ForCtorParam("dataSource", o => o.MapFrom(a => a.DataSource != null ? a.DataSource.Title : ""))
                .ForCtorParam("productType", o => o.MapFrom(a => a.ProductTypeId != 0 ? a.ProductType.Title : ""))
                .ForCtorParam("leadLocalAuthority", o => o.MapFrom(a => a.LeadLocalAuthorityId.HasValue ? a.LeadLocalAuthority.Title : "Unassigned"))
                .ForCtorParam("adminLead", o => o.MapFrom(@this => @this.AdminLeadId.HasValue && @this.AdminLeadId != 0 ? @this.AdminLead.Title : "Unassigned"))
                .ForCtorParam("deathIllness", o => o.MapFrom(@this => @this.DeathIllnessId != 0 ? @this.DeathIllness.Title : "Unassigned"))
                .ForCtorParam("principalFBO", o => o.MapFrom(@this => @this.PrincipalFBOId.HasValue && @this.PrincipalFBOId != 0 ? @this.PrincipalFBO.Title : "Unassigned"))
                .ForCtorParam("fBOEmail", o => o.MapFrom(@this => ""))
                .ForCtorParam("fBOPhone", o => o.MapFrom(@this => @this.PrincipalFBOId.HasValue && @this.PrincipalFBOId != 0 ? @this.PrincipalFBO.TelephoneNumber : "Unassigned"))
                .ForCtorParam("fBOAddressLine1", o => o.MapFrom(@this => @this.PrincipalFBOId.HasValue && @this.PrincipalFBOId != 0 ? @this.PrincipalFBO.AddressLine1 : "Unassigned"))
                .ForCtorParam("fBOAddressLine2", o => o.MapFrom(@this => @this.PrincipalFBOId.HasValue && @this.PrincipalFBOId != 0 ? @this.PrincipalFBO.AddressLine2 : "Unassigned"))
                .ForCtorParam("fBOAddressTown", o => o.MapFrom(@this => @this.PrincipalFBOId.HasValue && @this.PrincipalFBOId != 0 ? @this.PrincipalFBO.TownCity : "Unassigned"))
                .ForCtorParam("fBOAddressPostcode", o => o.MapFrom(@this => @this.PrincipalFBOId.HasValue && @this.PrincipalFBOId != 0 ? @this.PrincipalFBO.PostCode : "Unassigned"));

            CreateMap<SimsSignal, SignalDb>(MemberList.Source)
                .ForMember(a => a.Id, m => m.MapFrom(a => a.CommonId))
                .ForMember(a => a.SPTId, m => m.Ignore())
                .ForMember(a => a.PublishedDate, m => m.Ignore())
                .ForMember(a => a.InsertedDate, m => m.Ignore())
                .ForMember(a => a.SourceLink, m => m.Ignore())
                .ForSourceMember(a => a.LastUpdated, m => m.DoNotValidate());

            CreateMap<SimsOnlineForm, OnlineFormDb>(MemberList.Source)
                 .ForMember(a => a.Id, m => m.MapFrom(a => a.CommonId));


            CreateMap<SignalDb, SimsSignal>(MemberList.Destination)
                .ForMember(a => a.CommonId, m => m.MapFrom(a => a.Id))
                .ForMember(a => a.SignalStatusId, m => m.MapFrom(o => o.SignalStatusId))
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Modified));

            CreateMap<IncidentDb, BaseIncident>(MemberList.Source)
                .ForCtorParam("statusId", o => o.MapFrom(a => a.IncidentStatusId))
                .ForCtorParam("lastChangedBy", o => o.MapFrom(a => a.ModifiedBy))
                .ForCtorParam("lastChangedDate", o => o.MapFrom(a => a.Modified));



            CreateMap<BaseIncident, IncidentDb>(MemberList.Source)
                .IgnoreAuditData()
                .ForMember(a => a.MostUniqueId, a => a.Ignore())
                .ForMember(a => a.Id, m => m.MapFrom(a => a.CommonId))
                .ForMember(a => a.IncidentStatusId, m => m.MapFrom(a => a.StatusId));

            CreateMap<OnlineFormDb, SimsOnlineForm>(MemberList.Source)
                .ForMember(a => a.CommonId, m => m.MapFrom(a => a.Id));


            CreateMap<IncidentDb, IncidentDashboardItem>()
                .ForMember(a => a.Title, m => m.MapFrom(b => b.IncidentTitle))
                .ForMember(a => a.Notifier, m => m.MapFrom(b => b.NotifierId.HasValue && b.NotifierId != 0 ? b.Notifier.Title : "Unassigned"))
                .ForMember(a => a.CommonId, m => m.MapFrom(a => a.Id))
                .ForMember(a => a.Status, m => m.MapFrom(a => a.IncidentStatus.Title))
                .ForMember(a => a.Updated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.Priority, m => m.MapFrom(a => a.Priority.Title))
                .ForMember(a => a.Links, m => m.MapFrom(a => a.ToLinks.Select(o => o.FromId)
                .Concat(a.FromLinks.Select(o => o.ToId).ToList())));

            CreateMap<SignalDb, SignalDashboardItem>(MemberList.Destination)
                .ForMember(a => a.CommonId, m => m.MapFrom(a => a.Id))
                .ForMember(a => a.Status, m => m.MapFrom(a => a.SignalStatus.Title))
                .ForMember(a => a.Updated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.DateReceived, m => m.MapFrom(a => a.InsertedDate))
                .ForMember(a => a.Links, m => m.MapFrom(a => a.ToLinks.Select(o => o.FromId)
                .Concat(a.FromLinks.Select(o => o.ToId).ToList())));

            CreateMap<IncidentProductDb, SimsProduct>(MemberList.Destination)
                .ForMember(a => a.AdditionalInfo, m => m.MapFrom(a => String.IsNullOrEmpty(a.AdditionalInfo) ? "" : a.AdditionalInfo))
                .ForMember(a => a.Added, m => m.MapFrom(a => a.Created))
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.LastUpdatedBy, m => m.MapFrom(a => a.ModifiedBy));

            CreateMap<SignalProductDb, SimsProduct>(MemberList.Destination)
                .ForMember(a => a.AdditionalInfo, m => m.MapFrom(a => String.IsNullOrEmpty(a.AdditionalInfo) ? "" : a.AdditionalInfo))
                .ForMember(a => a.Added, m => m.MapFrom(a => a.Created))
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.LastUpdatedBy, m => m.MapFrom(a => a.ModifiedBy));


            CreateMap<OnlineFormProductDb, SimsProduct>(MemberList.Destination)
                .ForMember(a => a.AdditionalInfo, m => m.MapFrom(a => String.IsNullOrEmpty(a.AdditionalInfo) ? "" : a.AdditionalInfo))
                .ForMember(a => a.Added, m => m.MapFrom(a => a.Created))
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.LastUpdatedBy, m => m.MapFrom(a => a.ModifiedBy));


            CreateMap<SimsProduct, IncidentProductDb>(MemberList.Source)
                .ForMember(a => a.AdditionalInfo, m => m.MapFrom(a => String.IsNullOrEmpty(a.AdditionalInfo) ? "" : a.AdditionalInfo))
                .IgnoreAuditData();

            CreateMap<SimsProduct, SignalProductDb>(MemberList.Source)
                .ForMember(a => a.AdditionalInfo, m => m.MapFrom(a => String.IsNullOrEmpty(a.AdditionalInfo) ? "" : a.AdditionalInfo))
                .IgnoreAuditData();

            CreateMap<SimsProduct, OnlineFormProductDb>(MemberList.Source)
                .ForMember(a => a.AdditionalInfo, m => m.MapFrom(a => String.IsNullOrEmpty(a.AdditionalInfo) ? "" : a.AdditionalInfo))
                .IgnoreAuditData();

            CreateMap<SignalProductDb, IncidentProductDb>(MemberList.Source)
                  .IgnoreAuditData()
                .ForMember(a => a.Id, m => m.Ignore())
                .ForMember(a => a.Host, m => m.Ignore())
                .ForMember(a => a.ProductType, m => m.Ignore())
                .ForMember(a => a.CountryOfOrigin, m => m.Ignore())
                .ForMember(a => a.AmountUnitType, m => m.Ignore())
                .ForMember(a => a.HostId, m => m.Ignore());

            CreateMap<OnlineFormProductDb, IncidentProductDb>(MemberList.Source)
                      .IgnoreAuditData()
                    .ForMember(a => a.Id, m => m.Ignore())
                    .ForMember(a => a.Host, m => m.Ignore())
                    .ForMember(a => a.ProductType, m => m.Ignore())
                    .ForMember(a => a.CountryOfOrigin, m => m.Ignore())
                    .ForMember(a => a.AmountUnitType, m => m.Ignore())
                    .ForMember(a => a.HostId, m => m.Ignore());

            CreateMap<SignalProductFboDb, IncidentProductFboDb>(MemberList.Source)
                  .IgnoreAuditData()
                  .ForMember(a => a.Product, m => m.Ignore())
                  .ForMember(a => a.ProductId, m => m.Ignore());

            CreateMap<OnlineFormProductFboDb, IncidentProductFboDb>(MemberList.Source)
                  .IgnoreAuditData()
                  .ForMember(a => a.Product, m => m.Ignore())
                  .ForMember(a => a.ProductId, m => m.Ignore());

            CreateMap<SignalProductPackSizeDb, IncidentProductPackSizeDb>(MemberList.Source)
                .IgnoreAuditData()
                .ForMember(a => a.Id, m => m.Ignore())
                 .ForMember(a => a.Product, m => m.Ignore())
                 .ForMember(a => a.Unit, m => m.Ignore())
                .ForMember(a => a.ProductId, m => m.Ignore());

            CreateMap<OnlineFormProductPackSizeDb, IncidentProductPackSizeDb>(MemberList.Source)
                    .IgnoreAuditData()
                    .ForMember(a => a.Id, m => m.Ignore())
                     .ForMember(a => a.Product, m => m.Ignore())
                     .ForMember(a => a.Unit, m => m.Ignore())
                    .ForMember(a => a.ProductId, m => m.Ignore());

            CreateMap<SignalProductDateDb, IncidentProductDateDb>(MemberList.Source)
                .IgnoreAuditData()
                .ForMember(a => a.Id, m => m.Ignore())
                .ForMember(a => a.Product, m => m.Ignore())
                .ForMember(a => a.ProductId, m => m.Ignore());

            CreateMap<OnlineFormProductDateDb, IncidentProductDateDb>(MemberList.Source)
                    .IgnoreAuditData()
                    .ForMember(a => a.Id, m => m.Ignore())
                    .ForMember(a => a.Product, m => m.Ignore())
                    .ForMember(a => a.ProductId, m => m.Ignore());


            CreateMap<SignalNoteDb, IncidentNoteDb>(MemberList.Source)
                .IgnoreAuditData()
                .ForMember(a => a.Id, m => m.Ignore())
                .ForMember(a => a.HostId, m => m.Ignore());
            
            CreateMap<OnlineFormNoteDb, IncidentNoteDb>(MemberList.Source)
                .IgnoreAuditData()
                .ForMember(a => a.Id, m => m.Ignore())
                .ForMember(a => a.HostId, m => m.Ignore());

            CreateMap<SimsProductPackSize, IncidentProductPackSizeDb>(MemberList.Source)
                    .EqualityComparison((dto, o) => dto.Id == o.Id)
                    .IgnoreAuditData();

            CreateMap<SimsProductPackSize, SignalProductPackSizeDb>(MemberList.Source)
                    .EqualityComparison((dto, o) => dto.Id == o.Id)
                    .IgnoreAuditData();

            CreateMap<SimsProductPackSize, OnlineFormProductPackSizeDb>(MemberList.Source)
                    .EqualityComparison((dto, o) => dto.Id == o.Id)
                    .IgnoreAuditData();

            CreateMap<IncidentProductPackSizeDb, SimsProductPackSize>(MemberList.Destination);
            CreateMap<SignalProductPackSizeDb, SimsProductPackSize>(MemberList.Destination);
            CreateMap<OnlineFormProductPackSizeDb, SimsProductPackSize>(MemberList.Destination);

            CreateMap<SimsProductDate, IncidentProductDateDb>(MemberList.Source)
                .EqualityComparison((dto, o) => dto.Id == o.Id)
                .IgnoreAuditData();

            CreateMap<SimsProductDate, SignalProductDateDb>(MemberList.Source)
                .EqualityComparison((dto, o) => dto.Id == o.Id)
                .IgnoreAuditData();

            CreateMap<SimsProductDate, OnlineFormProductDateDb>(MemberList.Source)
                .EqualityComparison((dto, o) => dto.Id == o.Id)
                .IgnoreAuditData();

            CreateMap<IncidentProductDateDb, SimsProductDate>(MemberList.Destination);
            CreateMap<SignalProductDateDb, SimsProductDate>(MemberList.Destination);
            CreateMap<OnlineFormProductDateDb, SimsProductDate>(MemberList.Destination);

            CreateMap<IncidentProductDb, SimsProductDisplayModel>(MemberList.Destination)
                .ForMember(a => a.DataSourceId, m => m.Ignore())
                .ForMember(a => a.SignalUrl, m => m.Ignore())
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.LastUpdatedBy, m => m.MapFrom(a => a.ModifiedBy))
                .ForMember(a => a.Added, m => m.MapFrom(a => a.Created));

            CreateMap<SignalProductDb, SimsProductDisplayModel>(MemberList.Destination)
                .ForMember(a => a.DataSourceId, m => m.Ignore())
                .ForMember(a => a.SignalUrl, m => m.Ignore())
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.LastUpdatedBy, m => m.MapFrom(a => a.ModifiedBy))
                .ForMember(a => a.Added, m => m.MapFrom(a => a.Created));


            CreateMap<OnlineFormProductDb, SimsProductDisplayModel>(MemberList.Destination)
                .ForMember(a => a.DataSourceId, m => m.Ignore())
                .ForMember(a => a.SignalUrl, m => m.Ignore())
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.LastUpdatedBy, m => m.MapFrom(a => a.ModifiedBy))
                .ForMember(a => a.Added, m => m.MapFrom(a => a.Created));


            CreateMap<IncidentProductDb, SimsProductDetail>(MemberList.Destination);
            CreateMap<SignalProductDb, SimsProductDetail>(MemberList.Destination);
            CreateMap<OnlineFormProductDb, SimsProductDetail>(MemberList.Destination);

            CreateMap<IncidentProductDb, SimsProductDashboard>(MemberList.Destination)
                .ForMember(a => a.ProductType, m => m.MapFrom(a => a.ProductType.Title))
                .ForMember(a => a.AddressNames, m => m.MapFrom(a => a.RelatedFBOs != null ? a.RelatedFBOs.Select(p => p.Address.Title).ToList() : new List<string>()))
                .ForMember(a => a.LastUpdated, m => m.MapFrom(b => b.Modified));

            CreateMap<SignalProductDb, SimsProductDashboard>(MemberList.Destination)
                .ForMember(a => a.ProductType, m => m.MapFrom(a => a.ProductType.Title))
                .ForMember(a => a.LastUpdated, m => m.MapFrom(b => b.Modified))
                .ForMember(a => a.AddressNames, m => m.MapFrom(a => a.RelatedFBOs != null ? a.RelatedFBOs.Select(p => p.Address.Title).ToList() : new List<string>()));

            CreateMap<IncidentProductFboDb, SimsProductFboAddress>(MemberList.Destination)
            .ForMember(a => a.Id, m => m.MapFrom(m => m.AddressId))
                .ForMember(a => a.Title, m => m.MapFrom(m => m.Address.Title))
                .ForMember(a => a.AddressLine1, m => m.MapFrom(m => m.Address.AddressLine1))
                .ForMember(a => a.AddressLine2, m => m.MapFrom(m => m.Address.AddressLine2))
                .ForMember(a => a.PostCode, m => m.MapFrom(m => m.Address.PostCode))
                .ForMember(a => a.County, m => m.MapFrom(m => m.Address.County))
                .ForMember(a => a.CountryId, m => m.MapFrom(m => m.Address.CountryId))
                .ForMember(a => a.CountryId, m => m.MapFrom(m => m.Address.CountryId))
                .ForMember(a => a.TownCity, m => m.MapFrom(m => m.Address.TownCity))
                .ForMember(a => a.TelephoneNumber, m => m.MapFrom(m => m.Address.TelephoneNumber))
                .ForMember(a => a.ContactMethodId, m => m.MapFrom(m => m.Address.ContactMethodId))
                .ForMember(a => a.Contacts, m => m.MapFrom(m => m.Address.Contacts));

            CreateMap<SignalProductFboDb, SimsProductFboAddress>(MemberList.Destination)
                .ForMember(a => a.Id, m => m.MapFrom(m => m.AddressId))
                .ForMember(a => a.Title, m => m.MapFrom(m => m.Address.Title))
                .ForMember(a => a.AddressLine1, m => m.MapFrom(m => m.Address.AddressLine1))
                .ForMember(a => a.AddressLine2, m => m.MapFrom(m => m.Address.AddressLine2))
                .ForMember(a => a.PostCode, m => m.MapFrom(m => m.Address.PostCode))
                .ForMember(a => a.County, m => m.MapFrom(m => m.Address.County))
                .ForMember(a => a.CountryId, m => m.MapFrom(m => m.Address.CountryId))
                .ForMember(a => a.CountryId, m => m.MapFrom(m => m.Address.CountryId))
                .ForMember(a => a.TownCity, m => m.MapFrom(m => m.Address.TownCity))
                .ForMember(a => a.TelephoneNumber, m => m.MapFrom(m => m.Address.TelephoneNumber))
                .ForMember(a => a.ContactMethodId, m => m.MapFrom(m => m.Address.ContactMethodId))
                .ForMember(a => a.Contacts, m => m.MapFrom(m => m.Address.Contacts));


            CreateMap<OnlineFormProductFboDb, SimsProductFboAddress>(MemberList.Destination)
                .ForMember(a => a.Id, m => m.MapFrom(m => m.AddressId))
                .ForMember(a => a.Title, m => m.MapFrom(m => m.Address.Title))
                .ForMember(a => a.AddressLine1, m => m.MapFrom(m => m.Address.AddressLine1))
                .ForMember(a => a.AddressLine2, m => m.MapFrom(m => m.Address.AddressLine2))
                .ForMember(a => a.PostCode, m => m.MapFrom(m => m.Address.PostCode))
                .ForMember(a => a.County, m => m.MapFrom(m => m.Address.County))
                .ForMember(a => a.CountryId, m => m.MapFrom(m => m.Address.CountryId))
                .ForMember(a => a.CountryId, m => m.MapFrom(m => m.Address.CountryId))
                .ForMember(a => a.TownCity, m => m.MapFrom(m => m.Address.TownCity))
                .ForMember(a => a.TelephoneNumber, m => m.MapFrom(m => m.Address.TelephoneNumber))
                .ForMember(a => a.ContactMethodId, m => m.MapFrom(m => m.Address.ContactMethodId))
                .ForMember(a => a.Contacts, m => m.MapFrom(m => m.Address.Contacts));


            CreateMap<SimsSignalCloseNoIncident, CloseSignalNoIncidentDb>(MemberList.Source)
                .ForMember(a => a.TeamIds, m => m.MapFrom(b => b.TeamIds.Length == 0 ? null : new Nullable<int>(b.TeamIds.Sum())))
                .ForMember(a => a.ReasonId, m => m.MapFrom(b => b.ReasonId == 0 ? null : b.ReasonId));

            CreateMap<CloseSignalNoIncidentDb, SimsSignalCloseNoIncident>(MemberList.Destination);

        }


    }

    internal static class MappingExtender
    {
        internal static IMappingExpression<T, U> IgnoreAuditData<T, U>(this IMappingExpression<T, U> @this) where U : BaseEntityDb
        {
            return @this.ForMember(a => a.Created, m => m.Ignore())
            .ForMember(a => a.Modified, m => m.UseDestinationValue())
            .ForMember(a => a.CreatedBy, m => m.UseDestinationValue())
            .ForMember(a => a.ModifiedBy, m => m.UseDestinationValue())
            .ForMember(a => a.Timestamp, m => m.UseDestinationValue());
        }
    }

}
