using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class contactmethods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ContactMethodId",
                table: "Incidents",
                column: "ContactMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_ContactMethods_ContactMethodId",
                table: "Incidents",
                column: "ContactMethodId",
                principalTable: "ContactMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_ContactMethods_ContactMethodId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_ContactMethodId",
                table: "Incidents");
        }
    }
}
