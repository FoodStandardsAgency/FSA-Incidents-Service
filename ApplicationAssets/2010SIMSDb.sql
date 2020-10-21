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
    [KeyField] nvarchar(128) NOT NULL,
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

CREATE TABLE [StakeholderDiscriminators] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_StakeholderDiscriminators] PRIMARY KEY ([Id])
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

CREATE TABLE [UserAccessLog] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(70) NOT NULL,
    [Scope] nvarchar(70) NOT NULL,
    [Page] nvarchar(max) NULL,
    [ScopeId] int NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_UserAccessLog] PRIMARY KEY ([Id])
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
    [Priority] nvarchar(10) NULL,
    [LeadOfficer] nvarchar(36) NULL,
    [AlertType] nvarchar(max) NULL,
    [CountryOfOrigin] nvarchar(255) NULL,
    [NotifyingCountry] nvarchar(255) NULL,
    [IsEu] bit NOT NULL,
    [FoodOrFeed] nvarchar(25) NULL,
    [BaseProduct] nvarchar(500) NULL,
    [Manufacturer] nvarchar(max) NULL,
    [Hazard] nvarchar(255) NULL,
    [HazardGroup] nvarchar(100) NULL,
    [DataSource] nvarchar(max) NOT NULL,
    [SourceType] nvarchar(max) NULL,
    [PublishedDate] datetime2 NOT NULL,
    [InsertedDate] datetime2 NOT NULL,
    [SourceLink] nvarchar(max) NULL,
    [SensitiveInfo] bit NOT NULL,
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
    [IncidentTitle] nvarchar(250) NULL,
    [IncidentTypeId] int NOT NULL,
    [ContactMethodId] int NOT NULL,
    [SignalStatusId] int NULL,
    [SignalUrl] nvarchar(600) NULL,
    [IncidentStatusId] int NOT NULL DEFAULT 4,
    [NotifierId] int NULL,
    [PrincipalFBOId] int NULL,
    [PriorityId] int NOT NULL DEFAULT 1,
    [ClassificationId] int NOT NULL,
    [DataSourceId] int NOT NULL,
    [ProductTypeId] int NOT NULL,
    [AdminLeadId] int NULL,
    [LeadOfficer] nvarchar(36) NULL,
    [LeadOffice] nvarchar(max) NULL,
    [FieldOfficer] nvarchar(max) NULL,
    [LeadLocalAuthorityId] int NULL,
    [LAAdvised] bit NOT NULL,
    [DeathIllnessId] int NULL,
    [ReceivedOn] datetime2 NULL,
    [IncidentCreated] datetime2 NOT NULL DEFAULT (getutcdate()),
    [IncidentClosed] datetime2 NULL,
    [SensitiveInfo] bit NOT NULL,
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
    CONSTRAINT [FK_Incidents_DeathIllnesss_DeathIllnessId] FOREIGN KEY ([DeathIllnessId]) REFERENCES [DeathIllnesss] ([Id]) ON DELETE NO ACTION,
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
    [TeamIds] int NULL,
    [ReasonId] int NULL,
    [UserReason] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(70) NOT NULL,
    [Modified] datetime2 NOT NULL DEFAULT (getutcdate()),
    [CreatedBy] nvarchar(70) NOT NULL,
    [Created] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_SignalClosedNoIncident] PRIMARY KEY ([SignalId]),
    CONSTRAINT [FK_SignalClosedNoIncident_ClosedSignalReasons_ReasonId] FOREIGN KEY ([ReasonId]) REFERENCES [ClosedSignalReasons] ([Id]),
    CONSTRAINT [FK_SignalClosedNoIncident_Signals_SignalId] FOREIGN KEY ([SignalId]) REFERENCES [Signals] ([Id]) ON DELETE CASCADE
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
    CONSTRAINT [FK_SignalStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId] FOREIGN KEY ([StakeholderDiscriminatorId]) REFERENCES [StakeholderDiscriminators] ([Id]) ON DELETE CASCADE
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
    CONSTRAINT [FK_IncidentStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId] FOREIGN KEY ([StakeholderDiscriminatorId]) REFERENCES [StakeholderDiscriminators] ([Id]) ON DELETE CASCADE
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
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incidents Food Standards Scotland'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[AdminLeads]'))
    SET IDENTITY_INSERT [AdminLeads] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Classifications]'))
    SET IDENTITY_INSERT [Classifications] ON;
