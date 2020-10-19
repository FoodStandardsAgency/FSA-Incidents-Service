using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class initial : Migration
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
                    KeyField = table.Column<string>(maxLength: 128, nullable: false),
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
                name: "StakeholderDiscriminators",
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
                    table.PrimaryKey("PK_StakeholderDiscriminators", x => x.Id);
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
                name: "UserAccessLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(maxLength: 70, nullable: false),
                    Scope = table.Column<string>(maxLength: 70, nullable: false),
                    Page = table.Column<string>(nullable: true),
                    ScopeId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccessLog", x => x.Id);
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
                    Priority = table.Column<string>(maxLength: 10, nullable: true),
                    LeadOfficer = table.Column<string>(maxLength: 36, nullable: true),
                    AlertType = table.Column<string>(nullable: true),
                    CountryOfOrigin = table.Column<string>(maxLength: 255, nullable: true),
                    NotifyingCountry = table.Column<string>(maxLength: 255, nullable: true),
                    IsEu = table.Column<bool>(nullable: false),
                    FoodOrFeed = table.Column<string>(maxLength: 25, nullable: true),
                    BaseProduct = table.Column<string>(maxLength: 500, nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Hazard = table.Column<string>(maxLength: 255, nullable: true),
                    HazardGroup = table.Column<string>(maxLength: 100, nullable: true),
                    DataSource = table.Column<string>(nullable: false),
                    SourceType = table.Column<string>(nullable: true),
                    PublishedDate = table.Column<DateTime>(nullable: false),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    SourceLink = table.Column<string>(nullable: true),
                    SensitiveInfo = table.Column<bool>(nullable: false),
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
                    IncidentTitle = table.Column<string>(maxLength: 250, nullable: true),
                    IncidentTypeId = table.Column<int>(nullable: false),
                    ContactMethodId = table.Column<int>(nullable: false),
                    SignalStatusId = table.Column<int>(nullable: true),
                    SignalUrl = table.Column<string>(maxLength: 600, nullable: true),
                    IncidentStatusId = table.Column<int>(nullable: false, defaultValue: 4),
                    NotifierId = table.Column<int>(nullable: true),
                    PrincipalFBOId = table.Column<int>(nullable: true),
                    PriorityId = table.Column<int>(nullable: false, defaultValue: 1),
                    ClassificationId = table.Column<int>(nullable: false),
                    DataSourceId = table.Column<int>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    AdminLeadId = table.Column<int>(nullable: true),
                    LeadOfficer = table.Column<string>(maxLength: 36, nullable: true),
                    LeadOffice = table.Column<string>(nullable: true),
                    FieldOfficer = table.Column<string>(nullable: true),
                    LeadLocalAuthorityId = table.Column<int>(nullable: true),
                    LAAdvised = table.Column<bool>(nullable: false),
                    DeathIllnessId = table.Column<int>(nullable: true),
                    ReceivedOn = table.Column<DateTime>(nullable: true),
                    IncidentCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    IncidentClosed = table.Column<DateTime>(nullable: true),
                    SensitiveInfo = table.Column<bool>(nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
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
                    TeamIds = table.Column<int>(nullable: true),
                    ReasonId = table.Column<int>(nullable: true),
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
                        name: "FK_SignalStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId",
                        column: x => x.StakeholderDiscriminatorId,
                        principalTable: "StakeholderDiscriminators",
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
                        name: "FK_IncidentStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId",
                        column: x => x.StakeholderDiscriminatorId,
                        principalTable: "StakeholderDiscriminators",
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
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incidents Food Standards Scotland" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" }
                });

            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Routine" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Non-Routine" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" }
                });

            migrationBuilder.InsertData(
                table: "ClosedSignalReasons",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Not Enough Information for  Follow-Up" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RASFF - No UK Distribution" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "No UK distribution" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Duplicate Signal - Same Source" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Duplicate Signal - Different Source" }
                });

            migrationBuilder.InsertData(
                table: "ClosedSignalTeams",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Referred to LA/PA for Information only" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" },
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Team" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Comms" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other Government Department" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Imported foods" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Policy lead" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU)" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Industry Liasion Group (FILG)" }
                });

            migrationBuilder.InsertData(
                table: "ContactMethods",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Email" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Telephone" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "No Preference" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedBy", "KeyField", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 193, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/PG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Papua New Guinea" },
                    { 192, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/PF", "34b97e9d-eb28-444f-87cb-2c6311af8009", "French Polynesia" },
                    { 191, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/PE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Peru" },
                    { 190, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/PA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Panama" },
                    { 189, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/OM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Oman" },
                    { 188, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/NZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "New Zealand" },
                    { 184, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/NO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Norway" },
                    { 186, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/NR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Nauru" },
                    { 185, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/NP", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Nepal" },
                    { 183, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/NL", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Netherlands" },
                    { 182, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/NI", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Nicaragua" },
                    { 181, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/NG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Nigeria" },
                    { 194, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/PH", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Philippines" },
                    { 187, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/NU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Niue" },
                    { 195, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/PK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Pakistan" },
                    { 208, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/RU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Russia" },
                    { 197, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/PM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Saint Pierre and Miquelon" },
                    { 211, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SB", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Solomon Islands" },
                    { 210, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Saudi Arabia" },
                    { 209, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/RW", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Rwanda" },
                    { 180, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/NF", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Norfolk Island" },
                    { 207, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/RS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Serbia" },
                    { 206, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/RO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Romania" },
                    { 196, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/PL", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Poland" },
                    { 205, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/RE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Reunion" },
                    { 203, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/PY", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Paraguay" },
                    { 202, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/PW", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Palau" },
                    { 201, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/PT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Portugal" },
                    { 200, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/PS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Occupied Palestinian Territories" },
                    { 199, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/PR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Puerto Rico" },
                    { 198, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/PN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Pitcairn, Henderson, Ducie and Oeno Islands" },
                    { 204, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/QA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Qatar" },
                    { 179, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/NE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Niger" },
                    { 166, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/MP", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Northern Mariana Islands" },
                    { 177, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/NA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Namibia" },
                    { 158, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/MF", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Saint-Martin (French part)" },
                    { 157, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/ME", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Montenegro" },
                    { 156, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MD", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Moldova" },
                    { 155, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MC", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Monaco" },
                    { 154, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Morocco" },
                    { 153, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LY", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Libya" },
                    { 159, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Madagascar" },
                    { 152, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LV", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Latvia" },
                    { 150, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Lithuania" },
                    { 149, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Lesotho" },
                    { 148, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Liberia" },
                    { 147, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Sri Lanka" },
                    { 146, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LI", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Liechtenstein" },
                    { 145, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LC", "34b97e9d-eb28-444f-87cb-2c6311af8009", "St Lucia" },
                    { 151, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Luxembourg" },
                    { 178, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/NC", "34b97e9d-eb28-444f-87cb-2c6311af8009", "New Caledonia" },
                    { 160, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MH", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Marshall Islands" },
                    { 162, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/ML", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Mali" },
                    { 176, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Mozambique" },
                    { 175, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MY", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Malaysia" },
                    { 174, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MX", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Mexico" },
                    { 173, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MW", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Malawi" },
                    { 172, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MV", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Maldives" },
                    { 171, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Mauritius" },
                    { 161, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Macedonia" },
                    { 170, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Malta" },
                    { 168, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Mauritania" },
                    { 167, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/MQ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Martinique" },
                    { 212, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SC", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Seychelles" },
                    { 165, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/MO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Macao" },
                    { 164, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Mongolia" },
                    { 163, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/MM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Burma" },
                    { 169, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/MS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Montserrat" },
                    { 213, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SD", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Sudan" },
                    { 226, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Suriname" },
                    { 215, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Singapore" },
                    { 266, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/VG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "British Virgin Islands" },
                    { 265, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/VE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Venezuela" },
                    { 264, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/VC", "34b97e9d-eb28-444f-87cb-2c6311af8009", "St Vincent" },
                    { 263, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/VA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Vatican City" },
                    { 262, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/UZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Uzbekistan" },
                    { 261, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/UY", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Uruguay" },
                    { 267, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/VI", "34b97e9d-eb28-444f-87cb-2c6311af8009", "United States Virgin Islands" },
                    { 260, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/US", "34b97e9d-eb28-444f-87cb-2c6311af8009", "United States" },
                    { 258, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/UM-89", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Kingman Reef" },
                    { 257, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/UM-86", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Jarvis Island" },
                    { 255, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/UM-81", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Baker Island" },
                    { 254, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/UM-79", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Wake Island" },
                    { 253, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/UM-76", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Navassa Island" },
                    { 252, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/UM-71", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Midway Islands" },
                    { 259, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/UM-95", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Palmyra Atoll" },
                    { 251, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/UM-67", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Johnston Atoll" },
                    { 268, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/VN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Vietnam" },
                    { 270, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/WF", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Wallis and Futuna" },
                    { 284, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "http://data.food.gov.uk/codes/geographies/countries/territory", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Territory" },
                    { 283, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "http://data.food.gov.uk/codes/geographies/countries/other", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Other" },
                    { 282, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "http://data.food.gov.uk/codes/geographies/countries/not-easily-identified", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Not Easily Identified" },
                    { 281, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "http://data.food.gov.uk/codes/geographies/countries/non-EU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "non-EU" },
                    { 280, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "http://data.food.gov.uk/codes/geographies/countries/country", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Country" },
                    { 279, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/ZW", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Zimbabwe" },
                    { 269, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/VU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Vanuatu" },
                    { 278, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/ZM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Zambia" },
                    { 276, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/YT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Mayotte" },
                    { 275, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/YE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Yemen" },
                    { 274, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/XXD", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Dhekelia" },
                    { 273, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/XQZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Akrotiri" },
                    { 272, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/XK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Kosovo" },
                    { 271, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/WS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Samoa" },
                    { 277, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/ZA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "South Africa" },
                    { 214, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Sweden" },
                    { 250, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/UG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Uganda" },
                    { 248, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Tanzania" },
                    { 229, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SV", "34b97e9d-eb28-444f-87cb-2c6311af8009", "El Salvador" },
                    { 228, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/ST", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Sao Tome and Principe" },
                    { 227, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "South Sudan" },
                    { 144, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LB", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Lebanon" },
                    { 225, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Somalia" },
                    { 224, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Senegal" },
                    { 230, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/SX", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Sint Maarten (Dutch part)" },
                    { 223, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "San Marino" },
                    { 221, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Slovakia" },
                    { 220, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/SJ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Svalbard and Jan Mayen" },
                    { 219, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SI", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Slovenia" },
                    { 218, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/SH-TA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Tristan da Cunha" },
                    { 217, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/SH-HL", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Saint Helena" },
                    { 216, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/SH-AC", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Ascension" },
                    { 222, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SL", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Sierra Leone" },
                    { 249, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/UA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Ukraine" },
                    { 231, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SY", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Syria" },
                    { 233, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/TC", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Turks and Caicos Islands" },
                    { 247, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/TW", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Taiwan" },
                    { 246, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TV", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Tuvalu" },
                    { 245, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Trinidad and Tobago" },
                    { 244, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Turkey" },
                    { 243, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Tonga" },
                    { 242, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Tunisia" },
                    { 232, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/SZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Swaziland" },
                    { 241, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Turkmenistan" },
                    { 239, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/TK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Tokelau" },
                    { 238, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TJ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Tajikistan" },
                    { 237, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TH", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Thailand" },
                    { 236, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Togo" },
                    { 235, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/TF", "34b97e9d-eb28-444f-87cb-2c6311af8009", "French Southern Territories" },
                    { 234, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TD", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Chad" },
                    { 240, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/TL", "34b97e9d-eb28-444f-87cb-2c6311af8009", "East Timor" },
                    { 143, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/LA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Laos" },
                    { 256, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/UM-84", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Howland Island" },
                    { 141, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/KY", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Cayman Islands" },
                    { 49, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/CC", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Cocos (Keeling) Islands" },
                    { 48, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Canada" },
                    { 47, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Belize" },
                    { 46, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BY", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Belarus" },
                    { 45, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BW", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Botswana" },
                    { 44, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/BV", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Bouvet Island" },
                    { 50, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CD", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Congo (Democratic Republic)" },
                    { 43, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Bhutan" },
                    { 41, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Brazil" },
                    { 40, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/BQ-SE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Sint Eustatius" },
                    { 39, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/BQ-SA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Saba" },
                    { 38, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/BQ-BO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Bonaire" },
                    { 37, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Bolivia" },
                    { 36, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Brunei" },
                    { 42, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "The Bahamas" },
                    { 35, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/BM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Bermuda" },
                    { 51, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CF", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Central African Republic" },
                    { 53, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CH", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Switzerland" },
                    { 68, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/DJ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Djibouti" },
                    { 67, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/DE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Germany" },
                    { 66, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Czechia" },
                    { 65, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CY", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Cyprus" },
                    { 64, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/CX", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Christmas Island" },
                    { 63, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/CW", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Curacao" },
                    { 52, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Congo" },
                    { 62, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CV", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Cape Verde" },
                    { 60, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Costa Rica" },
                    { 59, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Colombia" },
                    { 58, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "China" },
                    { 56, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CL", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Chile" },
                    { 55, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/CK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Cook Islands" },
                    { 54, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CI", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Ivory Coast" },
                    { 61, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Cuba" },
                    { 69, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/DK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Denmark" },
                    { 34, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/BL", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Saint Barthelemy" },
                    { 32, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BI", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Burundi" },
                    { 13, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AL", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Albania" },
                    { 12, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AI", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Anguilla" },
                    { 11, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Antigua and Barbuda" },
                    { 10, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AF", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Afghanistan" },
                    { 9, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AE-UQ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Umm al-Quwain" },
                    { 8, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AE-SH", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Sharjah" },
                    { 14, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Armenia" },
                    { 7, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AE-RK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Ras al-Khaimah" },
                    { 5, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AE-DU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Dubai" },
                    { 4, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AE-AZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Abu Dhabi" },
                    { 3, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AE-AJ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Ajman" },
                    { 2, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "United Arab Emirates" },
                    { 1, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AD", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Andorra" },
                    { 142, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/KZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Kazakhstan" },
                    { 6, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AE-FU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Fujairah" },
                    { 33, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BJ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Benin" },
                    { 15, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Angola" },
                    { 17, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Argentina" },
                    { 31, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BH", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Bahrain" },
                    { 30, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Bulgaria" },
                    { 29, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BF", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Burkina Faso" },
                    { 28, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Belgium" },
                    { 27, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BD", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Bangladesh" },
                    { 26, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BB", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Barbados" },
                    { 16, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AQ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Antarctica" },
                    { 25, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/BAT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "British Antarctic Territory" },
                    { 23, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Azerbaijan" },
                    { 22, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AX", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Aland Islands" },
                    { 21, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AW", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Aruba" },
                    { 20, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Australia" },
                    { 19, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/AT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Austria" },
                    { 18, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/AS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "American Samoa" },
                    { 24, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/BA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Bosnia and Herzegovina" },
                    { 70, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/DM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Dominica" },
                    { 57, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/CM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Cameroon" },
                    { 72, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/DZ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Algeria" },
                    { 122, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/IN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "India" },
                    { 121, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/IM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Isle of Man" },
                    { 120, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/IL", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Israel" },
                    { 119, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/IE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Ireland" },
                    { 71, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/DO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Dominican Republic" },
                    { 117, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/HU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Hungary" },
                    { 123, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/IO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "British Indian Ocean Territory" },
                    { 116, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/HT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Haiti" },
                    { 114, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/HN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Honduras" },
                    { 113, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/HM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Heard Island and McDonald Islands" },
                    { 112, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/HK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Hong Kong" },
                    { 111, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GY", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Guyana" },
                    { 110, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GW", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Guinea-Bissau" },
                    { 109, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/GU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Guam" },
                    { 115, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/HR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Croatia" },
                    { 108, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Guatemala" },
                    { 124, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/IQ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Iraq" },
                    { 126, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/IS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Iceland" },
                    { 140, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/KW", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Kuwait" },
                    { 139, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/KR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "South Korea" },
                    { 138, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/KP", "34b97e9d-eb28-444f-87cb-2c6311af8009", "North Korea" },
                    { 137, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/KN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "St Kitts and Nevis" },
                    { 136, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/KM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Comoros" },
                    { 135, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/KI", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Kiribati" },
                    { 125, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/IR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Iran" },
                    { 134, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/KH", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Cambodia" },
                    { 132, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/KE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Kenya" },
                    { 131, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/JP", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Japan" },
                    { 130, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/JO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Jordan" },
                    { 129, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/JM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Jamaica" },
                    { 128, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/JE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Jersey" },
                    { 127, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/IT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Italy" },
                    { 133, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/KG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Kyrgyzstan" },
                    { 107, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/GS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "South Georgia and South Sandwich Islands" },
                    { 118, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/ID", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Indonesia" },
                    { 105, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GQ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Equatorial Guinea" },
                    { 86, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/FM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Micronesia" },
                    { 85, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/FK", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Falkland Islands" },
                    { 84, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/FJ", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Fiji" },
                    { 83, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/FI", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Finland" },
                    { 82, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "http://data.food.gov.uk/codes/geographies/countries/EU", "34b97e9d-eb28-444f-87cb-2c6311af8009", "European Union" },
                    { 81, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/ET", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Ethiopia" },
                    { 87, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/FO", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Faroe Islands" },
                    { 80, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/ES-ML", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Melilla" },
                    { 78, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/ES", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Spain" },
                    { 106, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Greece" },
                    { 76, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/EH", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Western Sahara" },
                    { 75, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/EG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Egypt" },
                    { 74, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/EE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Estonia" },
                    { 73, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/EC", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Ecuador" },
                    { 79, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/ES-CE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Ceuta" },
                    { 88, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/FR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "France" },
                    { 77, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/ER", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Eritrea" },
                    { 90, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GB", "34b97e9d-eb28-444f-87cb-2c6311af8009", "United Kingdom" },
                    { 89, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GA", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Gabon" },
                    { 104, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/GP", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Guadeloupe" },
                    { 103, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GN", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Guinea" },
                    { 101, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/GL", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Greenland" },
                    { 100, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/GI", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Gibraltar" },
                    { 99, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GH", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Ghana" },
                    { 98, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/GG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Guernsey" },
                    { 102, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GM", "34b97e9d-eb28-444f-87cb-2c6311af8009", "The Gambia" },
                    { 96, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GE", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Georgia" },
                    { 95, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://country.register.gov.uk/record/GD", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Grenada" },
                    { 94, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "http://data.food.gov.uk/codes/geographies/countries/GB-WLS", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Wales" },
                    { 93, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "http://data.food.gov.uk/codes/geographies/countries/GB-SCT", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Scotland" },
                    { 92, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "http://data.food.gov.uk/codes/geographies/countries/GB-NIR", "34b97e9d-eb28-444f-87cb-2c6311af8009", "Northern Ireland" },
                    { 97, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "https://territory.register.gov.uk/record/GF", "34b97e9d-eb28-444f-87cb-2c6311af8009", "French Guiana" },
                    { 91, "5134b97e9d-eb28-444f-87cb-2c6311af8009", "http://data.food.gov.uk/codes/geographies/countries/GB-ENG", "34b97e9d-eb28-444f-87cb-2c6311af8009", "England" }
                });

            migrationBuilder.InsertData(
                table: "DataSources",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 42, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU) - NFCU INTEL Report" },
                    { 41, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU)" },
                    { 40, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Crime Agency (NCA)" },
                    { 39, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Met Office" },
                    { 38, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Medicines & Healthcare products Regulatory Agency (MHRA)" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Local Authority" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Marine Management Organisation (MMO)" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "INFOSAN" },
                    { 43, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU) - DIM Referral" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Industry" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health & Safety Executive" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Maritime & Costguard Agency (MCA)" },
                    { 44, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Health Service (NHS)" },
                    { 52, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SAC (Scottish Agricultural College)" },
                    { 46, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" },
                    { 47, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Police" },
                    { 48, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Port Health Authority (PHA)" },
                    { 49, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public Analyst / Laboratory" },
                    { 50, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public Health England (PHE)" },
                    { 51, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RASFF" },
                    { 53, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "SOCA" },
                    { 54, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Third Country" },
                    { 55, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Water Company" },
                    { 57, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Unmapped SPT Signal Value" },
                    { 58, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health Protection Scotland (HPS)" },
                    { 45, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nuclear Power Station" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health Protection Agency (HPA)" },
                    { 56, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Veterinary Medicines Directorate" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "General Public" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Home Office / Border Force" },
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
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Unannounced Inspector" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Wales (FSAW)" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Survey" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA RAM Referral" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Poultry Hygiene Inspector" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Wine Inspector" },
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
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Abdominal Pain" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTags",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Phytosanitary Certifcate" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public warning / Press release" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Recipients List" },
                    { 512, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk assessment" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health certifiacte" },
                    { 1024, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Screenshot" },
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Picture" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Follow up notification" },
                    { 4096, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Video File" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Analytical report" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CVED/CED" },
                    { 8192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" },
                    { 2048, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Translation" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bill / Delivery Document" }
                });

            migrationBuilder.InsertData(
                table: "FBOTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1024, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Producer" },
                    { 512, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Processor" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Packer/filler" },
                    { 2048, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Retailer" },
                    { 65536, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wholesaler" },
                    { 8192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Supplier" },
                    { 16384, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Trader/Broker" },
                    { 32768, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Transporter" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Manufacturer" },
                    { 4096, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Storage" },
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Importer" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "e-platform/e-market place" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Farmer" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Exporter" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "e-trader" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Consignor" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hospitality/Food service" }
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
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "pesticide residues" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "process contaminants" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Radiation" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "residues of veterinary medicinal products" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Supplements: Unauthorised substance" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TSEs" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Unauthorised Pesticides" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "unclassified" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Use-by date exceeded" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "poor or insufficient controls" },
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
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Retailer" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Local Authority" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public individual" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Manufacturer" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Low" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Medium" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "High" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "TBC" }
                });

            migrationBuilder.InsertData(
                table: "ProductDateTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Display Until" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Use By Date" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Best before" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Best before End" }
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
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Non-Alcoholic Beverages" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Nuts / Nut Products / Seeds" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other Food Product / Mixed" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pet Food" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Poultry Meat & Poultry Meat Products" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fruits & Vegetables" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Soups / Broths / Sauces & Condiments" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Water" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wine" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Unmapped SPT Signal Value" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Prepared Dishes & Snacks" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Additives & Flavourings" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fish & Fish Products" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Animal by-Products" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Alcoholic Beverages" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Contact Materials" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cephalopods & Products Thereof" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cereals & Bakery Products" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Cocoa / Cocoa Preparations / Coffee / Tea" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Compound Feeds" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bivalve Molluscs & Products Thereof" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Crustaceans & Products Thereof" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dietetic Foods / Food Supplements / Fortified Foods" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Egg & Egg Products" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fats & Oils" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Feed Additives" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Feed Materials" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Feed Premixtures" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Confectionery" }
                });

            migrationBuilder.InsertData(
                table: "SignalStatus",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "SortOrder", "Title" },
                values: new object[,]
                {
                    { 200, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 600, "Closed : Linked Incident" },
                    { 150, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 700, "Closed : Referral (Offline)" },
                    { 100, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 500, "Closed : No Incident" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 100, "Unassigned" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 300, "Pending" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 200, "Open" },
                    { 50, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 400, "Closed : New Incident" }
                });

            migrationBuilder.InsertData(
                table: "StakeholderDiscriminators",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food/Feed Business Operator (FBO/FeBO)" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other government department" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food/Feed Business Operator (FBO/FeBO)" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Standards Agency (FSA)" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Local Authority" }
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
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Field Operations - FVL" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Business Assurance Auditors" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Meat Hygiene Inspector" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Poultry Hygiene Inspector" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wine Inspector" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Receipt & Management  (RAM) Lead" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Stakeholder  Engagement  (SHE) Lead" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Receipt & Management (RAM ) Officer" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Stakeholder Engagement (SHE) Officer" },
                    { 38, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy Lead - FSA" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chair, IMCG" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Field Operations - FVC" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Operational Incident Management Team (OIMT)" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Management Co-ordination Group (IMCG)" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Briefing Cell" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Briefing Cell Manager" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Situation Report (SITREP) Lead" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Q&A lead" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Communications Lead" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Press Officer" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Legal Advisior" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Official Note Taker" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy/Science Lead" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Admin Support" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Lead?" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Manager" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk Assesor" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Support?" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSS/FSA Liason" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ministerial Submission Lead" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk Manager" }
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
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ppt" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Gallons" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/M3" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/M2" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/l" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/Kg" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "µSv" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "µg/kg" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" },
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
                name: "ClosedSignalTeams");

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
                name: "UserAccessLog");

            migrationBuilder.DropTable(
                name: "IncidentProducts");

            migrationBuilder.DropTable(
                name: "ClosedSignalReasons");

            migrationBuilder.DropTable(
                name: "ProductDateTypes");

            migrationBuilder.DropTable(
                name: "SignalProducts");

            migrationBuilder.DropTable(
                name: "StakeholderDiscriminators");

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
