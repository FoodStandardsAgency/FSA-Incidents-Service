using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class newProject : Migration
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
                name: "Categories",
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
                    table.PrimaryKey("PK_Categories", x => x.Id);
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
                    Title = table.Column<string>(nullable: true),
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
                name: "Signals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SPTId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(maxLength: 300, nullable: true),
                    SignalStatus = table.Column<string>(nullable: true),
                    Priority = table.Column<string>(nullable: true),
                    LeadOfficer = table.Column<string>(nullable: true),
                    AlertType = table.Column<string>(nullable: true),
                    CountryOfOrigin = table.Column<string>(maxLength: 80, nullable: true),
                    NotifyingCountry = table.Column<string>(maxLength: 80, nullable: true),
                    IsEu = table.Column<bool>(nullable: false),
                    FoodOrFeed = table.Column<string>(maxLength: 10, nullable: true),
                    BaseProduct = table.Column<string>(maxLength: 155, nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "SignalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    IsOpen = table.Column<bool>(nullable: false),
                    IsUnassigned = table.Column<bool>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignalStatus_SignalStatus_ParentId",
                        column: x => x.ParentId,
                        principalTable: "SignalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StakeholderDiscriminatorDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
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
                name: "SignalAttachments",
                columns: table => new
                {
                    DocUrl = table.Column<string>(nullable: false),
                    SignalId = table.Column<int>(nullable: false),
                    TagFlags = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignalLinks",
                columns: table => new
                {
                    FromId = table.Column<int>(nullable: false),
                    ToId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FromId1 = table.Column<int>(nullable: true),
                    ToId1 = table.Column<int>(nullable: true),
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
                        name: "FK_SignalLinks_Signals_FromId1",
                        column: x => x.FromId1,
                        principalTable: "Signals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SignalLinks_Signals_ToId1",
                        column: x => x.ToId1,
                        principalTable: "Signals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SignalNotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(nullable: true),
                    SignalId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
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
                name: "SignalProductDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    CountryOfOriginId = table.Column<int>(nullable: false),
                    Amount = table.Column<string>(nullable: true, defaultValue: "0.00"),
                    AmountUnitTypeId = table.Column<int>(nullable: false),
                    BatchCodes = table.Column<string>(nullable: true),
                    PackDescription = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    SignalId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalProductDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignalProductDb_UnitQuantities_AmountUnitTypeId",
                        column: x => x.AmountUnitTypeId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignalProductDb_Countries_CountryOfOriginId",
                        column: x => x.CountryOfOriginId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignalProductDb_SignalProductDb_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "SignalProductDb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignalProductDb_Signals_SignalId",
                        column: x => x.SignalId,
                        principalTable: "Signals",
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
                    table.UniqueConstraint("AK_Incidents_MostUniqueId", x => x.MostUniqueId);
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
                        name: "FK_Incidents_Categories_IncidentTypeId",
                        column: x => x.IncidentTypeId,
                        principalTable: "Categories",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignalStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId",
                        column: x => x.StakeholderDiscriminatorId,
                        principalTable: "StakeholderDiscriminatorDb",
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
                    Discriminator = table.Column<string>(nullable: false),
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
                        name: "FK_SignalProductDates_SignalProductDb_SignalId",
                        column: x => x.SignalId,
                        principalTable: "SignalProductDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignalProductFbos",
                columns: table => new
                {
                    SignalId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    FboTypes = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    ProductId1 = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalProductFbos", x => new { x.SignalId, x.AddressId });
                    table.ForeignKey(
                        name: "FK_SignalProductFbos_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignalProductFbos_SignalProductDb_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "SignalProductDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Discriminator = table.Column<string>(nullable: false),
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
                        name: "FK_SignalProductPackSizes_UnitQuantities_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignalProductPackSizes_SignalProductDb_SignalId",
                        column: x => x.SignalId,
                        principalTable: "SignalProductDb",
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
                    Discriminator = table.Column<string>(nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncidentLinks",
                columns: table => new
                {
                    FromId = table.Column<int>(nullable: false),
                    ToId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FromId1 = table.Column<int>(nullable: true),
                    ToId1 = table.Column<int>(nullable: true),
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
                        name: "FK_IncidentLinks_Incidents_FromId1",
                        column: x => x.FromId1,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncidentLinks_Incidents_ToId1",
                        column: x => x.ToId1,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncidentNotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(nullable: true),
                    IncidentId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
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
                name: "IncidentProductDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    CountryOfOriginId = table.Column<int>(nullable: false),
                    Amount = table.Column<string>(nullable: true, defaultValue: "0.00"),
                    AmountUnitTypeId = table.Column<int>(nullable: false),
                    BatchCodes = table.Column<string>(nullable: true),
                    PackDescription = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    IncidentId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentProductDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentProductDb_UnitQuantities_AmountUnitTypeId",
                        column: x => x.AmountUnitTypeId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncidentProductDb_Countries_CountryOfOriginId",
                        column: x => x.CountryOfOriginId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncidentProductDb_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncidentProductDb_IncidentProductDb_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "IncidentProductDb",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncidentStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId",
                        column: x => x.StakeholderDiscriminatorId,
                        principalTable: "StakeholderDiscriminatorDb",
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
                    Discriminator = table.Column<string>(nullable: false),
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
                        name: "FK_IncidentProductDates_IncidentProductDb_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "IncidentProductDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncidentProductFbos",
                columns: table => new
                {
                    IncidentId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    FboTypes = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    ProductId1 = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentProductFbos", x => new { x.IncidentId, x.AddressId });
                    table.ForeignKey(
                        name: "FK_IncidentProductFbos_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncidentProductFbos_IncidentProductDb_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "IncidentProductDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Discriminator = table.Column<string>(nullable: false),
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
                        name: "FK_IncidentProductPackSizes_UnitQuantities_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncidentProductPackSizes_IncidentProductDb_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "IncidentProductDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_IncidentLinks_FromId1",
                table: "IncidentLinks",
                column: "FromId1");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentLinks_ToId1",
                table: "IncidentLinks",
                column: "ToId1");

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
                name: "IX_IncidentProductDb_AmountUnitTypeId",
                table: "IncidentProductDb",
                column: "AmountUnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductDb_CountryOfOriginId",
                table: "IncidentProductDb",
                column: "CountryOfOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductDb_IncidentId",
                table: "IncidentProductDb",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductDb_ProductTypeId",
                table: "IncidentProductDb",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductFbos_AddressId",
                table: "IncidentProductFbos",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductFbos_ProductId1",
                table: "IncidentProductFbos",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductPackSizes_UnitId",
                table: "IncidentProductPackSizes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductPackSizes_IncidentId",
                table: "IncidentProductPackSizes",
                column: "IncidentId");

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
                name: "IX_SignalLinks_FromId1",
                table: "SignalLinks",
                column: "FromId1");

            migrationBuilder.CreateIndex(
                name: "IX_SignalLinks_ToId1",
                table: "SignalLinks",
                column: "ToId1");

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
                name: "IX_SignalProductDb_AmountUnitTypeId",
                table: "SignalProductDb",
                column: "AmountUnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductDb_CountryOfOriginId",
                table: "SignalProductDb",
                column: "CountryOfOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductDb_ProductTypeId",
                table: "SignalProductDb",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductDb_SignalId",
                table: "SignalProductDb",
                column: "SignalId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductFbos_AddressId",
                table: "SignalProductFbos",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductFbos_ProductId1",
                table: "SignalProductFbos",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductPackSizes_UnitId",
                table: "SignalProductPackSizes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductPackSizes_SignalId",
                table: "SignalProductPackSizes",
                column: "SignalId");

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

            migrationBuilder.CreateIndex(
                name: "IX_SignalStatus_ParentId",
                table: "SignalStatus",
                column: "ParentId");
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
                name: "IncidentProductDb");

            migrationBuilder.DropTable(
                name: "ProductDateTypes");

            migrationBuilder.DropTable(
                name: "SignalProductDb");

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
                name: "Categories");

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
