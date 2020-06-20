using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class Tabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentLinks_Incidents_IncidentDbId",
                table: "IncidentLinks");

            migrationBuilder.DropIndex(
                name: "IX_IncidentLinks_IncidentDbId",
                table: "IncidentLinks");

            migrationBuilder.DropColumn(
                name: "IncidentDbId",
                table: "IncidentLinks");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentLinks_ToIncidentId",
                table: "IncidentLinks",
                column: "ToIncidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentLinks_Incidents_FromIncidentId",
                table: "IncidentLinks",
                column: "FromIncidentId",
                principalTable: "Incidents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentLinks_Incidents_ToIncidentId",
                table: "IncidentLinks",
                column: "ToIncidentId",
                principalTable: "Incidents",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentLinks_Incidents_FromIncidentId",
                table: "IncidentLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentLinks_Incidents_ToIncidentId",
                table: "IncidentLinks");

            migrationBuilder.DropIndex(
                name: "IX_IncidentLinks_ToIncidentId",
                table: "IncidentLinks");

            migrationBuilder.AddColumn<int>(
                name: "IncidentDbId",
                table: "IncidentLinks",
                type: "int",
                nullable: true);

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
        }
    }
}
