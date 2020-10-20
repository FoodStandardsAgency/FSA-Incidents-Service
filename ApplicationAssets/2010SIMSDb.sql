IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [AdminLeads] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_AdminLeads] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Classifications] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_Classifications] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [ClosedSignalReasons] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_ClosedSignalReasons] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [ClosedSignalTeams] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_ClosedSignalTeams] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [ContactMethods] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_ContactMethods] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Countries] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [KeyField] nvarchar(56) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [DataSources] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_DataSources] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [DeathIllnesss] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_DeathIllnesss] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [DocumentTags] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_DocumentTags] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [FBOTypes] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_FBOTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [HazardGroups] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_HazardGroups] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [IncidentStatus] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [SortOrder] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_IncidentStatus] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [NotifierTypes] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_NotifierTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Priorities] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_Priorities] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [ProductDateTypes] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_ProductDateTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [ProductTypes] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_ProductTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [SignalStatus] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [SortOrder] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalStatus] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [StakeholderDiscriminatorDb] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_StakeholderDiscriminatorDb] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [StakeholderIncidentRoles] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_StakeholderIncidentRoles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [UnitQuantities] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_UnitQuantities] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Addresses] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [AddressLine1] nvarchar(max) NULL,
    [AddressLine2] nvarchar(max) NULL,
    [TownCity] nvarchar(max) NULL,
    [County] nvarchar(max) NULL,
    [CountryId] int NULL,
    [PostCode] nvarchar(max) NULL,
    [TelephoneNumber] nvarchar(max) NULL,
    [ContactMethodId] int NOT NULL,
    [Uprn] bigint NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Addresses_ContactMethods_ContactMethodId] FOREIGN KEY ([ContactMethodId]) REFERENCES [ContactMethods] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Addresses_Countries_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [Countries] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Signals] (
    [Id] int NOT NULL IDENTITY,
    [SPTId] int NULL,
    [Title] nvarchar(500) NULL,
    [SignalStatusId] int NOT NULL,
    [Priority] nvarchar(max) NULL,
    [LeadOfficer] nvarchar(max) NULL,
    [AlertType] nvarchar(max) NULL,
    [CountryOfOrigin] nvarchar(500) NULL,
    [NotifyingCountry] nvarchar(500) NULL,
    [IsEu] bit NOT NULL,
    [FoodOrFeed] nvarchar(500) NULL,
    [BaseProduct] nvarchar(500) NULL,
    [Manufacturer] nvarchar(max) NULL,
    [Hazard] nvarchar(max) NULL,
    [HazardGroup] nvarchar(max) NULL,
    [DataSource] nvarchar(max) NOT NULL,
    [SourceType] nvarchar(max) NULL,
    [PublishedDate] datetime2 NOT NULL,
    [InsertedDate] datetime2 NOT NULL,
    [SourceLink] nvarchar(max) NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_Signals] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Signals_SignalStatus_SignalStatusId] FOREIGN KEY ([SignalStatusId]) REFERENCES [SignalStatus] ([Id])
);

GO

CREATE TABLE [AddressContacts] (
    [Id] int NOT NULL IDENTITY,
    [AddressId] int NOT NULL,
    [Name] nvarchar(255) NOT NULL,
    [TelephoneNumber] nvarchar(max) NULL,
    [EmailAddress] nvarchar(max) NULL,
    [IsMain] bit NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_AddressContacts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AddressContacts_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Incidents] (
    [Id] int NOT NULL IDENTITY,
    [MostUniqueId] uniqueidentifier NOT NULL DEFAULT (newid()),
    [IncidentTitle] nvarchar(max) NULL,
    [IncidentTypeId] int NOT NULL,
    [ContactMethodId] int NOT NULL,
    [SignalStatusId] int NULL,
    [SignalUrl] nvarchar(max) NULL,
    [IncidentStatusId] int NOT NULL DEFAULT 4,
    [NotifierId] int NULL,
    [PrincipalFBOId] int NULL,
    [PriorityId] int NOT NULL DEFAULT 1,
    [ClassificationId] int NOT NULL,
    [DataSourceId] int NOT NULL,
    [ProductTypeId] int NOT NULL,
    [AdminLeadId] int NULL,
    [LeadOfficer] nvarchar(max) NULL,
    [LeadOffice] nvarchar(max) NULL,
    [FieldOfficer] nvarchar(max) NULL,
    [LeadLocalAuthorityId] int NULL,
    [LAAdvised] bit NOT NULL,
    [DeathIllnessId] int NOT NULL,
    [ReceivedOn] datetime2 NULL,
    [IncidentCreated] datetime2 NOT NULL DEFAULT (getutcdate()),
    [IncidentClosed] datetime2 NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_Incidents] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Incidents_AdminLeads_AdminLeadId] FOREIGN KEY ([AdminLeadId]) REFERENCES [AdminLeads] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Incidents_Classifications_ClassificationId] FOREIGN KEY ([ClassificationId]) REFERENCES [Classifications] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Incidents_ContactMethods_ContactMethodId] FOREIGN KEY ([ContactMethodId]) REFERENCES [ContactMethods] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Incidents_DataSources_DataSourceId] FOREIGN KEY ([DataSourceId]) REFERENCES [DataSources] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Incidents_DeathIllnesss_DeathIllnessId] FOREIGN KEY ([DeathIllnessId]) REFERENCES [DeathIllnesss] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Incidents_IncidentStatus_IncidentStatusId] FOREIGN KEY ([IncidentStatusId]) REFERENCES [IncidentStatus] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Incidents_HazardGroups_IncidentTypeId] FOREIGN KEY ([IncidentTypeId]) REFERENCES [HazardGroups] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Incidents_Addresses_LeadLocalAuthorityId] FOREIGN KEY ([LeadLocalAuthorityId]) REFERENCES [Addresses] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Incidents_Addresses_NotifierId] FOREIGN KEY ([NotifierId]) REFERENCES [Addresses] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Incidents_Addresses_PrincipalFBOId] FOREIGN KEY ([PrincipalFBOId]) REFERENCES [Addresses] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Incidents_Priorities_PriorityId] FOREIGN KEY ([PriorityId]) REFERENCES [Priorities] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Incidents_ProductTypes_ProductTypeId] FOREIGN KEY ([ProductTypeId]) REFERENCES [ProductTypes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Incidents_SignalStatus_SignalStatusId] FOREIGN KEY ([SignalStatusId]) REFERENCES [SignalStatus] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [SignalAttachments] (
    [DocUrl] nvarchar(450) NOT NULL,
    [SignalId] int NOT NULL,
    [TagFlags] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalAttachments] PRIMARY KEY ([DocUrl]),
    CONSTRAINT [FK_SignalAttachments_Signals_SignalId] FOREIGN KEY ([SignalId]) REFERENCES [Signals] ([Id])
);

GO

CREATE TABLE [SignalClosedNoIncident] (
    [SignalId] int NOT NULL,
    [TeamId] int NOT NULL,
    [ReasonId] int NOT NULL,
    [UserReason] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalClosedNoIncident] PRIMARY KEY ([SignalId]),
    CONSTRAINT [FK_SignalClosedNoIncident_ClosedSignalReasons_ReasonId] FOREIGN KEY ([ReasonId]) REFERENCES [ClosedSignalReasons] ([Id]),
    CONSTRAINT [FK_SignalClosedNoIncident_Signals_SignalId] FOREIGN KEY ([SignalId]) REFERENCES [Signals] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SignalClosedNoIncident_ClosedSignalTeams_TeamId] FOREIGN KEY ([TeamId]) REFERENCES [ClosedSignalTeams] ([Id])
);

GO