INSERT INTO [Classifications] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Routine'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Non-Routine'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Classifications]'))
    SET IDENTITY_INSERT [Classifications] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalReasons]'))
    SET IDENTITY_INSERT [ClosedSignalReasons] ON;
INSERT INTO [ClosedSignalReasons] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Not Enough Information for  Follow-Up'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'RASFF - No UK Distribution'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'No UK distribution'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Duplicate Signal - Same Source'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Duplicate Signal - Different Source');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalReasons]'))
    SET IDENTITY_INSERT [ClosedSignalReasons] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalTeams]'))
    SET IDENTITY_INSERT [ClosedSignalTeams] ON;
INSERT INTO [ClosedSignalTeams] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Referred to LA/PA for Information only'),
(256, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other'),
(64, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Team'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Comms'),
(128, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other Government Department'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Imported foods'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Policy lead'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Food Crime Unit (NFCU)'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Industry Liasion Group (FILG)');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ClosedSignalTeams]'))
    SET IDENTITY_INSERT [ClosedSignalTeams] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ContactMethods]'))
    SET IDENTITY_INSERT [ContactMethods] ON;
INSERT INTO [ContactMethods] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Email'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Telephone'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'No Preference'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ContactMethods]'))
    SET IDENTITY_INSERT [ContactMethods] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'KeyField', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] ON;
