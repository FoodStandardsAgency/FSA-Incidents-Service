using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class HeeHaw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
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
                    Title = table.Column<string>(nullable: true)
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
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataSources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
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
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeathIllnesss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GatewayErrorCodes",
                columns: table => new
                {
                    ReturnCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatewayErrorCodes", x => x.ReturnCode);
                });

            migrationBuilder.CreateTable(
                name: "GatewayRequestDetails",
                columns: table => new
                {
                    RequestId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    TargetProcedure = table.Column<string>(nullable: true),
                    JsonParameters = table.Column<string>(nullable: true),
                    RequestingAppAccount = table.Column<string>(nullable: true),
                    RequestedAt = table.Column<DateTime>(nullable: true),
                    CompletedAt = table.Column<DateTime>(nullable: true),
                    ResultCode = table.Column<int>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatewayRequestDetails", x => x.RequestId);
                });

            migrationBuilder.CreateTable(
                name: "GatewayUserIncidents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    LastReturnedIncidentId = table.Column<int>(nullable: true),
                    RequestId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatewayUserIncidents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncidentLinks",
                columns: table => new
                {
                    FromIncidentId = table.Column<int>(nullable: false),
                    ToIncidentId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentLinks", x => new { x.FromIncidentId, x.ToIncidentId });
                });

            migrationBuilder.CreateTable(
                name: "IncidentStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OMITGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OMITGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganisationRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CanBeNotifier = table.Column<bool>(nullable: false),
                    CanBeFBO = table.Column<bool>(nullable: false),
                    CanBeLocalAuthority = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganisationRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonaRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CanBeAdminLead = table.Column<bool>(nullable: false),
                    CanBeIncidentLead = table.Column<bool>(nullable: false),
                    CanBeFieldOfficer = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
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
                    Title = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    IsOpen = table.Column<bool>(nullable: false),
                    IsUnassigned = table.Column<bool>(nullable: false)
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
                name: "UnitQuantities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitQuantities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    LastChangedById = table.Column<int>(nullable: false),
                    LastChangedByDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNames = table.Column<string>(nullable: true),
                    MiddleNames = table.Column<string>(nullable: true),
                    Surnames = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    LastChangedById = table.Column<int>(nullable: false),
                    LastChangedByDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainContact = table.Column<string>(nullable: true),
                    Organisation = table.Column<string>(nullable: true),
                    OrganisationRoleId = table.Column<int>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    TownCity = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    FaxAddress = table.Column<string>(nullable: true),
                    ContactMethodId = table.Column<int>(nullable: false),
                    LastChangedById = table.Column<int>(nullable: false),
                    LastChangedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organisations_ContactMethods_ContactMethodId",
                        column: x => x.ContactMethodId,
                        principalTable: "ContactMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                        column: x => x.OrganisationRoleId,
                        principalTable: "OrganisationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    IncidentTitle = table.Column<string>(nullable: true),
                    IncidentDescription = table.Column<string>(nullable: true),
                    IncidentTypeId = table.Column<int>(nullable: false),
                    ContactMethodId = table.Column<int>(nullable: false),
                    SignalStatusId = table.Column<int>(nullable: true),
                    IncidentStatusId = table.Column<int>(nullable: false),
                    NotifierId = table.Column<int>(nullable: true),
                    PrincipalFBOId = table.Column<int>(nullable: true),
                    ClassificationId = table.Column<int>(nullable: false),
                    DataSourceId = table.Column<int>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false),
                    LeadOfficerId = table.Column<int>(nullable: true),
                    AdminLeadId = table.Column<int>(nullable: true),
                    FieldOfficerId = table.Column<int>(nullable: true),
                    LeadLocalAuthorityId = table.Column<int>(nullable: true),
                    LAAdvised = table.Column<bool>(nullable: false),
                    DeathIllnessId = table.Column<int>(nullable: false),
                    ReceivedOn = table.Column<DateTime>(nullable: true),
                    IncidentCreated = table.Column<DateTime>(nullable: false),
                    IncidentClosed = table.Column<DateTime>(nullable: true),
                    LastChangedById = table.Column<int>(nullable: false),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    _reserved_importref = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidents_Classifications_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "Classifications",
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
                        name: "FK_Incidents_Organisations_LeadLocalAuthorityId",
                        column: x => x.LeadLocalAuthorityId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Organisations_NotifierId",
                        column: x => x.NotifierId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Organisations_PrincipalFBOId",
                        column: x => x.PrincipalFBOId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IncidentComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    IncidentId = table.Column<int>(nullable: false),
                    IncidentProductId = table.Column<int>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    LastChangedById = table.Column<int>(nullable: false),
                    LastChangedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentComments_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncidentOMITGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OMITGroupId = table.Column<int>(nullable: false),
                    LastChangedById = table.Column<int>(nullable: false),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    IncidentId = table.Column<int>(nullable: false),
                    IncidentDbId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentOMITGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentOMITGroups_Incidents_IncidentDbId",
                        column: x => x.IncidentDbId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncidentOMITGroups_OMITGroups_OMITGroupId",
                        column: x => x.OMITGroupId,
                        principalTable: "OMITGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IncidentComments_IncidentId",
                table: "IncidentComments",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentOMITGroups_IncidentDbId",
                table: "IncidentOMITGroups",
                column: "IncidentDbId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentOMITGroups_OMITGroupId",
                table: "IncidentOMITGroups",
                column: "OMITGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ClassificationId",
                table: "Incidents",
                column: "ClassificationId");

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
                name: "IX_Incidents_ProductTypeId",
                table: "Incidents",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_SignalStatusId",
                table: "Incidents",
                column: "SignalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_ContactMethodId",
                table: "Organisations",
                column: "ContactMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_OrganisationRoleId",
                table: "Organisations",
                column: "OrganisationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalStatus_ParentId",
                table: "SignalStatus",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countrys");

            migrationBuilder.DropTable(
                name: "GatewayErrorCodes");

            migrationBuilder.DropTable(
                name: "GatewayRequestDetails");

            migrationBuilder.DropTable(
                name: "GatewayUserIncidents");

            migrationBuilder.DropTable(
                name: "IncidentComments");

            migrationBuilder.DropTable(
                name: "IncidentLinks");

            migrationBuilder.DropTable(
                name: "IncidentOMITGroups");

            migrationBuilder.DropTable(
                name: "PersonaRoles");

            migrationBuilder.DropTable(
                name: "UnitQuantities");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "OMITGroups");

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
                name: "Organisations");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "SignalStatus");

            migrationBuilder.DropTable(
                name: "ContactMethods");

            migrationBuilder.DropTable(
                name: "OrganisationRoles");
        }
    }
}
