using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class CloseNoIcnide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminLeads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminLeads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClosedSignalReasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClosedSignalReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClosedSignalTeams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClosedSignalTeams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    KeyField = table.Column<string>(maxLength: 56, nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataSources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeathIllnesss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeathIllnesss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FBOTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBOTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HazardGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncidentStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotifierTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifierTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDateTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDateTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SignalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StakeholderDiscriminatorDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StakeholderDiscriminatorDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StakeholderIncidentRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StakeholderIncidentRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitQuantities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitQuantities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    TownCity = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    ContactMethodId = table.Column<int>(nullable: false),
                    Uprn = table.Column<long>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_ContactMethods_ContactMethodId",
                        column: x => x.ContactMethodId,
                        principalTable: "ContactMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Signals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SPTId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(maxLength: 500, nullable: true),
                    SignalStatusId = table.Column<int>(nullable: false),
                    Priority = table.Column<string>(nullable: true),
                    LeadOfficer = table.Column<string>(nullable: true),
                    AlertType = table.Column<string>(nullable: true),
                    CountryOfOrigin = table.Column<string>(maxLength: 500, nullable: true),
                    NotifyingCountry = table.Column<string>(maxLength: 500, nullable: true),
                    IsEu = table.Column<bool>(nullable: false),
                    FoodOrFeed = table.Column<string>(maxLength: 500, nullable: true),
                    BaseProduct = table.Column<string>(maxLength: 500, nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Hazard = table.Column<string>(nullable: true),
                    HazardGroup = table.Column<string>(nullable: true),
                    DataSource = table.Column<string>(nullable: false),
                    SourceType = table.Column<string>(nullable: true),
                    PublishedDate = table.Column<DateTime>(nullable: false),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    SourceLink = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signals_SignalStatus_SignalStatusId",
                        column: x => x.SignalStatusId,
                        principalTable: "SignalStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AddressContacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressContacts_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MostUniqueId = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    IncidentTitle = table.Column<string>(nullable: true),
                    IncidentTypeId = table.Column<int>(nullable: false),
                    ContactMethodId = table.Column<int>(nullable: false),
                    SignalStatusId = table.Column<int>(nullable: true),
                    SignalUrl = table.Column<string>(nullable: true),
                    IncidentStatusId = table.Column<int>(nullable: false, defaultValue: 4),
                    NotifierId = table.Column<int>(nullable: true),
                    PrincipalFBOId = table.Column<int>(nullable: true),
                    PriorityId = table.Column<int>(nullable: false, defaultValue: 1),
                    ClassificationId = table.Column<int>(nullable: false),
                    DataSourceId = table.Column<int>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    AdminLeadId = table.Column<int>(nullable: true),
                    LeadOfficer = table.Column<string>(nullable: true),
                    LeadOffice = table.Column<string>(nullable: true),
                    FieldOfficer = table.Column<string>(nullable: true),
                    LeadLocalAuthorityId = table.Column<int>(nullable: true),
                    LAAdvised = table.Column<bool>(nullable: false),
                    DeathIllnessId = table.Column<int>(nullable: false),
                    ReceivedOn = table.Column<DateTime>(nullable: true),
                    IncidentCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    IncidentClosed = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidents_AdminLeads_AdminLeadId",
                        column: x => x.AdminLeadId,
                        principalTable: "AdminLeads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Classifications_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "Classifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_ContactMethods_ContactMethodId",
                        column: x => x.ContactMethodId,
                        principalTable: "ContactMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_DataSources_DataSourceId",
                        column: x => x.DataSourceId,
                        principalTable: "DataSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_DeathIllnesss_DeathIllnessId",
                        column: x => x.DeathIllnessId,
                        principalTable: "DeathIllnesss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_IncidentStatus_IncidentStatusId",
                        column: x => x.IncidentStatusId,
                        principalTable: "IncidentStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_HazardGroups_IncidentTypeId",
                        column: x => x.IncidentTypeId,
                        principalTable: "HazardGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Addresses_LeadLocalAuthorityId",
                        column: x => x.LeadLocalAuthorityId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Addresses_NotifierId",
                        column: x => x.NotifierId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Addresses_PrincipalFBOId",
                        column: x => x.PrincipalFBOId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Priorities_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_SignalStatus_SignalStatusId",
                        column: x => x.SignalStatusId,
                        principalTable: "SignalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SignalAttachments",
                columns: table => new
                {
                    DocUrl = table.Column<string>(nullable: false),
                    SignalId = table.Column<int>(nullable: false),
                    TagFlags = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalAttachments", x => x.DocUrl);
                    table.ForeignKey(
                        name: "FK_SignalAttachments_Signals_SignalId",
                        column: x => x.SignalId,
                        principalTable: "Signals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SignalClosedNoIncident",
                columns: table => new
                {
                    SignalId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    ReasonId = table.Column<int>(nullable: false),
                    UserReason = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalClosedNoIncident", x => x.SignalId);
                    table.ForeignKey(
                        name: "FK_SignalClosedNoIncident_ClosedSignalReasons_ReasonId",
                        column: x => x.ReasonId,
                        principalTable: "ClosedSignalReasons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignalClosedNoIncident_Signals_SignalId",
                        column: x => x.SignalId,
                        principalTable: "Signals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignalClosedNoIncident_ClosedSignalTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "ClosedSignalTeams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SignalLinks",
                columns: table => new
                {
                    FromId = table.Column<int>(nullable: false),
                    ToId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalLinks", x => new { x.FromId, x.ToId });
                    table.ForeignKey(
                        name: "FK_SignalLinks_Signals_FromId",
                        column: x => x.FromId,
                        principalTable: "Signals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignalLinks_Signals_ToId",
                        column: x => x.ToId,
                        principalTable: "Signals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SignalNotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(nullable: false),
                    SignalId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignalNotes_Signals_SignalId",
                        column: x => x.SignalId,
                        principalTable: "Signals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignalProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    CountryOfOriginId = table.Column<int>(nullable: false),
                    Amount = table.Column<string>(nullable: true, defaultValue: "0.00"),
                    AmountUnitTypeId = table.Column<int>(nullable: false),
                    BatchCodes = table.Column<string>(nullable: true),
                    PackDescription = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignalProducts_UnitQuantities_AmountUnitTypeId",
                        column: x => x.AmountUnitTypeId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignalProducts_Countries_CountryOfOriginId",
                        column: x => x.CountryOfOriginId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignalProducts_Signals_HostId",
                        column: x => x.HostId,
                        principalTable: "Signals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignalProducts_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SignalStakeholders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SignalId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GovDept = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StakeholderDiscriminatorId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalStakeholders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignalStakeholders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SignalStakeholders_Signals_SignalId",
                        column: x => x.SignalId,
                        principalTable: "Signals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignalStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId",
                        column: x => x.StakeholderDiscriminatorId,
                        principalTable: "StakeholderDiscriminatorDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncidentAttachments",
                columns: table => new
                {
                    DocUrl = table.Column<string>(nullable: false),
                    IncidentId = table.Column<int>(nullable: false),
                    TagFlags = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentAttachments", x => x.DocUrl);
                    table.ForeignKey(
                        name: "FK_IncidentAttachments_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IncidentLinks",
                columns: table => new
                {
                    FromId = table.Column<int>(nullable: false),
                    ToId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentLinks", x => new { x.FromId, x.ToId });
                    table.ForeignKey(
                        name: "FK_IncidentLinks_Incidents_FromId",
                        column: x => x.FromId,
                        principalTable: "Incidents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncidentLinks_Incidents_ToId",
                        column: x => x.ToId,
                        principalTable: "Incidents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IncidentNotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(nullable: false),
                    IncidentId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentNotes_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncidentProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    CountryOfOriginId = table.Column<int>(nullable: false),
                    Amount = table.Column<string>(nullable: true, defaultValue: "0.00"),
                    AmountUnitTypeId = table.Column<int>(nullable: false),
                    BatchCodes = table.Column<string>(nullable: true),
                    PackDescription = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentProducts_UnitQuantities_AmountUnitTypeId",
                        column: x => x.AmountUnitTypeId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncidentProducts_Countries_CountryOfOriginId",
                        column: x => x.CountryOfOriginId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncidentProducts_Incidents_HostId",
                        column: x => x.HostId,
                        principalTable: "Incidents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncidentProducts_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IncidentStakeholders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GovDept = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StakeholderDiscriminatorId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentStakeholders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentStakeholders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncidentStakeholders_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncidentStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId",
                        column: x => x.StakeholderDiscriminatorId,
                        principalTable: "StakeholderDiscriminatorDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignalIncidentLinks",
                columns: table => new
                {
                    SignalId = table.Column<int>(nullable: false),
                    IncidentId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalIncidentLinks", x => new { x.SignalId, x.IncidentId });
                    table.ForeignKey(
                        name: "FK_SignalIncidentLinks_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignalIncidentLinks_Signals_SignalId",
                        column: x => x.SignalId,
                        principalTable: "Signals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignalProductDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SignalId = table.Column<int>(nullable: false),
                    DateTypeId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalProductDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignalProductDates_ProductDateTypes_DateTypeId",
                        column: x => x.DateTypeId,
                        principalTable: "ProductDateTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignalProductDates_SignalProducts_SignalId",
                        column: x => x.SignalId,
                        principalTable: "SignalProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignalProductFbos",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    FboTypes = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalProductFbos", x => new { x.ProductId, x.AddressId });
                    table.ForeignKey(
                        name: "FK_SignalProductFbos_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignalProductFbos_SignalProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "SignalProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SignalProductPackSizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    SignalId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalProductPackSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignalProductPackSizes_SignalProducts_SignalId",
                        column: x => x.SignalId,
                        principalTable: "SignalProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignalProductPackSizes_UnitQuantities_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncidentProductDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentId = table.Column<int>(nullable: false),
                    DateTypeId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentProductDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentProductDates_ProductDateTypes_DateTypeId",
                        column: x => x.DateTypeId,
                        principalTable: "ProductDateTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncidentProductDates_IncidentProducts_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "IncidentProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncidentProductFbos",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    FboTypes = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentProductFbos", x => new { x.ProductId, x.AddressId });
                    table.ForeignKey(
                        name: "FK_IncidentProductFbos_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncidentProductFbos_IncidentProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "IncidentProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IncidentProductPackSizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    IncidentId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentProductPackSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentProductPackSizes_IncidentProducts_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "IncidentProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncidentProductPackSizes_UnitQuantities_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdminLeads",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incidents Branch London" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incidents Branch Northern Ireland" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incidents Branch Wales" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incidents Food Standards Scotland" }
                });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Routine" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Non-Routine" }
                });

            migrationBuilder.InsertData(
                table: "ClosedSignalReasons",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UK Govt. Quarterly Report" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UK RASFF" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Research on MySupermarket, Amazon and Google negative for distribution to the UK" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RASFF notification" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "No useful information" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FDA alert re US border rejection" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Japanese Import alert" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UK Recall" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Duplicate of..." },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Czech Republic sampling" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "No UK distribution" }
                });

            migrationBuilder.InsertData(
                table: "ClosedSignalTeams",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Relevant Policy lead" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Imported foods" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NFCU" }
                });

            migrationBuilder.InsertData(
                table: "ContactMethods",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Email" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Telephone" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "No Preference" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedBy", "KeyField", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 215, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nepal" },
                    { 214, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Norway" },
                    { 213, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Netherlands" },
                    { 212, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nicaragua" },
                    { 211, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nigeria" },
                    { 210, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Norfolk Island" },
                    { 209, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Niger" },
                    { 208, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "New Caledonia" },
                    { 206, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mozambique" },
                    { 205, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Malaysia" },
                    { 204, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MX", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mexico" },
                    { 203, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Malawi" },
                    { 202, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Maldives" },
                    { 201, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mauritius" },
                    { 200, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Malta" },
                    { 207, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Namibia" },
                    { 216, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nauru" },
                    { 228, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pitcairn, Henderson, Ducie and Oeno Islands" },
                    { 218, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "New Zealand" },
                    { 234, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "QA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Qatar" },
                    { 233, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Paraguay" },
                    { 232, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Palau" },
                    { 231, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Portugal" },
                    { 230, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Occupied Palestinian Territories" },
                    { 229, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Puerto Rico" },
                    { 199, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Montserrat" },
                    { 217, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Niue" },
                    { 227, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saint Pierre and Miquelon" },
                    { 225, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pakistan" },
                    { 224, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Philippines" },
                    { 223, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Papua New Guinea" },
                    { 222, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "French Polynesia" },
                    { 221, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Peru" },
                    { 220, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Panama" },
                    { 219, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "OM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Oman" },
                    { 226, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "PL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Poland" },
                    { 198, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mauritania" },
                    { 186, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Moldova" },
                    { 196, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Northern Mariana Islands" },
                    { 175, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "St Lucia" },
                    { 174, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LB", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Lebanon" },
                    { 173, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Laos" },
                    { 172, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kazakhstan" },
                    { 171, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cayman Islands" },
                    { 170, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kuwait" },
                    { 169, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "South Korea" },
                    { 176, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Liechtenstein" },
                    { 168, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "North Korea" },
                    { 166, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Comoros" },
                    { 165, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kiribati" },
                    { 164, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cambodia" },
                    { 163, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kyrgyzstan" },
                    { 162, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kenya" },
                    { 161, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "JP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Japan" },
                    { 160, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "JO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Jordan" },
                    { 167, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "KN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "St Kitts and Nevis" },
                    { 197, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Martinique" },
                    { 177, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sri Lanka" },
                    { 179, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Lesotho" },
                    { 195, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Macao" },
                    { 194, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mongolia" },
                    { 193, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Burma" },
                    { 192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ML", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mali" },
                    { 191, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Macedonia" },
                    { 190, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Marshall Islands" },
                    { 189, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Madagascar" },
                    { 178, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Liberia" },
                    { 188, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saint-Martin (French part)" },
                    { 235, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Reunion" },
                    { 185, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Monaco" },
                    { 184, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "MA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Morocco" },
                    { 183, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Libya" },
                    { 182, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Latvia" },
                    { 181, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Luxembourg" },
                    { 180, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "LT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Lithuania" },
                    { 187, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ME", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Montenegro" },
                    { 236, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Romania" },
                    { 247, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SH-HL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saint Helena" },
                    { 238, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Russia" },
                    { 294, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "St Vincent" },
                    { 293, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Vatican City" },
                    { 292, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Uzbekistan" },
                    { 291, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Uruguay" },
                    { 290, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "US", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "United States" },
                    { 289, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-95", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Palmyra Atoll" },
                    { 288, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-89", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kingman Reef" },
                    { 287, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-86", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Jarvis Island" },
                    { 286, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-84", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Howland Island" },
                    { 285, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-81", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Baker Island" },
                    { 284, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-79", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wake Island" },
                    { 283, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-76", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Navassa Island" },
                    { 282, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-71", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Midway Islands" },
                    { 281, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UM-67", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Johnston Atoll" },
                    { 280, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Uganda" },
                    { 295, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Venezuela" },
                    { 296, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "British Virgin Islands" },
                    { 297, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "United States Virgin Islands" },
                    { 298, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Vietnam" },
                    { 314, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "territory", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Territory" },
                    { 313, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "other", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" },
                    { 312, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "not-easily-identified", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Not Easily Identified" },
                    { 311, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "non-EU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "non-EU" },
                    { 310, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "country", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Country" },
                    { 309, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ZW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Zimbabwe" },
                    { 308, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ZM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Zambia" },
                    { 279, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ukraine" },
                    { 307, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ZA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "South Africa" },
                    { 305, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "YE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Yemen" },
                    { 304, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "XXD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dhekelia" },
                    { 303, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "XQZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Akrotiri" },
                    { 302, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "XK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Kosovo" },
                    { 301, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "WS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Samoa" },
                    { 300, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "WF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wallis and Futuna" },
                    { 299, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "VU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Vanuatu" },
                    { 306, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "YT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Mayotte" },
                    { 278, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tanzania" },
                    { 277, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Taiwan" },
                    { 276, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tuvalu" },
                    { 254, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Senegal" },
                    { 253, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "San Marino" },
                    { 252, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sierra Leone" },
                    { 251, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Slovakia" },
                    { 250, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Svalbard and Jan Mayen" },
                    { 249, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Slovenia" },
                    { 248, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SH-TA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tristan da Cunha" },
                    { 255, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Somalia" },
                    { 159, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "JM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Jamaica" },
                    { 245, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Singapore" },
                    { 244, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sweden" },
                    { 243, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sudan" },
                    { 242, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Seychelles" },
                    { 241, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SB", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Solomon Islands" },
                    { 240, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saudi Arabia" },
                    { 239, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Rwanda" },
                    { 246, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SH-AC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ascension" },
                    { 237, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Serbia" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Suriname" },
                    { 258, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ST", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sao Tome and Principe" },
                    { 275, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Trinidad and Tobago" },
                    { 274, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Turkey" },
                    { 273, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tonga" },
                    { 272, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tunisia" },
                    { 271, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Turkmenistan" },
                    { 270, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "East Timor" },
                    { 269, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tokelau" },
                    { 257, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "South Sudan" },
                    { 268, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Tajikistan" },
                    { 265, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "French Southern Territories" },
                    { 264, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chad" },
                    { 263, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Turks and Caicos Islands" },
                    { 262, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Swaziland" },
                    { 261, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Syria" },
                    { 260, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SX", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sint Maarten (Dutch part)" },
                    { 259, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "El Salvador" },
                    { 266, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Togo" },
                    { 158, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "JE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Jersey" },
                    { 267, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Thailand" },
                    { 156, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Iceland" },
                    { 54, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bosnia and Herzegovina" },
                    { 53, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Azerbaijan" },
                    { 52, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AX", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Aland Islands" },
                    { 51, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Aruba" },
                    { 50, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Australia" },
                    { 49, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Austria" },
                    { 48, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "American Samoa" },
                    { 47, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Argentina" },
                    { 46, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Antarctica" },
                    { 45, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Angola" },
                    { 44, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Armenia" },
                    { 43, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Albania" },
                    { 42, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Anguilla" },
                    { 41, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Antigua and Barbuda" },
                    { 40, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Afghanistan" },
                    { 55, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BAT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "British Antarctic Territory" },
                    { 56, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BB", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Barbados" },
                    { 57, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bangladesh" },
                    { 58, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Belgium" },
                    { 75, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Botswana" },
                    { 74, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bouvet Island" },
                    { 73, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bhutan" },
                    { 72, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "The Bahamas" },
                    { 71, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Brazil" },
                    { 70, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BQ-SE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sint Eustatius" },
                    { 69, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BQ-SA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saba" },
                    { 39, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-UQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Umm al-Quwain" },
                    { 68, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BQ-BO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bonaire" },
                    { 66, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Brunei" },
                    { 65, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bermuda" },
                    { 63, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Benin" },
                    { 62, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Burundi" },
                    { 61, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bahrain" },
                    { 60, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bulgaria" },
                    { 59, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Burkina Faso" },
                    { 67, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bolivia" },
                    { 38, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-SH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Sharjah" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-RK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ras al-Khaimah" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-FU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fujairah" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guinea-Bissau" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guam" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guatemala" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "South Georgia and South Sandwich Islands" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Greece" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Equatorial Guinea" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guadeloupe" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guyana" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guinea" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Greenland" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gibraltar" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ghana" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guernsey" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "French Guiana" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Georgia" },
                    { 157, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Italy" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "The Gambia" },
                    { 76, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Belarus" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hong Kong" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Honduras" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-DU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dubai" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-AZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Abu Dhabi" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE-AJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ajman" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "United Arab Emirates" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "AD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Andorra" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Iran" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Iraq" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Heard Island and McDonald Islands" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "British Indian Ocean Territory" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Isle of Man" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Israel" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ireland" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ID", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Indonesia" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hungary" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Haiti" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Croatia" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "India" },
                    { 77, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Belize" },
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "BL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Saint Barthelemy" },
                    { 79, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cocos (Keeling) Islands" },
                    { 134, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GP", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guadeloupe" },
                    { 133, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guinea" },
                    { 132, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "The Gambia" },
                    { 131, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Greenland" },
                    { 130, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gibraltar" },
                    { 78, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Canada" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guernsey" },
                    { 135, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Equatorial Guinea" },
                    { 127, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "French Guiana" },
                    { 125, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Grenada" },
                    { 124, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GB-WLS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wales" },
                    { 123, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GB-SCT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Scotland" },
                    { 122, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GB-NIR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Northern Ireland" },
                    { 121, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GB-ENG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "England" },
                    { 120, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GB", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "United Kingdom" },
                    { 119, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GA", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gabon" },
                    { 126, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Georgia" },
                    { 136, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Greece" },
                    { 137, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GS", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "South Georgia and South Sandwich Islands" },
                    { 138, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guatemala" },
                    { 155, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Iran" },
                    { 154, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IQ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Iraq" },
                    { 153, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "British Indian Ocean Territory" },
                    { 152, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "India" },
                    { 151, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Isle of Man" },
                    { 150, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Israel" },
                    { 149, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "IE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ireland" },
                    { 148, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ID", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Indonesia" },
                    { 147, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hungary" },
                    { 146, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HT", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Haiti" },
                    { 145, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Croatia" },
                    { 144, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Honduras" },
                    { 143, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Heard Island and McDonald Islands" },
                    { 142, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "HK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hong Kong" },
                    { 141, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guyana" },
                    { 140, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guinea-Bissau" },
                    { 139, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Guam" },
                    { 118, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "France" },
                    { 117, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Faroe Islands" },
                    { 129, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "GH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ghana" },
                    { 115, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Falkland Islands" },
                    { 95, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CY", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cyprus" },
                    { 94, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CX", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Christmas Island" },
                    { 93, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CW", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Curacao" },
                    { 92, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CV", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cape Verde" },
                    { 91, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cuba" },
                    { 90, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CR", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Costa Rica" },
                    { 89, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Colombia" },
                    { 96, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Czechia" },
                    { 88, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CN", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "China" },
                    { 86, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CL", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chile" },
                    { 116, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Micronesia" },
                    { 84, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ivory Coast" },
                    { 83, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Switzerland" },
                    { 82, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Congo" },
                    { 81, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CF", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Central African Republic" },
                    { 80, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CD", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Congo (Democratic Republic)" },
                    { 87, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cameroon" },
                    { 97, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Germany" },
                    { 85, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cook Islands" },
                    { 99, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DK", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Denmark" },
                    { 98, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Djibouti" },
                    { 113, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FI", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Finland" },
                    { 112, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EU", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "European Union" },
                    { 110, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ES-ML", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Melilla" },
                    { 109, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ES-CE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ceuta" },
                    { 108, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ES", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Spain" },
                    { 107, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ER", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Eritrea" },
                    { 111, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ET", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ethiopia" },
                    { 105, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EG", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Egypt" },
                    { 100, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DM", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dominica" },
                    { 106, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EH", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Western Sahara" },
                    { 101, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DO", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dominican Republic" },
                    { 102, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "DZ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Algeria" },
                    { 114, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FJ", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fiji" },
                    { 103, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EC", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ecuador" },
                    { 104, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EE", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Estonia" }
                });

            migrationBuilder.InsertData(
                table: "DataSources",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health Protection Scotland (HPS)" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Industry" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Local Authority" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Marine Management Organisation (MMO)" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Maritime & Costguard Agency (MCA)" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health & Safety Executive" },
                    { 38, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Medicines & Healthcare products Regulatory Agency (MHRA)" },
                    { 39, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Met Office" },
                    { 40, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Crime Agency (NCA)" },
                    { 41, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU)" },
                    { 42, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU) - NFCU INTEL Report" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "INFOSAN" },
                    { 51, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RASFF" },
                    { 45, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nuclear Power Station" },
                    { 46, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" },
                    { 47, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Police" },
                    { 48, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Port Health Authority (PHA)" },
                    { 49, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public Analyst / Laboratory" },
                    { 50, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public Health England (PHE)" },
                    { 52, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SAC (Scottish Agricultural College)" },
                    { 53, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SOCA" },
                    { 54, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Third Country" },
                    { 55, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Water Company" },
                    { 56, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Veterinary Medicines Directorate" },
                    { 57, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Unmapped SPT Signal Value" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health Protection Agency (HPA)" },
                    { 44, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Health Service (NHS)" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Home Office / Border Force" },
                    { 43, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU) - DIM Referral" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Unannounced Inspector" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "General Public" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Web Form" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Administrative Assistance & Cooperation System (AAC)" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Border Inspection Posts (BIPs)" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Department of Agriculture & Rural Development (DARD)" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Department of Health (DH)" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Department for Environment Food & Rural Affairs (Defra)" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Environment Agency (EA)" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "EU Member States" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "European Commission (EC)" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fire Services" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Standards Scotland (FSS)" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Business Assurance Auditors" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Animal & Plant Health Agency (APHA)" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA England" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Dairy Inspector" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Wine Inspector" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Survey" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA RAM Referral" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Poultry Hygiene Inspector" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Wales (FSAW)" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Northern Ireland (FSANI)" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Meat Hygiene Inspector" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Field Operations - FVC" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Field Operations - FVL" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Policy" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Operations Group" }
                });

            migrationBuilder.InsertData(
                table: "DeathIllnesss",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Vomiting" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Diarrhoea" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Abdominal Pain" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTags",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Picture" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public warning / Press release" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Recipients List" },
                    { 1024, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Screenshot" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Phytosanitary Certifcate" },
                    { 2048, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Translation" },
                    { 512, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk assessment" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health certifiacte" },
                    { 8192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bill / Delivery Document" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Analytical report" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CVED/CED" },
                    { 4096, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Video File" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Follow up notification" }
                });

            migrationBuilder.InsertData(
                table: "FBOTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 2048, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Retailer" },
                    { 1024, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Producer" },
                    { 512, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Processor" },
                    { 4096, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Storage" },
                    { 65536, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wholesaler" },
                    { 16384, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Trader/Broker" },
                    { 32768, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Transporter" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Packer/filler" },
                    { 8192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Supplier" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Manufacturer" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "e-trader" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hospitality/Food service" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Farmer" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Exporter" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "e-platform/e-market place" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Consignor" },
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Importer" }
                });

            migrationBuilder.InsertData(
                table: "HazardGroups",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "natural toxins (other)" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Non-compliance" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "not determined / other" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "novel food" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "organoleptic aspects" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "packaging defective / food contact material" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "parasitic infestation" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "pathogenic micro-organisms" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "process contaminants" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "poor or insufficient controls" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Radiation" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "residues of veterinary medicinal products" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Supplements: Unauthorised substance" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TSEs" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Unauthorised Pesticides" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "unclassified" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Use-by date exceeded" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "pesticide residues" }
                });

            migrationBuilder.InsertData(
                table: "HazardGroups",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "mycotoxins" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "labelling absent/incomplete/incorrect" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "microbial contaminants (other)" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Adulteration" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "allergens" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "biological contaminants (other)" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "migration" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "composition" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "environmental pollutants" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "chemical contamination" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "food additives and flavourings" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "foreign bodies" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fraud" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "genetically modified food or feed" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "heavy metals" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "industrial contaminants" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "feed additives" }
                });

            migrationBuilder.InsertData(
                table: "IncidentStatus",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 500, "Unassigned" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 200, "Open" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 100, "Closed" }
                });

            migrationBuilder.InsertData(
                table: "NotifierTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Manufacturer" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Local Authority" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public individual" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Retailer" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TBC" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "High" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Medium" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Low" }
                });

            migrationBuilder.InsertData(
                table: "ProductDateTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Best before End" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Best before" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Use By Date" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Display Until" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gastropods" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Herbs & Spices" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Honey & Royal Jelly" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ices & Desserts" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Meat & Meat Products (other than poultry)" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Milk & Milk Products" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "N/A" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nuts / Nut Products / Seeds" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Prepared Dishes & Snacks" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pet Food" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Poultry Meat & Poultry Meat Products" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fruits & Vegetables" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Soups / Broths / Sauces & Condiments" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Water" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wine" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Unmapped SPT Signal Value" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other Food Product / Mixed" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Contact Materials" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Non-Alcoholic Beverages" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fish & Fish Products" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Animal by-Products" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Alcoholic Beverages" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bivalve Molluscs & Products Thereof" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cephalopods & Products Thereof" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cereals & Bakery Products" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cocoa / Cocoa Preparations / Coffee / Tea" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Compound Feeds" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Confectionery" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Additives & Flavourings" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Crustaceans & Products Thereof" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dietetic Foods / Food Supplements / Fortified Foods" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Egg & Egg Products" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fats & Oils" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Feed Additives" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Feed Materials" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Feed Premixtures" }
                });

            migrationBuilder.InsertData(
                table: "SignalStatus",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 500, "Closed : No Incident" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 400, "Closed : Incident" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 300, "Pending" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 100, "Unassigned" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 200, "Open" }
                });

            migrationBuilder.InsertData(
                table: "StakeholderDiscriminatorDb",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Standards Agency (FSA)" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Local Authority" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other government department" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food/Feed Business Operator (FBO/FeBO)" }
                });

            migrationBuilder.InsertData(
                table: "StakeholderIncidentRoles",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy Lead - Other Government Department" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Strategic Incident Oversight Group (SIOG)" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chair, SIOG" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Strategic Advisior" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Strategic Director" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dairy Inspector" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Field Operations - FVC" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Field Operations - FVL" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Poultry Hygiene Inspector" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Meat Hygiene Inspector" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wine Inspector" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Receipt & Management  (RAM) Lead" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Stakeholder  Engagement  (SHE) Lead" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Receipt & Management (RAM ) Officer" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Stakeholder Engagement (SHE) Officer" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy Lead - FSA" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Business Assurance Auditors" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chair, IMCG" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Briefing Cell" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Operational Incident Management Team (OIMT)" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Management Co-ordination Group (IMCG)" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Briefing Cell Manager" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Situation Report (SITREP) Lead" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Q&A lead" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Official Note Taker" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Press Officer" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Legal Advisior" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Admin Support" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Communications Lead" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ministerial Submission Lead" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSS/FSA Liason" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk Manager" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk Assesor" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Manager" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Lead?" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Support?" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy/Science Lead" }
                });

            migrationBuilder.InsertData(
                table: "UnitQuantities",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Litres" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ppm" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ppb" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "nSv" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "mSv" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "mg/litre" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "mg/kg" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "kg" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gallons" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/M3" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/M2" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/l" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/Kg" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "µSv" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "µg/kg" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ppt" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Grams" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "tonnes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressContacts_AddressId",
                table: "AddressContacts",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ContactMethodId",
                table: "Addresses",
                column: "ContactMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_KeyField",
                table: "Countries",
                column: "KeyField");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentAttachments_IncidentId",
                table: "IncidentAttachments",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentLinks_ToId",
                table: "IncidentLinks",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentNotes_IncidentId",
                table: "IncidentNotes",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductDates_DateTypeId",
                table: "IncidentProductDates",
                column: "DateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductDates_IncidentId",
                table: "IncidentProductDates",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductFbos_AddressId",
                table: "IncidentProductFbos",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductPackSizes_IncidentId",
                table: "IncidentProductPackSizes",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductPackSizes_UnitId",
                table: "IncidentProductPackSizes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProducts_AmountUnitTypeId",
                table: "IncidentProducts",
                column: "AmountUnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProducts_CountryOfOriginId",
                table: "IncidentProducts",
                column: "CountryOfOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProducts_HostId",
                table: "IncidentProducts",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProducts_ProductTypeId",
                table: "IncidentProducts",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_AdminLeadId",
                table: "Incidents",
                column: "AdminLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ClassificationId",
                table: "Incidents",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ContactMethodId",
                table: "Incidents",
                column: "ContactMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_DataSourceId",
                table: "Incidents",
                column: "DataSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_DeathIllnessId",
                table: "Incidents",
                column: "DeathIllnessId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_IncidentStatusId",
                table: "Incidents",
                column: "IncidentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_IncidentTypeId",
                table: "Incidents",
                column: "IncidentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_LeadLocalAuthorityId",
                table: "Incidents",
                column: "LeadLocalAuthorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_MostUniqueId",
                table: "Incidents",
                column: "MostUniqueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_NotifierId",
                table: "Incidents",
                column: "NotifierId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_PrincipalFBOId",
                table: "Incidents",
                column: "PrincipalFBOId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_PriorityId",
                table: "Incidents",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ProductTypeId",
                table: "Incidents",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_SignalStatusId",
                table: "Incidents",
                column: "SignalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentStakeholders_AddressId",
                table: "IncidentStakeholders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentStakeholders_IncidentId",
                table: "IncidentStakeholders",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentStakeholders_StakeholderDiscriminatorId",
                table: "IncidentStakeholders",
                column: "StakeholderDiscriminatorId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalAttachments_SignalId",
                table: "SignalAttachments",
                column: "SignalId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalClosedNoIncident_ReasonId",
                table: "SignalClosedNoIncident",
                column: "ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalClosedNoIncident_TeamId",
                table: "SignalClosedNoIncident",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalIncidentLinks_IncidentId",
                table: "SignalIncidentLinks",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalIncidentLinks_SignalId",
                table: "SignalIncidentLinks",
                column: "SignalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SignalLinks_ToId",
                table: "SignalLinks",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalNotes_SignalId",
                table: "SignalNotes",
                column: "SignalId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductDates_DateTypeId",
                table: "SignalProductDates",
                column: "DateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductDates_SignalId",
                table: "SignalProductDates",
                column: "SignalId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductFbos_AddressId",
                table: "SignalProductFbos",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductPackSizes_SignalId",
                table: "SignalProductPackSizes",
                column: "SignalId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductPackSizes_UnitId",
                table: "SignalProductPackSizes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProducts_AmountUnitTypeId",
                table: "SignalProducts",
                column: "AmountUnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProducts_CountryOfOriginId",
                table: "SignalProducts",
                column: "CountryOfOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProducts_HostId",
                table: "SignalProducts",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProducts_ProductTypeId",
                table: "SignalProducts",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Signals_SignalStatusId",
                table: "Signals",
                column: "SignalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalStakeholders_AddressId",
                table: "SignalStakeholders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalStakeholders_SignalId",
                table: "SignalStakeholders",
                column: "SignalId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalStakeholders_StakeholderDiscriminatorId",
                table: "SignalStakeholders",
                column: "StakeholderDiscriminatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressContacts");

            migrationBuilder.DropTable(
                name: "DocumentTags");

            migrationBuilder.DropTable(
                name: "FBOTypes");

            migrationBuilder.DropTable(
                name: "IncidentAttachments");

            migrationBuilder.DropTable(
                name: "IncidentLinks");

            migrationBuilder.DropTable(
                name: "IncidentNotes");

            migrationBuilder.DropTable(
                name: "IncidentProductDates");

            migrationBuilder.DropTable(
                name: "IncidentProductFbos");

            migrationBuilder.DropTable(
                name: "IncidentProductPackSizes");

            migrationBuilder.DropTable(
                name: "IncidentStakeholders");

            migrationBuilder.DropTable(
                name: "NotifierTypes");

            migrationBuilder.DropTable(
                name: "SignalAttachments");

            migrationBuilder.DropTable(
                name: "SignalClosedNoIncident");

            migrationBuilder.DropTable(
                name: "SignalIncidentLinks");

            migrationBuilder.DropTable(
                name: "SignalLinks");

            migrationBuilder.DropTable(
                name: "SignalNotes");

            migrationBuilder.DropTable(
                name: "SignalProductDates");

            migrationBuilder.DropTable(
                name: "SignalProductFbos");

            migrationBuilder.DropTable(
                name: "SignalProductPackSizes");

            migrationBuilder.DropTable(
                name: "SignalStakeholders");

            migrationBuilder.DropTable(
                name: "StakeholderIncidentRoles");

            migrationBuilder.DropTable(
                name: "IncidentProducts");

            migrationBuilder.DropTable(
                name: "ClosedSignalReasons");

            migrationBuilder.DropTable(
                name: "ClosedSignalTeams");

            migrationBuilder.DropTable(
                name: "ProductDateTypes");

            migrationBuilder.DropTable(
                name: "SignalProducts");

            migrationBuilder.DropTable(
                name: "StakeholderDiscriminatorDb");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "UnitQuantities");

            migrationBuilder.DropTable(
                name: "Signals");

            migrationBuilder.DropTable(
                name: "AdminLeads");

            migrationBuilder.DropTable(
                name: "Classifications");

            migrationBuilder.DropTable(
                name: "DataSources");

            migrationBuilder.DropTable(
                name: "DeathIllnesss");

            migrationBuilder.DropTable(
                name: "IncidentStatus");

            migrationBuilder.DropTable(
                name: "HazardGroups");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "SignalStatus");

            migrationBuilder.DropTable(
                name: "ContactMethods");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
