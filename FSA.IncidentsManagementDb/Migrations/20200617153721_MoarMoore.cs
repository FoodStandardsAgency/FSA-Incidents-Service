using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class MoarMoore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "Incidents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IncidentDbId",
                table: "IncidentLinks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Priorities",
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
                    table.PrimaryKey("PK_Priorities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_PriorityId",
                table: "Incidents",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentLinks_IncidentDbId",
                table: "IncidentLinks",
                column: "IncidentDbId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentLinks_Incidents_IncidentDbId",
                table: "IncidentLinks",
                column: "IncidentDbId",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Priorities_PriorityId",
                table: "Incidents",
                column: "PriorityId",
                principalTable: "Priorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentLinks_Incidents_IncidentDbId",
                table: "IncidentLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Priorities_PriorityId",
                table: "Incidents");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_PriorityId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_IncidentLinks_IncidentDbId",
                table: "IncidentLinks");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "IncidentDbId",
                table: "IncidentLinks");
        }
    }
}