CREATE TABLE [SignalLinks] (
    [FromId] int NOT NULL,
    [ToId] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalLinks] PRIMARY KEY ([FromId], [ToId]),
    CONSTRAINT [FK_SignalLinks_Signals_FromId] FOREIGN KEY ([FromId]) REFERENCES [Signals] ([Id]),
    CONSTRAINT [FK_SignalLinks_Signals_ToId] FOREIGN KEY ([ToId]) REFERENCES [Signals] ([Id])
);

GO

CREATE TABLE [SignalNotes] (
    [Id] int NOT NULL IDENTITY,
    [Note] nvarchar(max) NOT NULL,
    [SignalId] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalNotes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SignalNotes_Signals_SignalId] FOREIGN KEY ([SignalId]) REFERENCES [Signals] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SignalProducts] (
    [Id] int NOT NULL IDENTITY,
    [HostId] int NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Brand] nvarchar(max) NULL,
    [ProductTypeId] int NOT NULL,
    [CountryOfOriginId] int NOT NULL,
    [Amount] nvarchar(max) NULL DEFAULT N'0.00',
    [AmountUnitTypeId] int NOT NULL,
    [BatchCodes] nvarchar(max) NULL,
    [PackDescription] nvarchar(max) NULL,
    [AdditionalInfo] nvarchar(max) NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalProducts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SignalProducts_UnitQuantities_AmountUnitTypeId] FOREIGN KEY ([AmountUnitTypeId]) REFERENCES [UnitQuantities] ([Id]),
    CONSTRAINT [FK_SignalProducts_Countries_CountryOfOriginId] FOREIGN KEY ([CountryOfOriginId]) REFERENCES [Countries] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SignalProducts_Signals_HostId] FOREIGN KEY ([HostId]) REFERENCES [Signals] ([Id]),
    CONSTRAINT [FK_SignalProducts_ProductTypes_ProductTypeId] FOREIGN KEY ([ProductTypeId]) REFERENCES [ProductTypes] ([Id])
);

GO

CREATE TABLE [SignalStakeholders] (
    [Id] int NOT NULL IDENTITY,
    [SignalId] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [GovDept] nvarchar(max) NULL,
    [Role] nvarchar(max) NULL,
    [Phone] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [StakeholderDiscriminatorId] int NOT NULL,
    [AddressId] int NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalStakeholders] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SignalStakeholders_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SignalStakeholders_Signals_SignalId] FOREIGN KEY ([SignalId]) REFERENCES [Signals] ([Id]),
    CONSTRAINT [FK_SignalStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId] FOREIGN KEY ([StakeholderDiscriminatorId]) REFERENCES [StakeholderDiscriminatorDb] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [IncidentAttachments] (
    [DocUrl] nvarchar(450) NOT NULL,
    [IncidentId] int NOT NULL,
    [TagFlags] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_IncidentAttachments] PRIMARY KEY ([DocUrl]),
    CONSTRAINT [FK_IncidentAttachments_Incidents_IncidentId] FOREIGN KEY ([IncidentId]) REFERENCES [Incidents] ([Id])
);

GO

CREATE TABLE [IncidentLinks] (
    [FromId] int NOT NULL,
    [ToId] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_IncidentLinks] PRIMARY KEY ([FromId], [ToId]),
    CONSTRAINT [FK_IncidentLinks_Incidents_FromId] FOREIGN KEY ([FromId]) REFERENCES [Incidents] ([Id]),
    CONSTRAINT [FK_IncidentLinks_Incidents_ToId] FOREIGN KEY ([ToId]) REFERENCES [Incidents] ([Id])
);

GO

CREATE TABLE [IncidentNotes] (
    [Id] int NOT NULL IDENTITY,
    [Note] nvarchar(max) NOT NULL,
    [IncidentId] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_IncidentNotes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_IncidentNotes_Incidents_IncidentId] FOREIGN KEY ([IncidentId]) REFERENCES [Incidents] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [IncidentProducts] (
    [Id] int NOT NULL IDENTITY,
    [HostId] int NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Brand] nvarchar(max) NULL,
    [ProductTypeId] int NOT NULL,
    [CountryOfOriginId] int NOT NULL,
    [Amount] nvarchar(max) NULL DEFAULT N'0.00',
    [AmountUnitTypeId] int NOT NULL,
    [BatchCodes] nvarchar(max) NULL,
    [PackDescription] nvarchar(max) NULL,
    [AdditionalInfo] nvarchar(max) NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_IncidentProducts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_IncidentProducts_UnitQuantities_AmountUnitTypeId] FOREIGN KEY ([AmountUnitTypeId]) REFERENCES [UnitQuantities] ([Id]),
    CONSTRAINT [FK_IncidentProducts_Countries_CountryOfOriginId] FOREIGN KEY ([CountryOfOriginId]) REFERENCES [Countries] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_IncidentProducts_Incidents_HostId] FOREIGN KEY ([HostId]) REFERENCES [Incidents] ([Id]),
    CONSTRAINT [FK_IncidentProducts_ProductTypes_ProductTypeId] FOREIGN KEY ([ProductTypeId]) REFERENCES [ProductTypes] ([Id])
);

GO

CREATE TABLE [IncidentStakeholders] (
    [Id] int NOT NULL IDENTITY,
    [IncidentId] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [GovDept] nvarchar(max) NULL,
    [Role] nvarchar(max) NULL,
    [Phone] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [StakeholderDiscriminatorId] int NOT NULL,
    [AddressId] int NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_IncidentStakeholders] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_IncidentStakeholders_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_IncidentStakeholders_Incidents_IncidentId] FOREIGN KEY ([IncidentId]) REFERENCES [Incidents] ([Id]),
    CONSTRAINT [FK_IncidentStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId] FOREIGN KEY ([StakeholderDiscriminatorId]) REFERENCES [StakeholderDiscriminatorDb] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SignalIncidentLinks] (
    [SignalId] int NOT NULL,
    [IncidentId] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalIncidentLinks] PRIMARY KEY ([SignalId], [IncidentId]),
    CONSTRAINT [FK_SignalIncidentLinks_Incidents_IncidentId] FOREIGN KEY ([IncidentId]) REFERENCES [Incidents] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SignalIncidentLinks_Signals_SignalId] FOREIGN KEY ([SignalId]) REFERENCES [Signals] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SignalProductDates] (
    [Id] int NOT NULL IDENTITY,
    [SignalId] int NOT NULL,
    [DateTypeId] int NOT NULL,
    [Date] datetime2 NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalProductDates] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SignalProductDates_ProductDateTypes_DateTypeId] FOREIGN KEY ([DateTypeId]) REFERENCES [ProductDateTypes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SignalProductDates_SignalProducts_SignalId] FOREIGN KEY ([SignalId]) REFERENCES [SignalProducts] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SignalProductFbos] (
    [ProductId] int NOT NULL,
    [AddressId] int NOT NULL,
    [FboTypes] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalProductFbos] PRIMARY KEY ([ProductId], [AddressId]),
    CONSTRAINT [FK_SignalProductFbos_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([Id]),
    CONSTRAINT [FK_SignalProductFbos_SignalProducts_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [SignalProducts] ([Id])
);

GO

CREATE TABLE [SignalProductPackSizes] (
    [Id] int NOT NULL IDENTITY,
    [Size] nvarchar(max) NOT NULL,
    [UnitId] int NOT NULL,
    [SignalId] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalProductPackSizes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SignalProductPackSizes_SignalProducts_SignalId] FOREIGN KEY ([SignalId]) REFERENCES [SignalProducts] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SignalProductPackSizes_UnitQuantities_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [UnitQuantities] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [IncidentProductDates] (
    [Id] int NOT NULL IDENTITY,
    [IncidentId] int NOT NULL,
    [DateTypeId] int NOT NULL,
    [Date] datetime2 NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_IncidentProductDates] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_IncidentProductDates_ProductDateTypes_DateTypeId] FOREIGN KEY ([DateTypeId]) REFERENCES [ProductDateTypes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_IncidentProductDates_IncidentProducts_IncidentId] FOREIGN KEY ([IncidentId]) REFERENCES [IncidentProducts] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [IncidentProductFbos] (
    [ProductId] int NOT NULL,
    [AddressId] int NOT NULL,
    [FboTypes] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_IncidentProductFbos] PRIMARY KEY ([ProductId], [AddressId]),
    CONSTRAINT [FK_IncidentProductFbos_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([Id]),
    CONSTRAINT [FK_IncidentProductFbos_IncidentProducts_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [IncidentProducts] ([Id])
);

GO

CREATE TABLE [IncidentProductPackSizes] (
    [Id] int NOT NULL IDENTITY,
    [Size] nvarchar(max) NOT NULL,
    [UnitId] int NOT NULL,
    [IncidentId] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_IncidentProductPackSizes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_IncidentProductPackSizes_IncidentProducts_IncidentId] FOREIGN KEY ([IncidentId]) REFERENCES [IncidentProducts] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_IncidentProductPackSizes_UnitQuantities_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [UnitQuantities] ([Id]) ON DELETE CASCADE
);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[AdminLeads]'))
    SET IDENTITY_INSERT [AdminLeads] ON;
