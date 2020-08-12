using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class BronkerStonker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Stakeholders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StakeholderDiscriminatorId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stakeholders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stakeholders_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId",
                        column: x => x.StakeholderDiscriminatorId,
                        principalTable: "StakeholderDiscriminators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stakeholders_IncidentId",
                table: "Stakeholders",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Stakeholders_StakeholderDiscriminatorId",
                table: "Stakeholders",
                column: "StakeholderDiscriminatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stakeholders");

            migrationBuilder.DropTable(
                name: "StakeholderDiscriminators");
        }
    }
}