INSERT INTO [Countries] ([Id], [CreatedBy], [KeyField], [ModifiedBy], [Title])
VALUES (193, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/PG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Papua New Guinea'),
(192, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/PF', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'French Polynesia'),
(191, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/PE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Peru'),
(190, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/PA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Panama'),
(189, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/OM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Oman'),
(188, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/NZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'New Zealand'),
(184, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/NO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Norway'),
(186, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/NR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Nauru'),
(185, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/NP', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Nepal'),
(183, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/NL', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Netherlands'),
(182, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/NI', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Nicaragua'),
(181, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/NG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Nigeria'),
(194, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/PH', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Philippines'),
(187, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/NU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Niue'),
(195, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/PK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Pakistan'),
(208, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/RU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Russia'),
(197, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/PM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Saint Pierre and Miquelon'),
(211, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SB', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Solomon Islands'),
(210, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Saudi Arabia'),
(209, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/RW', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Rwanda'),
(180, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/NF', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Norfolk Island'),
(207, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/RS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Serbia'),
(206, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/RO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Romania'),
(196, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/PL', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Poland'),
(205, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/RE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Reunion'),
(203, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/PY', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Paraguay'),
(202, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/PW', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Palau'),
(201, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/PT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Portugal'),
(200, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/PS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Occupied Palestinian Territories'),
(199, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/PR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Puerto Rico'),
(198, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/PN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Pitcairn, Henderson, Ducie and Oeno Islands'),
(204, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/QA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Qatar'),
(179, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/NE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Niger'),
(166, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/MP', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Northern Mariana Islands'),
(177, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/NA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Namibia'),
(158, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/MF', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Saint-Martin (French part)'),
(157, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/ME', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Montenegro'),
(156, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MD', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Moldova'),
(155, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MC', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Monaco'),
(154, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Morocco'),
(153, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LY', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Libya'),
(159, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Madagascar'),
(152, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LV', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Latvia'),
(150, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Lithuania'),
(149, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Lesotho'),
(148, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Liberia'),
(147, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Sri Lanka'),
(146, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LI', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Liechtenstein'),
(145, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LC', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'St Lucia'),
(151, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Luxembourg'),
(178, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/NC', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'New Caledonia'),
(160, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MH', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Marshall Islands'),
(162, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/ML', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Mali'),
(176, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Mozambique'),
(175, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MY', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Malaysia'),
(174, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MX', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Mexico'),
(173, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MW', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Malawi'),
(172, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MV', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Maldives'),
(171, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Mauritius'),
(161, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Macedonia'),
(170, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Malta'),
(168, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Mauritania'),
(167, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/MQ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Martinique'),
(212, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SC', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Seychelles'),
(165, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/MO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Macao'),
(164, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Mongolia'),
(163, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/MM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Burma'),
(169, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/MS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Montserrat'),
(213, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SD', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Sudan'),
(226, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Suriname'),
(215, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Singapore'),
(266, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/VG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'British Virgin Islands'),
(265, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/VE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Venezuela'),
(264, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/VC', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'St Vincent'),
(263, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/VA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Vatican City'),
(262, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/UZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Uzbekistan'),
(261, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/UY', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Uruguay'),
(267, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/VI', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'United States Virgin Islands'),
(260, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/US', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'United States'),
(258, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/UM-89', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Kingman Reef'),
(257, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/UM-86', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Jarvis Island'),
(255, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/UM-81', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Baker Island'),
(254, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/UM-79', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Wake Island'),
(253, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/UM-76', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Navassa Island'),
(252, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/UM-71', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Midway Islands'),
(259, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/UM-95', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Palmyra Atoll'),
(251, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/UM-67', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Johnston Atoll'),
(268, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/VN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Vietnam'),
(270, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/WF', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Wallis and Futuna'),
(284, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'http://data.food.gov.uk/codes/geographies/countries/territory', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Territory'),
(283, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'http://data.food.gov.uk/codes/geographies/countries/other', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Other'),
(282, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'http://data.food.gov.uk/codes/geographies/countries/not-easily-identified', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Not Easily Identified'),
(281, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'http://data.food.gov.uk/codes/geographies/countries/non-EU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'non-EU'),
(280, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'http://data.food.gov.uk/codes/geographies/countries/country', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Country'),
(279, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/ZW', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Zimbabwe'),
(269, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/VU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Vanuatu'),
(278, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/ZM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Zambia'),
(276, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/YT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Mayotte'),
(275, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/YE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Yemen'),
(274, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/XXD', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Dhekelia'),
(273, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/XQZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Akrotiri'),
(272, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/XK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Kosovo'),
(271, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/WS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Samoa'),
(277, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/ZA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'South Africa'),
(214, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Sweden'),
(250, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/UG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Uganda'),
(248, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Tanzania'),
(229, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SV', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'El Salvador'),
(228, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/ST', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Sao Tome and Principe'),
(227, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'South Sudan'),
(144, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LB', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Lebanon'),
(225, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Somalia'),
(224, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Senegal'),
(230, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/SX', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Sint Maarten (Dutch part)'),
(223, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'San Marino'),
(221, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Slovakia'),
(220, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/SJ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Svalbard and Jan Mayen'),
(219, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SI', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Slovenia'),
(218, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/SH-TA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Tristan da Cunha'),
(217, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/SH-HL', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Saint Helena'),
(216, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/SH-AC', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Ascension'),
(222, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SL', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Sierra Leone'),
(249, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/UA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Ukraine'),
(231, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SY', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Syria'),
(233, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/TC', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Turks and Caicos Islands'),
(247, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/TW', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Taiwan'),
(246, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TV', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Tuvalu'),
(245, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Trinidad and Tobago'),
(244, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Turkey'),
(243, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Tonga'),
(242, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Tunisia'),
(232, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/SZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Swaziland'),
(241, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Turkmenistan'),
(239, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/TK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Tokelau'),
(238, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TJ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Tajikistan'),
(237, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TH', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Thailand'),
(236, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Togo'),
(235, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/TF', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'French Southern Territories'),
(234, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TD', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Chad'),
(240, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/TL', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'East Timor'),
(143, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/LA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Laos'),
(256, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/UM-84', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Howland Island'),
(141, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/KY', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Cayman Islands'),
(49, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/CC', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Cocos (Keeling) Islands'),
(48, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Canada'),
(47, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Belize'),
(46, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BY', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Belarus'),
(45, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BW', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Botswana'),
(44, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/BV', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Bouvet Island'),
(50, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CD', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Congo (Democratic Republic)'),
(43, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Bhutan'),
(41, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Brazil'),
(40, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/BQ-SE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Sint Eustatius'),
(39, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/BQ-SA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Saba'),
(38, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/BQ-BO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Bonaire'),
(37, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Bolivia'),
(36, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Brunei'),
(42, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'The Bahamas'),
(35, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/BM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Bermuda'),
(51, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CF', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Central African Republic'),
(53, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CH', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Switzerland'),
(68, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/DJ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Djibouti'),
(67, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/DE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Germany'),
(66, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Czechia'),
(65, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CY', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Cyprus'),
(64, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/CX', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Christmas Island'),
(63, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/CW', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Curacao'),
(52, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Congo'),
(62, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CV', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Cape Verde'),
(60, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Costa Rica'),
(59, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Colombia'),
(58, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'China'),
(56, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CL', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Chile'),
(55, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/CK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Cook Islands'),
(54, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CI', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Ivory Coast'),
(61, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Cuba'),
(69, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/DK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Denmark'),
(34, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/BL', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Saint Barthelemy'),
(32, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BI', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Burundi'),
(13, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AL', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Albania'),
(12, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AI', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Anguilla'),
(11, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Antigua and Barbuda'),
(10, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AF', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Afghanistan'),
(9, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AE-UQ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Umm al-Quwain'),
(8, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AE-SH', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Sharjah'),
(14, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Armenia'),
(7, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AE-RK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Ras al-Khaimah'),
(5, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AE-DU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Dubai'),
(4, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AE-AZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Abu Dhabi'),
(3, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AE-AJ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Ajman'),
(2, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'United Arab Emirates'),
(1, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AD', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Andorra'),
(142, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/KZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Kazakhstan'),
(6, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AE-FU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Fujairah'),
(33, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BJ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Benin'),
(15, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Angola'),
(17, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Argentina'),
(31, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BH', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Bahrain'),
(30, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Bulgaria'),
(29, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BF', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Burkina Faso'),
(28, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Belgium'),
(27, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BD', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Bangladesh'),
(26, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BB', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Barbados'),
(16, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AQ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Antarctica'),
(25, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/BAT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'British Antarctic Territory'),
(23, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Azerbaijan'),
(22, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AX', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Aland Islands'),
(21, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AW', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Aruba'),
(20, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Australia'),
(19, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/AT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Austria'),
(18, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/AS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'American Samoa'),
(24, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/BA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Bosnia and Herzegovina'),
(70, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/DM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Dominica'),
(57, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/CM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Cameroon'),
(72, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/DZ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Algeria'),
(122, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/IN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'India'),
(121, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/IM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Isle of Man'),
(120, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/IL', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Israel'),
(119, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/IE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Ireland'),
(71, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/DO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Dominican Republic'),
(117, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/HU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Hungary'),
(123, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/IO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'British Indian Ocean Territory'),
(116, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/HT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Haiti'),
(114, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/HN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Honduras'),
(113, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/HM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Heard Island and McDonald Islands'),
(112, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/HK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Hong Kong'),
(111, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GY', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Guyana'),
(110, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GW', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Guinea-Bissau'),
(109, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/GU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Guam'),
(115, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/HR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Croatia'),
(108, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Guatemala'),
(124, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/IQ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Iraq'),
(126, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/IS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Iceland'),
(140, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/KW', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Kuwait'),
(139, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/KR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'South Korea'),
(138, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/KP', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'North Korea'),
(137, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/KN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'St Kitts and Nevis'),
(136, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/KM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Comoros'),
(135, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/KI', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Kiribati'),
(125, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/IR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Iran'),
(134, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/KH', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Cambodia'),
(132, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/KE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Kenya'),
(131, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/JP', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Japan'),
(130, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/JO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Jordan'),
(129, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/JM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Jamaica'),
(128, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/JE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Jersey'),
(127, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/IT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Italy'),
(133, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/KG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Kyrgyzstan'),
(107, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/GS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'South Georgia and South Sandwich Islands'),
(118, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/ID', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Indonesia'),
(105, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GQ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Equatorial Guinea'),
(86, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/FM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Micronesia'),
(85, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/FK', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Falkland Islands'),
(84, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/FJ', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Fiji'),
(83, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/FI', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Finland'),
(82, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'http://data.food.gov.uk/codes/geographies/countries/EU', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'European Union'),
(81, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/ET', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Ethiopia'),
(87, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/FO', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Faroe Islands'),
(80, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/ES-ML', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Melilla'),
(78, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/ES', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Spain'),
(106, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Greece'),
(76, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/EH', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Western Sahara'),
(75, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/EG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Egypt'),
(74, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/EE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Estonia'),
(73, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/EC', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Ecuador'),
(79, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/ES-CE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Ceuta'),
(88, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/FR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'France'),
(77, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/ER', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Eritrea'),
(90, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GB', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'United Kingdom'),
(89, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GA', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Gabon'),
(104, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/GP', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Guadeloupe'),
(103, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GN', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Guinea'),
(101, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/GL', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Greenland'),
(100, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/GI', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Gibraltar'),
(99, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GH', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Ghana'),
(98, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/GG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Guernsey'),
(102, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GM', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'The Gambia'),
(96, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GE', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Georgia'),
(95, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://country.register.gov.uk/record/GD', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Grenada'),
(94, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'http://data.food.gov.uk/codes/geographies/countries/GB-WLS', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Wales'),
(93, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'http://data.food.gov.uk/codes/geographies/countries/GB-SCT', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Scotland'),
(92, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'http://data.food.gov.uk/codes/geographies/countries/GB-NIR', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'Northern Ireland'),
(97, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'https://territory.register.gov.uk/record/GF', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'French Guiana'),
(91, N'5134b97e9d-eb28-444f-87cb-2c6311af8009', N'http://data.food.gov.uk/codes/geographies/countries/GB-ENG', N'34b97e9d-eb28-444f-87cb-2c6311af8009', N'England');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'KeyField', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Countries]'))
    SET IDENTITY_INSERT [Countries] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DataSources]'))
    SET IDENTITY_INSERT [DataSources] ON;
INSERT INTO [DataSources] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (42, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Food Crime Unit (NFCU) - NFCU INTEL Report'),
(41, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Food Crime Unit (NFCU)'),
(40, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Crime Agency (NCA)'),
(39, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Met Office'),
(38, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Medicines & Healthcare products Regulatory Agency (MHRA)'),
(35, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Local Authority'),
(36, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Marine Management Organisation (MMO)'),
(34, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'INFOSAN'),
(43, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Food Crime Unit (NFCU) - DIM Referral'),
(33, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Industry'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Health & Safety Executive'),
(37, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Maritime & Costguard Agency (MCA)'),
(44, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'National Health Service (NHS)'),
(52, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SAC (Scottish Agricultural College)'),
(46, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other'),
(47, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Police'),
(48, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Port Health Authority (PHA)'),
(49, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Public Analyst / Laboratory'),
(50, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Public Health England (PHE)'),
(51, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'RASFF'),
(53, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'SOCA'),
(54, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Third Country'),
(55, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Water Company'),
(57, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Unmapped SPT Signal Value'),
(58, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
(31, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Health Protection Scotland (HPS)'),
(45, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Nuclear Power Station'),
(30, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Health Protection Agency (HPA)'),
(56, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Veterinary Medicines Directorate'),
(28, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'General Public'),
(29, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Home Office / Border Force'),
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
(27, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Unannounced Inspector'),
(25, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Wales (FSAW)'),
(24, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Survey'),
(23, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA RAM Referral'),
(22, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Poultry Hygiene Inspector'),
(26, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Wine Inspector'),
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
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Abdominal Pain');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DeathIllnesss]'))
    SET IDENTITY_INSERT [DeathIllnesss] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DocumentTags]'))
    SET IDENTITY_INSERT [DocumentTags] ON;
INSERT INTO [DocumentTags] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Phytosanitary Certifcate'),
(128, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Public warning / Press release'),
(256, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Recipients List'),
(512, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Risk assessment'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Health certifiacte'),
(1024, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Screenshot'),
(64, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Picture'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Follow up notification'),
(4096, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Video File'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Analytical report'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'CVED/CED'),
(8192, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other'),
(2048, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Translation'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bill / Delivery Document');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[DocumentTags]'))
    SET IDENTITY_INSERT [DocumentTags] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[FBOTypes]'))
    SET IDENTITY_INSERT [FBOTypes] ON;
INSERT INTO [FBOTypes] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (1024, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Producer'),
(512, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Processor'),
(256, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Packer/filler'),
(2048, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Retailer'),
(65536, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Wholesaler'),
(8192, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Supplier'),
(16384, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Trader/Broker'),
(32768, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Transporter'),
(128, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Manufacturer'),
(4096, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Storage'),
(64, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Importer'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'e-platform/e-market place'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Farmer'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Exporter'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'e-trader'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Consignor'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Hospitality/Food service');
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
(26, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'pesticide residues'),
(28, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'process contaminants'),
(29, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Radiation'),
(30, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'residues of veterinary medicinal products'),
(31, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Supplements: Unauthorised substance'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TSEs'),
(33, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Unauthorised Pesticides'),
(34, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'unclassified'),
(35, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Use-by date exceeded'),
(36, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
(27, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'poor or insufficient controls'),
(17, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'mycotoxins'),
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
VALUES (5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Retailer'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Local Authority'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Public individual'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Manufacturer');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[NotifierTypes]'))
    SET IDENTITY_INSERT [NotifierTypes] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Priorities]'))
    SET IDENTITY_INSERT [Priorities] ON;
INSERT INTO [Priorities] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Low'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Medium'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'High'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'TBC');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Priorities]'))
    SET IDENTITY_INSERT [Priorities] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ProductDateTypes]'))
    SET IDENTITY_INSERT [ProductDateTypes] ON;
INSERT INTO [ProductDateTypes] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Display Until'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Use By Date'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Best before'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Best before End');
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
(28, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Non-Alcoholic Beverages'),
(29, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Nuts / Nut Products / Seeds'),
(30, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other Food Product / Mixed'),
(31, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Pet Food'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Poultry Meat & Poultry Meat Products'),
(20, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Fruits & Vegetables'),
(34, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Soups / Broths / Sauces & Condiments'),
(35, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Water'),
(36, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Wine'),
(37, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Unmapped SPT Signal Value'),
(33, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Prepared Dishes & Snacks'),
(18, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Additives & Flavourings'),
(17, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Fish & Fish Products'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Animal by-Products'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Alcoholic Beverages'),
(19, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Contact Materials'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cephalopods & Products Thereof'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cereals & Bakery Products'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Cocoa / Cocoa Preparations / Coffee / Tea'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Compound Feeds'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bivalve Molluscs & Products Thereof'),
(10, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Crustaceans & Products Thereof'),
(11, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Dietetic Foods / Food Supplements / Fortified Foods'),
(12, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Egg & Egg Products'),
(13, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Fats & Oils'),
(14, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Feed Additives'),
(15, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Feed Materials'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Feed Premixtures'),
(9, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Confectionery');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[ProductTypes]'))
    SET IDENTITY_INSERT [ProductTypes] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'SortOrder', N'Title') AND [object_id] = OBJECT_ID(N'[SignalStatus]'))
    SET IDENTITY_INSERT [SignalStatus] ON;
INSERT INTO [SignalStatus] ([Id], [CreatedBy], [ModifiedBy], [SortOrder], [Title])
VALUES (200, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 600, N'Closed : Linked Incident'),
(150, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 700, N'Closed : Referral (Offline)'),
(100, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 500, N'Closed : No Incident'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 100, N'Unassigned'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 300, N'Pending'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 200, N'Open'),
(50, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', 400, N'Closed : New Incident');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'SortOrder', N'Title') AND [object_id] = OBJECT_ID(N'[SignalStatus]'))
    SET IDENTITY_INSERT [SignalStatus] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[StakeholderDiscriminators]'))
    SET IDENTITY_INSERT [StakeholderDiscriminators] ON;
INSERT INTO [StakeholderDiscriminators] ([Id], [CreatedBy], [ModifiedBy], [Title])
VALUES (5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food/Feed Business Operator (FBO/FeBO)'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Other government department'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food/Feed Business Operator (FBO/FeBO)'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Food Standards Agency (FSA)'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Local Authority');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'ModifiedBy', N'Title') AND [object_id] = OBJECT_ID(N'[StakeholderDiscriminators]'))
    SET IDENTITY_INSERT [StakeholderDiscriminators] OFF;

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
(29, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Field Operations - FVL'),
(30, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSA Business Assurance Auditors'),
(31, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Meat Hygiene Inspector'),
(32, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Poultry Hygiene Inspector'),
(33, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Wine Inspector'),
(34, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Receipt & Management  (RAM) Lead'),
(35, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Stakeholder  Engagement  (SHE) Lead'),
(36, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Receipt & Management (RAM ) Officer'),
(37, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Stakeholder Engagement (SHE) Officer'),
(38, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
(21, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Policy Lead - FSA'),
(20, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Chair, IMCG'),
(28, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Field Operations - FVC'),
(18, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Operational Incident Management Team (OIMT)'),
(19, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Management Co-ordination Group (IMCG)'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Briefing Cell'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Briefing Cell Manager'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Situation Report (SITREP) Lead'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Q&A lead'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Communications Lead'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Press Officer'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Legal Advisior'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Official Note Taker'),
(10, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Policy/Science Lead'),
(9, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Admin Support'),
(16, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Lead?'),
(15, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Manager'),
(14, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Risk Assesor'),
(17, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Incident Support?'),
(12, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'FSS/FSA Liason'),
(11, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Ministerial Submission Lead'),
(13, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Risk Manager');
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
(18, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'ppt'),
(8, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Gallons'),
(7, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bq/M3'),
(6, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bq/M2'),
(5, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bq/l'),
(4, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Bq/Kg'),
(3, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'µSv'),
(2, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'µg/kg'),
(1, N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'51b75a03-4bb1-4e03-bd91-469fe7a1e6e9', N'Undefined'),
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
VALUES (N'20201019073957_initial', N'3.1.7');

GO

DELETE FROM [StakeholderDiscriminators]
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201020114520_seedIssues', N'3.1.7');

GO