INSERT INTO [AdminLeads] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incidents Branch London'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incidents Branch Northern Ireland'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incidents Branch Wales'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incidents Food Standards Scotland');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[AdminLeads]'))
    SET IDENTITY_INSERT [AdminLeads] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Classifications]'))
    SET IDENTITY_INSERT [Classifications] ON;
INSERT INTO [Classifications] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Routine'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Non-Routine');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Classifications]'))
    SET IDENTITY_INSERT [Classifications] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalReasons]'))
    SET IDENTITY_INSERT [ClosedSignalReasons] ON;
INSERT INTO [ClosedSignalReasons] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (10, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UK Govt. Quarterly Report'),
(9, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UK RASFF'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Research on MySupermarket, Amazon and Google negative for distribution to the UK'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'RASFF notification'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'No useful information'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FDA alert re US border rejection'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Japanese Import alert'),
(11, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UK Recall'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Duplicate of...'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Czech Republic sampling'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'No UK distribution');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalReasons]'))
    SET IDENTITY_INSERT [ClosedSignalReasons] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalTeams]'))
    SET IDENTITY_INSERT [ClosedSignalTeams] ON;
INSERT INTO [ClosedSignalTeams] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Relevant Policy lead'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Imported foods'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NFCU');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalTeams]'))
    SET IDENTITY_INSERT [ClosedSignalTeams] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ContactMethods]'))
    SET IDENTITY_INSERT [ContactMethods] ON;
INSERT INTO [ContactMethods] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Email'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Telephone'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'No Preference');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ContactMethods]'))
    SET IDENTITY_INSERT [ContactMethods] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'KeyField', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries] ([Id], [CreatedBy], [KeyField], [ModifiedBy], [Title])
