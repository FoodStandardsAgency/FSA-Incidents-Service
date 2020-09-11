using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class rollingBe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_SignalIncidentLinks_IncidentId",
                table: "SignalIncidentLinks",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalIncidentLinks_SignalId",
                table: "SignalIncidentLinks",
                column: "SignalId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SignalIncidentLinks");
        }
    }
}
