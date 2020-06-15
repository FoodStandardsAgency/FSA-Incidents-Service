using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class Millicent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organisations_Organisations_OrganisationRoleId",
                table: "Organisations");

            migrationBuilder.AddForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations",
                column: "OrganisationRoleId",
                principalTable: "OrganisationRoles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations");

            migrationBuilder.AddForeignKey(
                name: "FK_Organisations_Organisations_OrganisationRoleId",
                table: "Organisations",
                column: "OrganisationRoleId",
                principalTable: "Organisations",
                principalColumn: "Id");
        }
    }
}
