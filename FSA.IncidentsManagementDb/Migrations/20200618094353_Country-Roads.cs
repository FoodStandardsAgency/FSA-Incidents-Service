using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class CountryRoads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminLead",
                table: "Incidents");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Organisations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeadOffice",
                table: "Incidents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_CountryId",
                table: "Organisations",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organisations_Countries_CountryId",
                table: "Organisations",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organisations_Countries_CountryId",
                table: "Organisations");

            migrationBuilder.DropIndex(
                name: "IX_Organisations_CountryId",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "LeadOffice",
                table: "Incidents");

            migrationBuilder.AddColumn<string>(
                name: "AdminLead",
                table: "Incidents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
