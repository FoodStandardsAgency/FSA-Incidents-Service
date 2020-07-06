using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FSA.IncidentsManagementDb
{
    internal static class MappingExtensionsDb
    {
        public static Category ToClient(this CategoryDb @this)
        {
            return new Category
            {
                Id = @this.Id,
                Title = @this.Title
            };
        }

        public static Priority ToClient(this PriorityDb @this) => new Priority
        {
            Id = @this.Id,
            Title = @this.Title
        };

        public static Classification ToClient(this ClassificationDb @this) => new Classification
        {
            Id = @this.Id,
            Title = @this.Title
        };

        public static ContactMethod ToClient(this ContactMethodDb @this) => new ContactMethod
        {
            Id = @this.Id,
            Title = @this.Title
        };

        public static Country ToClient(this CountryDb @this) => new Country
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static NotifierType ToClient(this NotifierTypeDb @this) => new NotifierType
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static DataSource ToClient(this DataSourceDb @this) => new DataSource
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static DeathIllness ToClient(this DeathIllnessDb @this) => new DeathIllness
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static OMITGroup ToClient(this OMITGroupDb @this) => new OMITGroup
        {
            Id = @this.Id,
            Title = @this.Title,
        };


        public static FBOType ToClient(this FBOTypeDb @this) => new FBOType
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static ProductDateType ToClient(this DateTypeDb @this) => new ProductDateType
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static IEnumerable<OrganisationDb> ToDb(this IEnumerable<OrganisationAddress> @this)
        {
            foreach (var itm in @this)
            {
                yield return itm.ToDb();
            }
        }

        public static OrganisationAddress ToClient(this OrganisationDb @this) => new OrganisationAddress
        {
            Id = @this.Id,
            Title = @this.Title,
            MainContact = @this.MainContact,
            AddressLine1 = @this.AddressLine1,
            AddressLine2 = @this.AddressLine2,
            TownCity = @this.TownCity,
            County = @this.County,
            CountryId = @this.CountryId,
            PostCode = @this.PostCode,
            TelephoneNumber = @this.TelephoneNumber,
            EmailAddress = @this.EmailAddress,
            ContactMethodId = @this.ContactMethodId
        };



        public static OrganisationDb ToDb(this OrganisationAddress @this) => new OrganisationDb
        {
            Id = @this.Id,
            Title = @this.Title,
            MainContact = @this.MainContact,
            AddressLine1 = @this.AddressLine1,
            AddressLine2 = @this.AddressLine2,
            TownCity = @this.TownCity,
            County = @this.County,
            CountryId = @this.CountryId,
            PostCode = @this.PostCode,
            TelephoneNumber = @this.TelephoneNumber,
            EmailAddress = @this.EmailAddress,
            ContactMethodId = @this.ContactMethodId
        };

        public static OrganisationRole ToClient(this OrganisationRoleDb @this) => new OrganisationRole
        {
            Id = @this.Id,
            Title = @this.Title,
            CanBeFBO = @this.CanBeFBO,
            CanBeLocalAuthority = @this.CanBeLocalAuthority,
            CanBeNotifier = @this.CanBeNotifier
        };

        public static PersonaRole ToClient(this PersonaRoleDb @this) => new PersonaRole
        {
            Id = @this.Id,
            Title = @this.Title,
            CanBeAdminLead = @this.CanBeAdminLead,
            CanBeIncidentLead = @this.CanBeIncidentLead,
            CanBeFieldOfficer = @this.CanBeFieldOfficer
        };


        public static AdminLead ToClient(this AdminLeadDb @this) => new AdminLead
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static ProductType ToClient(this ProductTypeDb @this) => new ProductType
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static UnitQuantity ToClient(this UnitQuantityDb @this) => new UnitQuantity
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static SignalStatus ToClient(this SignalStatusDb @this) => new SignalStatus
        {
            Id = @this.Id,
            Title = @this.Title,
            ParentId = @this.ParentId,
            IsOpen = @this.IsOpen,
            IsUnassigned = @this.IsUnassigned
        };

        public static IncidentStatusLkUp ToClient(this IncidentStatusDb @this) => new IncidentStatusLkUp { Id = @this.Id, Title = @this.Title };

        public static IEnumerable<BaseIncident> ToClient(this IEnumerable<IncidentDb> @this)
        {
            foreach (var itm in @this)
            {
                yield return itm.ToClient();
            }
        }

        public static BaseIncident ToClient(this IncidentDb @this)
        {
            return new BaseIncident(
                @this.Id,
                mostUniqueId: @this.MostUniqueId,
                incidentTitle: @this.IncidentTitle,
                incidentDescription: @this.IncidentDescription,
                incidentTypeId: @this.IncidentTypeId,
                contactMethodId: @this.ContactMethodId,
                statusId: @this.IncidentStatusId,
                signalStatusId: @this.SignalStatusId,
                notifierId: @this.NotifierId,
                principalFBOId: @this.PrincipalFBOId,
                priorityId: @this.PriorityId,
                classificationId: @this.ClassificationId,
                dataSourceId: @this.DataSourceId,
                productTypeId: @this.ProductTypeId,
                leadOfficer: @this.LeadOfficer,
                leadOffice: @this.LeadOffice,
                adminLeadId: @this.AdminLeadId ?? 0,
                fieldOfficer: @this.FieldOfficer,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId,
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId,
                receivedOn: @this.ReceivedOn,
                incidentCreated: @this.IncidentCreated,
                incidentClosed: @this.IncidentClosed,
                lastChangedBy: @this.ModifiedBy,
                lastChangedDate: @this.Modified
                );
        }

        public static IncidentsDisplayModel ToClientDisplay(this IncidentDb @this)
        {
            return new IncidentsDisplayModel(
                     @this.Id,
                mostUniqueId: @this.MostUniqueId,
                incidentTitle: @this.IncidentTitle,
                incidentDescription: @this.IncidentDescription,
                incidentTypeId: @this.IncidentTypeId,
                contactMethodId: @this.ContactMethodId,
                statusId: @this.IncidentStatusId,
                signalStatusId: @this.SignalStatusId,
                notifierId: @this.NotifierId,
                principalFBOId: @this.PrincipalFBOId,
                priorityId: @this.PriorityId,
                classificationId: @this.ClassificationId,
                dataSourceId: @this.DataSourceId,
                productTypeId: @this.ProductTypeId,
                leadOfficer: @this.LeadOfficer,
                leadOffice: @this.LeadOffice,
                adminLeadId: @this.AdminLeadId ?? 0,
                fieldOfficer: @this.FieldOfficer,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId,
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId,
                receivedOn: @this.ReceivedOn,
                incidentCreated: @this.IncidentCreated,
                incidentClosed: @this.IncidentClosed,
                lastChangedBy: @this.ModifiedBy,
                lastChangedDate: @this.Modified,
                category: @this.IncidentType.Title,
                signalStatus: @this.SignalStatus?.Title ?? "",
                incidentStatus: @this.IncidentStatus.Title,
                notifier: @this.NotifierId.HasValue ? @this.Notifier.Organisation.Title : "Unassigned", // allOrgs.ContainsKey(@this.NotifierId ?? 0) ? allOrgs[@this.NotifierId ?? 0].Name : "",
                priority: @this.Priority?.Title ?? "",
                classification: @this.Classification?.Title ?? "",
                dataSource: @this.DataSource?.Title ?? "",
                productType: @this.ProductType?.Title ?? "",
                leadLocalAuthority: @this.LeadLocalAuthorityId.HasValue ? @this.LeadLocalAuthority.Organisation.Title : "Unassigned",
                adminLead: @this.AdminLeadId.HasValue && @this.AdminLeadId != 0 ? @this.AdminLead.Title : "Unassigned",
                deathIllness: @this.DeathIllness?.Title ?? "",
                principalFBO: @this.PrincipalFBO?.Organisation.Title ?? "",
                fBOEmail: @this.PrincipalFBO?.Organisation.EmailAddress ?? "",
                fBOPhone: @this.PrincipalFBO?.Organisation.TelephoneNumber ?? "",
                fBOAddressLine1: @this.PrincipalFBO?.Organisation.AddressLine1 ?? "",
                fBOAddressLine2: @this.PrincipalFBO?.Organisation.AddressLine2 ?? "",
                fBOAddressTown: @this.PrincipalFBO?.Organisation.TownCity ?? "",
                fBOAddressPostcode: @this.PrincipalFBO?.Organisation.PostCode ?? ""
                );
        }

        public static void ToUpdateDb(this BaseIncident @this, IncidentDb entity)
        {
            entity.IncidentTitle = @this.IncidentTitle;
            //entity.MostUniqueId = @this.MostUniqueId;
            entity.IncidentDescription = @this.IncidentDescription;
            entity.IncidentTypeId = @this.IncidentTypeId;
            entity.ContactMethodId = @this.ContactMethodId;
            entity.IncidentStatusId = @this.StatusId;
            entity.PriorityId = @this.PriorityId;
            entity.SignalStatusId = @this.SignalStatusId;
            entity.NotifierId = @this.NotifierId;
            entity.PrincipalFBOId = @this.PrincipalFBOId;
            entity.ClassificationId = @this.ClassificationId;
            entity.DataSourceId = @this.DataSourceId;
            entity.ProductTypeId = @this.ProductTypeId;
            entity.LeadOfficer = @this.LeadOfficer;
            entity.LeadOffice = @this.LeadOffice;
            entity.AdminLeadId = @this.AdminLeadId;
            entity.FieldOfficer = @this.FieldOfficer;
            entity.LeadLocalAuthorityId = @this.LeadLocalAuthorityId;
            entity.LAAdvised = @this.LAAdvised;
            entity.DeathIllnessId = @this.DeathIllnessId;
            //entity.ReceivedOn = @this.ReceivedOn;
            //entity.IncidentCreated = @this.IncidentCreated;
            entity.IncidentClosed = @this.IncidentClosed;
        }

        public static IncidentDb ToDb(this BaseIncident @this)
        {
            return new IncidentDb
            {
                Id = @this.CommonId,
                IncidentTitle = @this.IncidentTitle,
                IncidentDescription = @this.IncidentDescription,
                IncidentTypeId = @this.IncidentTypeId,
                ContactMethodId = @this.ContactMethodId,
                IncidentStatusId = @this.StatusId,
                PriorityId = @this.PriorityId,
                SignalStatusId = @this.SignalStatusId,
                NotifierId = @this.NotifierId,
                PrincipalFBOId = @this.PrincipalFBOId,
                ClassificationId = @this.ClassificationId,
                DataSourceId = @this.DataSourceId,
                ProductTypeId = @this.ProductTypeId,
                LeadOfficer = @this.LeadOfficer,
                LeadOffice = @this.LeadOffice,
                AdminLeadId = @this.AdminLeadId,
                FieldOfficer = @this.FieldOfficer,
                LeadLocalAuthorityId = @this.LeadLocalAuthorityId,
                LAAdvised = @this.LAAdvised,
                DeathIllnessId = @this.DeathIllnessId,
                ReceivedOn = @this.ReceivedOn,
                IncidentCreated = @this.IncidentCreated,
                IncidentClosed = @this.IncidentClosed,
            };
        }

        public static ProductDb ToDb(this Product @this)
        {
            return new ProductDb
            {
                Id = @this.Id,
                IncidentId = @this.IncidentId,
                Brand = @this.Brand,
                Name = @this.Name,
                ProductTypeId = @this.ProductTypeId,
                CountryOfOriginId = @this.CountryOfOriginId,
                Amount = @this.Amount,
                AdditionalInfo = @this.AdditionalInfo ?? "",
                AmountUnitTypeId = @this.AmountUnitTypeId,
                BatchCodes = @this.BatchCodes,
                DataSourceId = @this.DataSourceId,
                PackDescription = @this.PackDescription,
                ProductDates = @this.ProductDates.ToDb().ToList(),
                PackSizes = @this.PackSizes.ToDb().ToList(),
            };
        }

        public static Product ToClient(this ProductDb @this) => new Product
        {
            Id = @this.Id,
            IncidentId = @this.IncidentId,
            AdditionalInfo = @this.AdditionalInfo ?? "",
            AmountUnitTypeId = @this.AmountUnitTypeId,
            Amount = @this.Amount,
            BatchCodes = @this.BatchCodes,
            Brand = @this.Brand,
            CountryOfOriginId = @this.CountryOfOriginId,
            DataSourceId = @this.DataSourceId,
            Name = @this.Name,
            PackDescription = @this.PackDescription,
            PackSizes = @this.PackSizes?.ToClient().ToList() ?? new List<ProductPackSize>(),
            ProductDates = @this.ProductDates?.ToClient().ToList() ?? new List<ProductDate>(),
            ProductTypeId = @this.ProductTypeId,
            SignalUrl = @this.SignalUrl,
            Added = @this.Created,
            LastUpdated = @this.Modified,
            LastUpdatedBy = @this.ModifiedBy
        };

        public static void ToUpdateDb(this Product @this, ProductDb product)
        {
            product.Id = @this.Id;
            product.IncidentId = @this.IncidentId;
            product.AdditionalInfo = @this.AdditionalInfo ?? "";
            product.AmountUnitTypeId = @this.AmountUnitTypeId;
            product.Amount = @this.Amount;
            product.BatchCodes = @this.BatchCodes;
            product.Brand = @this.Brand;
            product.CountryOfOriginId = @this.CountryOfOriginId;
            product.DataSourceId = @this.DataSourceId;
            product.Name = @this.Name;
            product.PackDescription = @this.PackDescription;
            product.PackSizes = @this.PackSizes.ToDb(product.PackSizes.ToList()).ToList();
            product.ProductDates = @this.ProductDates.ToDb(product.ProductDates.ToList()).ToList();
            product.ProductTypeId = @this.ProductTypeId;
            product.SignalUrl = @this.SignalUrl;
        }

        public static ProductDetail ToDetail(this ProductDb @this) => new ProductDetail
        {
            Id = @this.Id,
            Name = @this.Name,
            Brand = @this.Brand,
            PackDescription = @this.PackDescription,
            BatchCodes = @this.BatchCodes,
            Amount = @this.Amount,
            AmountTypeId = @this.AmountUnitTypeId,
            AdditionalInfo = @this.AdditionalInfo,
            CountryOfOriginId = @this.CountryOfOriginId,
            PackSizes = @this.PackSizes?.ToClient().ToList() ?? new List<ProductPackSize>(),
            ProductDates = @this.ProductDates?.ToClient().ToList() ?? new List<ProductDate>(),
        };

        public static IEnumerable<ProductPackSizeDb> ToDb(this IEnumerable<ProductPackSize> @this, List<ProductPackSizeDb> sourceItems = null)
        {

            if (sourceItems != null)
            {
                foreach (var item in @this)
                {
                    var sourceItem = sourceItems.Find(o => o.Id == item.Id);
                    if (sourceItem != null)
                        yield return item.ToDb(sourceItem);
                    else
                        yield return item.ToDb();
                }
            }
            else
            {
                foreach (var item in @this)
                {
                    yield return item.ToDb();
                }
            }
        }

        public static IEnumerable<ProductDateDb> ToDb(this IEnumerable<ProductDate> @this, List<ProductDateDb> sourceItems = null)
        {

            if (sourceItems != null)
            {
                foreach (var item in @this)
                {
                    var sourceItem = sourceItems.Find(o => o.Id == item.Id);
                    if (sourceItem != null)
                        yield return item.ToDb(sourceItem);
                    else
                        yield return item.ToDb();
                }
            }
            else
            {
                foreach (var item in @this)
                {
                    yield return item.ToDb();
                }
            }
        }

        public static IEnumerable<ProductPackSize> ToClient(this IEnumerable<ProductPackSizeDb> @this)
        {
            foreach (var item in @this)
            {
                yield return item.ToClient();
            }
        }

        public static IEnumerable<ProductDate> ToClient(this IEnumerable<ProductDateDb> @this)
        {
            foreach (var item in @this)
            {
                yield return item.ToClient();
            }
        }

        public static ProductDate ToClient(this ProductDateDb @this) => new ProductDate
        {
            Id = @this.Id,
            DateTypeId = @this.DateTypeId,
            Date = @this.Date
        };

        public static ProductPackSize ToClient(this ProductPackSizeDb @this) => new ProductPackSize
        {
            Id = @this.Id,
            ProductId = @this.ProductId,
            Size = @this.Size,
            UnitId = @this.UnitId
        };

        public static ProductDateDb ToDb(this ProductDate @this) => new ProductDateDb
        {
            DateTypeId = @this.DateTypeId,
            Date = @this.Date
        };

        public static ProductDateDb ToDb(this ProductDate @this, ProductDateDb sourceItem)
        {
            sourceItem.DateTypeId = @this.DateTypeId;
            sourceItem.Date = @this.Date;
            return sourceItem;
        }



        public static ProductPackSizeDb ToDb(this ProductPackSize @this) => new ProductPackSizeDb
        {
            Id = @this.Id,
            ProductId = @this.ProductId,
            Size = @this.Size,
            UnitId = @this.UnitId
        };

        public static ProductPackSizeDb ToDb(this ProductPackSize @this, ProductPackSizeDb sourceItem)
        {
            sourceItem.Size = @this.Size;
            sourceItem.UnitId = @this.UnitId;
            return sourceItem;
        }

        public static IncidentNote ToClient(this IncidentCommentDb @this) => new IncidentNote
        {
            Id = @this.Id,
            Note = @this.Comment,
            Created = @this.Created,
            CreatedBy = @this.CreatedBy,
            IncidentId = @this.IncidentId
        };

        public static IncidentDashboardView ToDashboard(this IncidentDb @this)
        {
            return new IncidentDashboardView
            {
                CommonId = @this.Id,
                Priority = @this.Priority?.Title ?? "TBC",
                Title = @this.IncidentTitle,
                Notifier = @this.Notifier?.Organisation == null ? "Unassigned" : @this.Notifier?.Organisation.Title,
                LeadOfficer = @this.LeadOfficer ?? "Unassigned",
                Status = @this.IncidentStatus?.Title ?? "UNK",
                Updated = @this.Modified,
                Links = @this.ToLinks.Select(o => o.FromIncidentId)
                            //.Concat(@this.ToLinks.Select(o => o.FromIncidentId)
                            .Concat(@this.FromLinks.Select(o => o.ToIncidentId))
                            //.Concat(@this.ToLinks.Select(o => o.ToIncidentId))
                            .ToList()
            };
        }

        public static OrganisationLookup ToLookup(this OrganisationDb @this) => new OrganisationLookup { Id = @this.Id, Name = @this.Title };

        public static OrganisationLookup ToLookup(this OrganisationLookupDb @this) => new OrganisationLookup { Id = @this.Id, Name = @this.Title };

        public static FboAddress ToClient(this FBODb @this) => new FboAddress
        {
            Id = @this.Organisation.Id,
            Title = @this.Organisation.Title,
            MainContact = @this.Organisation.MainContact,
            AddressLine1 = @this.Organisation.AddressLine1,
            AddressLine2 = @this.Organisation.AddressLine2,
            TownCity = @this.Organisation.TownCity,
            County = @this.Organisation.County,
            PostCode = @this.Organisation.PostCode,
            CountryId = @this.Organisation.CountryId,
            TelephoneNumber = @this.Organisation.TelephoneNumber,
            EmailAddress = @this.Organisation.EmailAddress,
            ContactMethodId = @this.Organisation.ContactMethodId,
            FboId = @this.Id,
            FboTypes = @this.FBOTypeId
        };

        public static NotifierAddress ToClient(this NotifierDb @this) => new NotifierAddress
        {
            Id = @this.Organisation.Id,
            Title = @this.Organisation.Title,
            MainContact = @this.Organisation.MainContact,
            AddressLine1 = @this.Organisation.AddressLine1,
            AddressLine2 = @this.Organisation.AddressLine2,
            TownCity = @this.Organisation.TownCity,
            County = @this.Organisation.County,
            PostCode = @this.Organisation.PostCode,
            CountryId = @this.Organisation.CountryId,
            TelephoneNumber = @this.Organisation.TelephoneNumber,
            EmailAddress = @this.Organisation.EmailAddress,
            ContactMethodId = @this.Organisation.ContactMethodId,
            NotifierId = @this.Id,
            NotifierType = @this.NotifierType.Title
        };

    }
}