VALUES (215, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NP', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Nepal'),
(214, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Norway'),
(213, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Netherlands'),
(212, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Nicaragua'),
(211, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Nigeria'),
(210, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NF', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Norfolk Island'),
(209, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Niger'),
(208, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NC', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'New Caledonia'),
(206, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Mozambique'),
(205, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MY', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Malaysia'),
(204, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MX', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Mexico'),
(203, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Malawi'),
(202, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MV', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Maldives'),
(201, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Mauritius'),
(200, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Malta'),
(207, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Namibia'),
(216, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Nauru'),
(228, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Pitcairn, Henderson, Ducie and Oeno Islands'),
(218, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'New Zealand'),
(234, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'QA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Qatar'),
(233, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PY', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Paraguay'),
(232, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Palau'),
(231, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Portugal'),
(230, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Occupied Palestinian Territories'),
(229, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Puerto Rico'),
(199, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Montserrat'),
(217, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'NU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Niue'),
(227, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Saint Pierre and Miquelon'),
(225, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Pakistan'),
(224, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PH', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Philippines'),
(223, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Papua New Guinea'),
(222, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PF', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'French Polynesia'),
(221, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Peru'),
(220, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Panama'),
(219, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'OM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Oman'),
(226, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'PL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Poland'),
(198, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Mauritania'),
(186, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MD', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Moldova'),
(196, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MP', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Northern Mariana Islands'),
(175, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LC', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'St Lucia'),
(174, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LB', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Lebanon'),
(173, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Laos'),
(172, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Kazakhstan'),
(171, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KY', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cayman Islands'),
(170, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Kuwait'),
(169, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'South Korea'),
(176, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Liechtenstein'),
(168, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KP', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'North Korea'),
(166, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Comoros'),
(165, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Kiribati'),
(164, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KH', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cambodia'),
(163, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Kyrgyzstan'),
(162, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Kenya'),
(161, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'JP', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Japan'),
(160, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'JO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Jordan'),
(167, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'KN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'St Kitts and Nevis'),
(197, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MQ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Martinique'),
(177, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Sri Lanka'),
(179, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Lesotho'),
(195, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Macao'),
(194, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Mongolia'),
(193, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Burma'),
(192, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ML', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Mali'),
(191, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Macedonia'),
(190, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MH', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Marshall Islands'),
(189, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Madagascar'),
(178, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Liberia'),
(188, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MF', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Saint-Martin (French part)'),
(235, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'RE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Reunion'),
(185, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MC', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Monaco'),
(184, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'MA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Morocco'),
(183, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LY', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Libya'),
(182, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LV', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Latvia'),
(181, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Luxembourg'),
(180, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'LT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Lithuania'),
(187, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ME', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Montenegro'),
(236, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'RO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Romania'),
(247, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SH-HL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Saint Helena'),
(238, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'RU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Russia'),
(294, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'VC', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'St Vincent'),
(293, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'VA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Vatican City'),
(292, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Uzbekistan'),
(291, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UY', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Uruguay'),
(290, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'US', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'United States'),
(289, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UM-95', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Palmyra Atoll'),
(288, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UM-89', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Kingman Reef'),
(287, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UM-86', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Jarvis Island'),
(286, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UM-84', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Howland Island'),
(285, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UM-81', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Baker Island'),
(284, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UM-79', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Wake Island'),
(283, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UM-76', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Navassa Island'),
(282, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UM-71', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Midway Islands'),
(281, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UM-67', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Johnston Atoll'),
(280, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Uganda'),
(295, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'VE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Venezuela'),
(296, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'VG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'British Virgin Islands'),
(297, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'VI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'United States Virgin Islands'),
(298, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'VN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Vietnam'),
(314, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'territory', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Territory'),
(313, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'other', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other'),
(312, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'not-easily-identified', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Not Easily Identified'),
(311, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'non-EU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'non-EU'),
(310, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'country', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Country'),
(309, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ZW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Zimbabwe'),
(308, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ZM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Zambia'),
(279, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'UA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ukraine'),
(307, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ZA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'South Africa'),
(305, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'YE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Yemen'),
(304, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'XXD', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Dhekelia'),
(303, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'XQZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Akrotiri'),
(302, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'XK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Kosovo'),
(301, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'WS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Samoa'),
(300, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'WF', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Wallis and Futuna'),
(299, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'VU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Vanuatu'),
(306, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'YT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Mayotte'),
(278, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Tanzania'),
(277, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Taiwan'),
(276, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TV', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Tuvalu'),
(254, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Senegal'),
(253, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'San Marino'),
(252, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Sierra Leone'),
(251, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Slovakia'),
(250, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SJ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Svalbard and Jan Mayen'),
(249, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Slovenia'),
(248, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SH-TA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Tristan da Cunha'),
(255, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Somalia'),
(159, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'JM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Jamaica'),
(245, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Singapore'),
(244, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Sweden'),
(243, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SD', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Sudan'),
(242, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SC', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Seychelles'),
(241, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SB', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Solomon Islands'),
(240, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Saudi Arabia'),
(239, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'RW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Rwanda'),
(246, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SH-AC', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ascension'),
(237, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'RS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Serbia'),
(256, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Suriname'),
(258, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ST', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Sao Tome and Principe'),
(275, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Trinidad and Tobago'),
(274, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Turkey'),
(273, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Tonga'),
(272, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Tunisia'),
(271, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Turkmenistan'),
(270, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'East Timor'),
(269, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Tokelau'),
(257, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'South Sudan'),
(268, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TJ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Tajikistan'),
(265, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TF', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'French Southern Territories'),
(264, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TD', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Chad'),
(263, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TC', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Turks and Caicos Islands'),
(262, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Swaziland'),
(261, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SY', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Syria'),
(260, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SX', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Sint Maarten (Dutch part)'),
(259, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SV', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'El Salvador'),
(266, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Togo'),
(158, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'JE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Jersey'),
(267, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TH', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Thailand'),
(156, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Iceland'),
(54, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bosnia and Herzegovina'),
(53, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Azerbaijan'),
(52, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AX', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Aland Islands'),
(51, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Aruba'),
(50, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Australia'),
(49, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Austria'),
(48, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'American Samoa'),
(47, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Argentina'),
(46, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AQ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Antarctica'),
(45, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Angola'),
(44, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Armenia'),
(43, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Albania'),
(42, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Anguilla'),
(41, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Antigua and Barbuda'),
(40, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AF', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Afghanistan'),
(55, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BAT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'British Antarctic Territory'),
(56, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BB', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Barbados'),
(57, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BD', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bangladesh'),
(58, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Belgium'),
(75, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Botswana'),
(74, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BV', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bouvet Island'),
(73, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bhutan'),
(72, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'The Bahamas'),
(71, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Brazil'),
(70, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BQ-SE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Sint Eustatius'),
(69, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BQ-SA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Saba'),
(39, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AE-UQ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Umm al-Quwain'),
(68, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BQ-BO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bonaire'),
(66, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Brunei'),
(65, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bermuda'),
(63, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BJ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Benin'),
(62, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Burundi'),
(61, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BH', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bahrain'),
(60, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bulgaria'),
(59, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BF', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Burkina Faso'),
(67, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bolivia'),
(38, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AE-SH', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Sharjah'),
(37, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AE-RK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ras al-Khaimah'),
(36, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AE-FU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Fujairah'),
(15, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guinea-Bissau'),
(14, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guam'),
(13, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guatemala'),
(12, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'South Georgia and South Sandwich Islands'),
(11, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Greece'),
(10, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GQ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Equatorial Guinea'),
(9, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GP', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guadeloupe'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GY', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guyana'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guinea'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Greenland'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Gibraltar'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GH', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ghana'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guernsey'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GF', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'French Guiana'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Georgia'),
(157, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Italy'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'The Gambia'),
(76, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BY', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Belarus'),
(17, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Hong Kong'),
(19, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Honduras'),
(35, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AE-DU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Dubai'),
(34, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AE-AZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Abu Dhabi'),
(33, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AE-AJ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ajman'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'United Arab Emirates'),
(31, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'AD', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Andorra'),
(30, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Iran'),
(29, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IQ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Iraq'),
(18, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Heard Island and McDonald Islands'),
(28, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'British Indian Ocean Territory'),
(26, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Isle of Man'),
(25, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Israel'),
(24, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ireland'),
(23, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ID', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Indonesia'),
(22, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Hungary'),
(21, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Haiti'),
(20, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Croatia'),
(27, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'India'),
(77, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Belize'),
(64, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'BL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Saint Barthelemy'),
(79, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CC', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cocos (Keeling) Islands'),
(134, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GP', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guadeloupe'),
(133, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guinea'),
(132, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'The Gambia'),
(131, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Greenland'),
(130, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Gibraltar'),
(78, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Canada'),
(128, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guernsey'),
(135, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GQ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Equatorial Guinea'),
(127, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GF', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'French Guiana'),
(125, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GD', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Grenada'),
(124, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GB-WLS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Wales'),
(123, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GB-SCT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Scotland'),
(122, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GB-NIR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Northern Ireland'),
(121, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GB-ENG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'England'),
(120, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GB', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'United Kingdom'),
(119, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GA', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Gabon'),
(126, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Georgia'),
(136, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Greece'),
(137, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GS', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'South Georgia and South Sandwich Islands'),
(138, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guatemala'),
(155, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Iran'),
(154, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IQ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Iraq'),
(153, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'British Indian Ocean Territory'),
(152, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'India'),
(151, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Isle of Man'),
(150, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Israel'),
(149, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'IE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ireland'),
(148, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ID', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Indonesia'),
(147, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Hungary'),
(146, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HT', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Haiti'),
(145, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Croatia'),
(144, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Honduras'),
(143, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Heard Island and McDonald Islands'),
(142, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'HK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Hong Kong'),
(141, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GY', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guyana'),
(140, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guinea-Bissau'),
(139, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Guam'),
(118, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'France'),
(117, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Faroe Islands'),
(129, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'GH', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ghana'),
(115, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Falkland Islands'),
(95, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CY', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cyprus'),
(94, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CX', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Christmas Island'),
(93, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CW', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Curacao'),
(92, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CV', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cape Verde'),
(91, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cuba'),
(90, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CR', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Costa Rica'),
(89, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Colombia'),
(96, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Czechia'),
(88, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CN', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'China'),
(86, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CL', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Chile'),
(116, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Micronesia'),
(84, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ivory Coast'),
(83, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CH', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Switzerland'),
(82, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Congo'),
(81, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CF', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Central African Republic'),
(80, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CD', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Congo (Democratic Republic)'),
(87, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cameroon'),
(97, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'DE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Germany'),
(85, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cook Islands'),
(99, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'DK', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Denmark'),
(98, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'DJ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Djibouti'),
(113, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FI', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Finland'),
(112, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'EU', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'European Union'),
(110, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ES-ML', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Melilla'),
(109, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ES-CE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ceuta'),
(108, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ES', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Spain'),
(107, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ER', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Eritrea'),
(111, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ET', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ethiopia'),
(105, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'EG', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Egypt'),
(100, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'DM', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Dominica'),
(106, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'EH', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Western Sahara'),
(101, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'DO', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Dominican Republic'),
(102, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'DZ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Algeria'),
(114, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FJ', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Fiji'),
(103, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'EC', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ecuador'),
(104, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'EE', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Estonia');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'KeyField', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DataSources]'))
    SET IDENTITY_INSERT [DataSources] ON;
INSERT INTO [DataSources] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (31, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Health Protection Scotland (HPS)'),
(33, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Industry'),
(35, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Local Authority'),
(36, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Marine Management Organisation (MMO)'),
(37, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Maritime & Costguard Agency (MCA)'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Health & Safety Executive'),
(38, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Medicines & Healthcare products Regulatory Agency (MHRA)'),
(39, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Met Office'),
(40, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Crime Agency (NCA)'),
(41, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Food Crime Unit (NFCU)'),
(42, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Food Crime Unit (NFCU) - NFCU INTEL Report'),
(34, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'INFOSAN'),
(51, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'RASFF'),
(45, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Nuclear Power Station'),
(46, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other'),
(47, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Police'),
(48, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Port Health Authority (PHA)'),
(49, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Public Analyst / Laboratory'),
(50, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Public Health England (PHE)'),
(52, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SAC (Scottish Agricultural College)'),
(53, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SOCA'),
(54, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Third Country'),
(55, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Water Company'),
(56, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Veterinary Medicines Directorate'),
(57, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Unmapped SPT Signal Value'),
(30, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Health Protection Agency (HPA)'),
(44, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Health Service (NHS)'),
(29, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Home Office / Border Force'),
(43, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Food Crime Unit (NFCU) - DIM Referral'),
(27, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Unannounced Inspector'),
(28, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'General Public'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Web Form'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Administrative Assistance & Cooperation System (AAC)'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Border Inspection Posts (BIPs)'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Department of Agriculture & Rural Development (DARD)'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Department of Health (DH)'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Department for Environment Food & Rural Affairs (Defra)'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Environment Agency (EA)'),
(9, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'EU Member States'),
(10, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'European Commission (EC)'),
(11, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Fire Services'),
(12, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Standards Scotland (FSS)'),
(13, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Business Assurance Auditors'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Animal & Plant Health Agency (APHA)'),
(15, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA England'),
(14, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Dairy Inspector'),
(26, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Wine Inspector'),
(24, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Survey'),
(23, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA RAM Referral'),
(22, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Poultry Hygiene Inspector'),
(25, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Wales (FSAW)'),
(20, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Northern Ireland (FSANI)'),
(19, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Meat Hygiene Inspector'),
(18, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Field Operations - FVC'),
(17, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Field Operations - FVL'),
(21, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Policy'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Operations Group');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DataSources]'))
    SET IDENTITY_INSERT [DataSources] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DeathIllnesss]'))
    SET IDENTITY_INSERT [DeathIllnesss] ON;
INSERT INTO [DeathIllnesss] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Vomiting'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Diarrhoea'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Abdominal Pain');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DeathIllnesss]'))
    SET IDENTITY_INSERT [DeathIllnesss] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DocumentTags]'))
    SET IDENTITY_INSERT [DocumentTags] ON;
INSERT INTO [DocumentTags] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (64, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Picture'),
(128, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Public warning / Press release'),
(256, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Recipients List'),
(1024, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Screenshot'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Phytosanitary Certifcate'),
(2048, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Translation'),
(512, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Risk assessment'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Health certifiacte'),
(8192, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bill / Delivery Document'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Analytical report'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CVED/CED'),
(4096, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Video File'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Follow up notification');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DocumentTags]'))
    SET IDENTITY_INSERT [DocumentTags] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[FBOTypes]'))
    SET IDENTITY_INSERT [FBOTypes] ON;
INSERT INTO [FBOTypes] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (2048, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Retailer'),
(1024, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Producer'),
(512, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Processor'),
(4096, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Storage'),
(65536, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Wholesaler'),
(16384, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Trader/Broker'),
(32768, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Transporter'),
(256, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Packer/filler'),
(8192, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Supplier'),
(128, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Manufacturer'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'e-trader'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Hospitality/Food service'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Farmer'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Exporter'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'e-platform/e-market place'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Consignor'),
(64, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Importer');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[FBOTypes]'))
    SET IDENTITY_INSERT [FBOTypes] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[HazardGroups]'))
    SET IDENTITY_INSERT [HazardGroups] ON;
INSERT INTO [HazardGroups] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (18, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'natural toxins (other)'),
(19, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Non-compliance'),
(20, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'not determined / other'),
(21, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'novel food'),
(22, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'organoleptic aspects'),
(23, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'packaging defective / food contact material'),
(24, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'parasitic infestation'),
(25, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'pathogenic micro-organisms'),
(28, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'process contaminants'),
(27, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'poor or insufficient controls'),
(29, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Radiation'),
(30, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'residues of veterinary medicinal products'),
(31, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Supplements: Unauthorised substance'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TSEs'),
(33, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Unauthorised Pesticides'),
(34, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'unclassified'),
(35, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Use-by date exceeded'),
(26, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'pesticide residues');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[HazardGroups]'))
    SET IDENTITY_INSERT [HazardGroups] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[HazardGroups]'))
    SET IDENTITY_INSERT [HazardGroups] ON;
INSERT INTO [HazardGroups] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (17, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'mycotoxins'),
(14, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'labelling absent/incomplete/incorrect'),
(15, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'microbial contaminants (other)'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Adulteration'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'allergens'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'biological contaminants (other)'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'migration'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'composition'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'environmental pollutants'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'chemical contamination'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'food additives and flavourings'),
(9, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'foreign bodies'),
(10, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Fraud'),
(11, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'genetically modified food or feed'),
(12, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'heavy metals'),
(13, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'industrial contaminants'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'feed additives');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[HazardGroups]'))
    SET IDENTITY_INSERT [HazardGroups] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'SortOrder', N'Title') AND [object_id] = OBJECT_ID(N'[IncidentStatus]'))
    SET IDENTITY_INSERT [IncidentStatus] ON;
INSERT INTO [IncidentStatus] ([Id], [CreatedBy], [ModifiedBy], [SortOrder], [Title])
VALUES (4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 500, N'Unassigned'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 200, N'Open'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 100, N'Closed');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'SortOrder', N'Title') AND [object_id] = OBJECT_ID(N'[IncidentStatus]'))
    SET IDENTITY_INSERT [IncidentStatus] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[NotifierTypes]'))
    SET IDENTITY_INSERT [NotifierTypes] ON;
INSERT INTO [NotifierTypes] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Manufacturer'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Local Authority'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Public individual'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Retailer');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[NotifierTypes]'))
    SET IDENTITY_INSERT [NotifierTypes] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Priorities]'))
    SET IDENTITY_INSERT [Priorities] ON;
INSERT INTO [Priorities] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TBC'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'High'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Medium'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Low');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Priorities]'))
    SET IDENTITY_INSERT [Priorities] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ProductDateTypes]'))
    SET IDENTITY_INSERT [ProductDateTypes] ON;
INSERT INTO [ProductDateTypes] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Best before End'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Best before'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Use By Date'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Display Until');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ProductDateTypes]'))
    SET IDENTITY_INSERT [ProductDateTypes] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ProductTypes]'))
    SET IDENTITY_INSERT [ProductTypes] ON;
INSERT INTO [ProductTypes] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (21, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Gastropods'),
(22, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Herbs & Spices'),
(23, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Honey & Royal Jelly'),
(24, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ices & Desserts'),
(25, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Meat & Meat Products (other than poultry)'),
(26, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Milk & Milk Products'),
(27, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'N/A'),
(29, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Nuts / Nut Products / Seeds'),
(33, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Prepared Dishes & Snacks'),
(31, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Pet Food'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Poultry Meat & Poultry Meat Products'),
(20, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Fruits & Vegetables'),
(34, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Soups / Broths / Sauces & Condiments'),
(35, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Water'),
(36, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Wine'),
(37, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Unmapped SPT Signal Value'),
(30, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other Food Product / Mixed'),
(19, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Contact Materials'),
(28, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Non-Alcoholic Beverages'),
(17, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Fish & Fish Products'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Animal by-Products'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Alcoholic Beverages'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bivalve Molluscs & Products Thereof'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cephalopods & Products Thereof'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cereals & Bakery Products'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cocoa / Cocoa Preparations / Coffee / Tea'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Compound Feeds'),
(9, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Confectionery'),
(18, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Additives & Flavourings'),
(10, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Crustaceans & Products Thereof'),
(11, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Dietetic Foods / Food Supplements / Fortified Foods'),
(12, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Egg & Egg Products'),
(13, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Fats & Oils'),
(14, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Feed Additives'),
(15, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Feed Materials'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Feed Premixtures');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ProductTypes]'))
    SET IDENTITY_INSERT [ProductTypes] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'SortOrder', N'Title') AND [object_id] = OBJECT_ID(N'[SignalStatus]'))
    SET IDENTITY_INSERT [SignalStatus] ON;
INSERT INTO [SignalStatus] ([Id], [CreatedBy], [ModifiedBy], [SortOrder], [Title])
VALUES (4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 500, N'Closed : No Incident'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 400, N'Closed : Incident'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 300, N'Pending'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 100, N'Unassigned'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 200, N'Open');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'SortOrder', N'Title') AND [object_id] = OBJECT_ID(N'[SignalStatus]'))
    SET IDENTITY_INSERT [SignalStatus] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[StakeholderDiscriminatorDb]'))
    SET IDENTITY_INSERT [StakeholderDiscriminatorDb] ON;
INSERT INTO [StakeholderDiscriminatorDb] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Standards Agency (FSA)'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Local Authority'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other government department'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food/Feed Business Operator (FBO/FeBO)');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[StakeholderDiscriminatorDb]'))
    SET IDENTITY_INSERT [StakeholderDiscriminatorDb] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[StakeholderIncidentRoles]'))
    SET IDENTITY_INSERT [StakeholderIncidentRoles] ON;
INSERT INTO [StakeholderIncidentRoles] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (22, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Policy Lead - Other Government Department'),
(23, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Strategic Incident Oversight Group (SIOG)'),
(24, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Chair, SIOG'),
(25, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Strategic Advisior'),
(26, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Strategic Director'),
(27, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Dairy Inspector'),
(28, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Field Operations - FVC'),
(29, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Field Operations - FVL'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Poultry Hygiene Inspector'),
(31, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Meat Hygiene Inspector'),
(33, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Wine Inspector'),
(34, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Receipt & Management  (RAM) Lead'),
(35, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Stakeholder  Engagement  (SHE) Lead'),
(36, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Receipt & Management (RAM ) Officer'),
(37, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Stakeholder Engagement (SHE) Officer'),
(21, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Policy Lead - FSA'),
(30, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Business Assurance Auditors'),
(20, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Chair, IMCG'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Briefing Cell'),
(18, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Operational Incident Management Team (OIMT)'),
(19, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Management Co-ordination Group (IMCG)'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Briefing Cell Manager'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Situation Report (SITREP) Lead'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Q&A lead'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Official Note Taker'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Press Officer'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Legal Advisior'),
(9, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Admin Support'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Communications Lead'),
(11, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ministerial Submission Lead'),
(12, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSS/FSA Liason'),
(13, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Risk Manager'),
(14, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Risk Assesor'),
(15, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Manager'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Lead?'),
(17, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Support?'),
(10, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Policy/Science Lead');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[StakeholderIncidentRoles]'))
    SET IDENTITY_INSERT [StakeholderIncidentRoles] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[UnitQuantities]'))
    SET IDENTITY_INSERT [UnitQuantities] ON;
INSERT INTO [UnitQuantities] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (11, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Litres'),
(17, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ppm'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ppb'),
(15, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'nSv'),
(14, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'mSv'),
(13, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'mg/litre'),
(12, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'mg/kg'),
(10, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'kg'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Gallons'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bq/M3'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bq/M2'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bq/l'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bq/Kg'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'µSv'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'µg/kg'),
(18, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ppt'),
(9, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Grams'),
(19, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'tonnes');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[UnitQuantities]'))
    SET IDENTITY_INSERT [UnitQuantities] OFF;

GO

CREATE INDEX [IX_AddressContacts_AddressId] ON [AddressContacts] ([AddressId]);

GO

CREATE INDEX [IX_Addresses_ContactMethodId] ON [Addresses] ([ContactMethodId]);

GO

CREATE INDEX [IX_Addresses_CountryId] ON [Addresses] ([CountryId]);

GO

CREATE INDEX [IX_Countries_KeyField] ON [Countries] ([KeyField]);

GO

CREATE INDEX [IX_IncidentAttachments_IncidentId] ON [IncidentAttachments] ([IncidentId]);

GO

CREATE INDEX [IX_IncidentLinks_ToId] ON [IncidentLinks] ([ToId]);

GO

CREATE INDEX [IX_IncidentNotes_IncidentId] ON [IncidentNotes] ([IncidentId]);

GO

CREATE INDEX [IX_IncidentProductDates_DateTypeId] ON [IncidentProductDates] ([DateTypeId]);

GO

CREATE INDEX [IX_IncidentProductDates_IncidentId] ON [IncidentProductDates] ([IncidentId]);

GO

CREATE INDEX [IX_IncidentProductFbos_AddressId] ON [IncidentProductFbos] ([AddressId]);

GO

CREATE INDEX [IX_IncidentProductPackSizes_IncidentId] ON [IncidentProductPackSizes] ([IncidentId]);

GO

CREATE INDEX [IX_IncidentProductPackSizes_UnitId] ON [IncidentProductPackSizes] ([UnitId]);

GO

CREATE INDEX [IX_IncidentProducts_AmountUnitTypeId] ON [IncidentProducts] ([AmountUnitTypeId]);

GO

CREATE INDEX [IX_IncidentProducts_CountryOfOriginId] ON [IncidentProducts] ([CountryOfOriginId]);

GO

CREATE INDEX [IX_IncidentProducts_HostId] ON [IncidentProducts] ([HostId]);

GO

CREATE INDEX [IX_IncidentProducts_ProductTypeId] ON [IncidentProducts] ([ProductTypeId]);

GO

CREATE INDEX [IX_Incidents_AdminLeadId] ON [Incidents] ([AdminLeadId]);

GO

CREATE INDEX [IX_Incidents_ClassificationId] ON [Incidents] ([ClassificationId]);

GO

CREATE INDEX [IX_Incidents_ContactMethodId] ON [Incidents] ([ContactMethodId]);

GO

CREATE INDEX [IX_Incidents_DataSourceId] ON [Incidents] ([DataSourceId]);

GO

CREATE INDEX [IX_Incidents_DeathIllnessId] ON [Incidents] ([DeathIllnessId]);

GO

CREATE INDEX [IX_Incidents_IncidentStatusId] ON [Incidents] ([IncidentStatusId]);

GO

CREATE INDEX [IX_Incidents_IncidentTypeId] ON [Incidents] ([IncidentTypeId]);

GO

CREATE INDEX [IX_Incidents_LeadLocalAuthorityId] ON [Incidents] ([LeadLocalAuthorityId]);

GO

CREATE UNIQUE INDEX [IX_Incidents_MostUniqueId] ON [Incidents] ([MostUniqueId]);

GO

CREATE INDEX [IX_Incidents_NotifierId] ON [Incidents] ([NotifierId]);

GO

CREATE INDEX [IX_Incidents_PrincipalFBOId] ON [Incidents] ([PrincipalFBOId]);

GO

CREATE INDEX [IX_Incidents_PriorityId] ON [Incidents] ([PriorityId]);

GO

CREATE INDEX [IX_Incidents_ProductTypeId] ON [Incidents] ([ProductTypeId]);

GO

CREATE INDEX [IX_Incidents_SignalStatusId] ON [Incidents] ([SignalStatusId]);

GO

CREATE INDEX [IX_IncidentStakeholders_AddressId] ON [IncidentStakeholders] ([AddressId]);

GO

CREATE INDEX [IX_IncidentStakeholders_IncidentId] ON [IncidentStakeholders] ([IncidentId]);

GO

CREATE INDEX [IX_IncidentStakeholders_StakeholderDiscriminatorId] ON [IncidentStakeholders] ([StakeholderDiscriminatorId]);

GO

CREATE INDEX [IX_SignalAttachments_SignalId] ON [SignalAttachments] ([SignalId]);

GO

CREATE INDEX [IX_SignalClosedNoIncident_ReasonId] ON [SignalClosedNoIncident] ([ReasonId]);

GO

CREATE INDEX [IX_SignalClosedNoIncident_TeamId] ON [SignalClosedNoIncident] ([TeamId]);

GO

CREATE INDEX [IX_SignalIncidentLinks_IncidentId] ON [SignalIncidentLinks] ([IncidentId]);

GO

CREATE UNIQUE INDEX [IX_SignalIncidentLinks_SignalId] ON [SignalIncidentLinks] ([SignalId]);

GO

CREATE INDEX [IX_SignalLinks_ToId] ON [SignalLinks] ([ToId]);

GO

CREATE INDEX [IX_SignalNotes_SignalId] ON [SignalNotes] ([SignalId]);

GO

CREATE INDEX [IX_SignalProductDates_DateTypeId] ON [SignalProductDates] ([DateTypeId]);

GO

CREATE INDEX [IX_SignalProductDates_SignalId] ON [SignalProductDates] ([SignalId]);

GO

CREATE INDEX [IX_SignalProductFbos_AddressId] ON [SignalProductFbos] ([AddressId]);

GO

CREATE INDEX [IX_SignalProductPackSizes_SignalId] ON [SignalProductPackSizes] ([SignalId]);

GO

CREATE INDEX [IX_SignalProductPackSizes_UnitId] ON [SignalProductPackSizes] ([UnitId]);

GO

CREATE INDEX [IX_SignalProducts_AmountUnitTypeId] ON [SignalProducts] ([AmountUnitTypeId]);

GO

CREATE INDEX [IX_SignalProducts_CountryOfOriginId] ON [SignalProducts] ([CountryOfOriginId]);

GO

CREATE INDEX [IX_SignalProducts_HostId] ON [SignalProducts] ([HostId]);

GO

CREATE INDEX [IX_SignalProducts_ProductTypeId] ON [SignalProducts] ([ProductTypeId]);

GO

CREATE INDEX [IX_Signals_SignalStatusId] ON [Signals] ([SignalStatusId]);

GO

CREATE INDEX [IX_SignalStakeholders_AddressId] ON [SignalStakeholders] ([AddressId]);

GO

CREATE INDEX [IX_SignalStakeholders_SignalId] ON [SignalStakeholders] ([SignalId]);

GO

CREATE INDEX [IX_SignalStakeholders_StakeholderDiscriminatorId] ON [SignalStakeholders] ([StakeholderDiscriminatorId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200915111112_CloseNoIcnide', N'3.1.7');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'SortOrder', N'Title') AND [object_id] = OBJECT_ID(N'[SignalStatus]'))
    SET IDENTITY_INSERT [SignalStatus] ON;
INSERT INTO [SignalStatus] ([Id], [CreatedBy], [ModifiedBy], [SortOrder], [Title])
VALUES (6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 400, N'Closed : Referral (Offline)');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'SortOrder', N'Title') AND [object_id] = OBJECT_ID(N'[SignalStatus]'))
    SET IDENTITY_INSERT [SignalStatus] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200915174339_closeChecks', N'3.1.7');

GO

DELETE FROM [SignalStatus]
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


GO

DELETE FROM [SignalStatus]
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


GO

DELETE FROM [SignalStatus]
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


GO

UPDATE [SignalStatus] SET [SortOrder] = 300, [Title] = N'Pending'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'SortOrder', N'Title') AND [object_id] = OBJECT_ID(N'[SignalStatus]'))
    SET IDENTITY_INSERT [SignalStatus] ON;
INSERT INTO [SignalStatus] ([Id], [CreatedBy], [ModifiedBy], [SortOrder], [Title])
VALUES (50, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 400, N'Closed : Incident'),
(100, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 500, N'Closed : No Incident'),
(150, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 600, N'Closed : Referral (Offline)');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'SortOrder', N'Title') AND [object_id] = OBJECT_ID(N'[SignalStatus]'))
    SET IDENTITY_INSERT [SignalStatus] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200916074839_updateSignalCloseAgain', N'3.1.7');

GO

ALTER TABLE [Incidents] DROP CONSTRAINT [FK_Incidents_DeathIllnesss_DeathIllnessId];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Incidents]') AND [c].[name] = N'DeathIllnessId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Incidents] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Incidents] ALTER COLUMN [DeathIllnessId] int NULL;

GO

ALTER TABLE [Incidents] ADD CONSTRAINT [FK_Incidents_DeathIllnesss_DeathIllnessId] FOREIGN KEY ([DeathIllnessId]) REFERENCES [DeathIllnesss] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200916081105_deathOrGloryField', N'3.1.7');

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SignalClosedNoIncident]') AND [c].[name] = N'TeamId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [SignalClosedNoIncident] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [SignalClosedNoIncident] ALTER COLUMN [TeamId] int NULL;

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SignalClosedNoIncident]') AND [c].[name] = N'ReasonId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [SignalClosedNoIncident] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [SignalClosedNoIncident] ALTER COLUMN [ReasonId] int NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200917092523_packageCloseSignal', N'3.1.7');

GO

DELETE FROM [ClosedSignalReasons]
WHERE [Id] = 7;
SELECT @@ROWCOUNT;


GO

DELETE FROM [ClosedSignalReasons]
WHERE [Id] = 8;
SELECT @@ROWCOUNT;


GO

DELETE FROM [ClosedSignalReasons]
WHERE [Id] = 9;
SELECT @@ROWCOUNT;


GO

DELETE FROM [ClosedSignalReasons]
WHERE [Id] = 10;
SELECT @@ROWCOUNT;


GO

DELETE FROM [ClosedSignalReasons]
WHERE [Id] = 11;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'Food Policy Lead'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'Imported Foods'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'Food Industry Liason Group (FILG)'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'Comms'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'Referred to LA/PA for Information Only'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'Incident Team'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200917093310_puchClose', N'3.1.7');

GO

DELETE FROM [ClosedSignalReasons]
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'No UK distribution'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'Duplicate Signal - Same Source'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'Duplicate Signal - Different Source'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'RASFF - No UK Distribution'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalReasons] SET [Title] = N'Not Enough Information for  Follow-Up'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalTeams] SET [Title] = N'National Food Crime Unit (NFCU)'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


GO

UPDATE [ClosedSignalTeams] SET [Title] = N'Food Policy lead'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalTeams]'))
    SET IDENTITY_INSERT [ClosedSignalTeams] ON;
INSERT INTO [ClosedSignalTeams] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Industry Liasion Group (FILG)'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Comms'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Referred to LA/PA for Information only'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Team');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalTeams]'))
    SET IDENTITY_INSERT [ClosedSignalTeams] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200917120857_packageCloseSignalRedit', N'3.1.7');

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Signals]') AND [c].[name] = N'Priority');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Signals] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Signals] ALTER COLUMN [Priority] nvarchar(4) NULL;

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Signals]') AND [c].[name] = N'HazardGroup');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Signals] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Signals] ALTER COLUMN [HazardGroup] nvarchar(100) NULL;

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Signals]') AND [c].[name] = N'Hazard');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Signals] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Signals] ALTER COLUMN [Hazard] nvarchar(255) NULL;

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Signals]') AND [c].[name] = N'FoodOrFeed');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Signals] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Signals] ALTER COLUMN [FoodOrFeed] nvarchar(25) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200923081610_stumpyPriority', N'3.1.7');

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Signals]') AND [c].[name] = N'Priority');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Signals] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Signals] ALTER COLUMN [Priority] nvarchar(10) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200923082941_GildaBurp', N'3.1.7');

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Signals]') AND [c].[name] = N'NotifyingCountry');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Signals] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Signals] ALTER COLUMN [NotifyingCountry] nvarchar(255) NULL;

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Signals]') AND [c].[name] = N'LeadOfficer');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Signals] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Signals] ALTER COLUMN [LeadOfficer] nvarchar(36) NULL;

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Signals]') AND [c].[name] = N'CountryOfOrigin');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Signals] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [Signals] ALTER COLUMN [CountryOfOrigin] nvarchar(255) NULL;

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Incidents]') AND [c].[name] = N'SignalUrl');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Incidents] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [Incidents] ALTER COLUMN [SignalUrl] nvarchar(600) NULL;

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Incidents]') AND [c].[name] = N'LeadOfficer');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Incidents] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [Incidents] ALTER COLUMN [LeadOfficer] nvarchar(36) NULL;

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Incidents]') AND [c].[name] = N'IncidentTitle');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Incidents] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [Incidents] ALTER COLUMN [IncidentTitle] nvarchar(250) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200924082925_LOfficerUpdates', N'3.1.7');

GO

CREATE TABLE [UserAccessLog] (
    [Id] int NOT NULL IDENTITY,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    [UserId] nvarchar(70) NOT NULL,
    [Scope] nvarchar(70) NOT NULL,
    [Page] nvarchar(max) NULL,
    [ScopeId] int NOT NULL,
    CONSTRAINT [PK_UserAccessLog] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200925124002_Audito', N'3.1.7');

GO

ALTER TABLE [IncidentStakeholders] DROP CONSTRAINT [FK_IncidentStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId];

GO

ALTER TABLE [SignalStakeholders] DROP CONSTRAINT [FK_SignalStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId];

GO

ALTER TABLE [StakeholderDiscriminatorDb] DROP CONSTRAINT [PK_StakeholderDiscriminatorDb];

GO

EXEC sp_rename N'[StakeholderDiscriminatorDb]', N'StakeholderDiscriminators';

GO

ALTER TABLE [StakeholderDiscriminators] ADD CONSTRAINT [PK_StakeholderDiscriminators] PRIMARY KEY ([Id]);

GO

ALTER TABLE [IncidentStakeholders] ADD CONSTRAINT [FK_IncidentStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId] FOREIGN KEY ([StakeholderDiscriminatorId]) REFERENCES [StakeholderDiscriminators] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [SignalStakeholders] ADD CONSTRAINT [FK_SignalStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId] FOREIGN KEY ([StakeholderDiscriminatorId]) REFERENCES [StakeholderDiscriminators] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201001110949_discriminators', N'3.1.7');

GO

ALTER TABLE [Signals] ADD [SensitiveInfo] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

ALTER TABLE [Incidents] ADD [SensitiveInfo] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201009135441_sensitiveWidoes', N'3.1.7');

GO

ALTER TABLE [SignalClosedNoIncident] DROP CONSTRAINT [FK_SignalClosedNoIncident_ClosedSignalTeams_TeamId];

GO

DROP INDEX [IX_SignalClosedNoIncident_TeamId] ON [SignalClosedNoIncident];

GO

DELETE FROM [ClosedSignalTeams]
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


GO

DELETE FROM [ClosedSignalTeams]
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


GO

DELETE FROM [ClosedSignalTeams]
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


GO

DELETE FROM [ClosedSignalTeams]
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


GO

DELETE FROM [ClosedSignalTeams]
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


GO

DELETE FROM [ClosedSignalTeams]
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


GO

DELETE FROM [ClosedSignalTeams]
WHERE [Id] = 7;
SELECT @@ROWCOUNT;


GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SignalClosedNoIncident]') AND [c].[name] = N'TeamId');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [SignalClosedNoIncident] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [SignalClosedNoIncident] DROP COLUMN [TeamId];

GO

ALTER TABLE [SignalClosedNoIncident] ADD [TeamIds] int NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201013085544_newPiece', N'3.1.7');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalTeams]'))
    SET IDENTITY_INSERT [ClosedSignalTeams] ON;
INSERT INTO [ClosedSignalTeams] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Food Crime Unit (NFCU)'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Policy lead'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Imported foods'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Industry Liasion Group (FILG)'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Comms'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Referred to LA/PA for Information only'),
(64, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Team');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalTeams]'))
    SET IDENTITY_INSERT [ClosedSignalTeams] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201013085642_seedCloseTeams', N'3.1.7');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[AdminLeads]'))
    SET IDENTITY_INSERT [AdminLeads] ON;
INSERT INTO [AdminLeads] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[AdminLeads]'))
    SET IDENTITY_INSERT [AdminLeads] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Classifications]'))
    SET IDENTITY_INSERT [Classifications] ON;
INSERT INTO [Classifications] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Classifications]'))
    SET IDENTITY_INSERT [Classifications] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalTeams]'))
    SET IDENTITY_INSERT [ClosedSignalTeams] ON;
INSERT INTO [ClosedSignalTeams] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (128, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other Government Department'),
(256, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalTeams]'))
    SET IDENTITY_INSERT [ClosedSignalTeams] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ContactMethods]'))
    SET IDENTITY_INSERT [ContactMethods] ON;
INSERT INTO [ContactMethods] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ContactMethods]'))
    SET IDENTITY_INSERT [ContactMethods] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'KeyField', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries] ([Id], [CreatedBy], [KeyField], [ModifiedBy], [Title])
VALUES (315, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'KeyField', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DataSources]'))
    SET IDENTITY_INSERT [DataSources] ON;
INSERT INTO [DataSources] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (58, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DataSources]'))
    SET IDENTITY_INSERT [DataSources] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DeathIllnesss]'))
    SET IDENTITY_INSERT [DeathIllnesss] ON;
INSERT INTO [DeathIllnesss] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DeathIllnesss]'))
    SET IDENTITY_INSERT [DeathIllnesss] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[HazardGroups]'))
    SET IDENTITY_INSERT [HazardGroups] ON;
INSERT INTO [HazardGroups] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (36, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[HazardGroups]'))
    SET IDENTITY_INSERT [HazardGroups] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[NotifierTypes]'))
    SET IDENTITY_INSERT [NotifierTypes] ON;
INSERT INTO [NotifierTypes] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[NotifierTypes]'))
    SET IDENTITY_INSERT [NotifierTypes] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Priorities]'))
    SET IDENTITY_INSERT [Priorities] ON;
INSERT INTO [Priorities] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Priorities]'))
    SET IDENTITY_INSERT [Priorities] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ProductDateTypes]'))
    SET IDENTITY_INSERT [ProductDateTypes] ON;
INSERT INTO [ProductDateTypes] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ProductDateTypes]'))
    SET IDENTITY_INSERT [ProductDateTypes] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[StakeholderDiscriminators]'))
    SET IDENTITY_INSERT [StakeholderDiscriminators] ON;
INSERT INTO [StakeholderDiscriminators] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food/Feed Business Operator (FBO/FeBO)');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[StakeholderDiscriminators]'))
    SET IDENTITY_INSERT [StakeholderDiscriminators] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[StakeholderIncidentRoles]'))
    SET IDENTITY_INSERT [StakeholderIncidentRoles] ON;
INSERT INTO [StakeholderIncidentRoles] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (38, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[StakeholderIncidentRoles]'))
    SET IDENTITY_INSERT [StakeholderIncidentRoles] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201013141112_updatedClookups', N'3.1.7');

GO

