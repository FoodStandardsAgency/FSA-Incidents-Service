using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class wishy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IncidentId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_IncidentId",
                table: "Products",
                column: "IncidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Incidents_IncidentId",
                table: "Products",
                column: "IncidentId",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Incidents_IncidentId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_IncidentId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IncidentId",
                table: "Products");
        }
    }
}
