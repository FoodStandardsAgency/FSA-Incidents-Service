using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class removeHazrdIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_HazardGroups_IncidentTypeId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_IncidentTypeId",
                table: "Incidents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Incidents_IncidentTypeId",
                table: "Incidents",
                column: "IncidentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_HazardGroups_IncidentTypeId",
                table: "Incidents",
                column: "IncidentTypeId",
                principalTable: "HazardGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
