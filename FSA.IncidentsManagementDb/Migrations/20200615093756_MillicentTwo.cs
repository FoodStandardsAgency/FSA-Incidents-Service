using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class MillicentTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations");

            migrationBuilder.DropIndex(
                name: "IX_Organisations_OrganisationRoleId",
                table: "Organisations");

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_OrganisationRoleId",
                table: "Organisations",
                column: "OrganisationRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations",
                column: "OrganisationRoleId",
                principalTable: "OrganisationRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations");

            migrationBuilder.DropIndex(
                name: "IX_Organisations_OrganisationRoleId",
                table: "Organisations");

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_OrganisationRoleId",
                table: "Organisations",
                column: "OrganisationRoleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations",
                column: "OrganisationRoleId",
                principalTable: "OrganisationRoles",
                principalColumn: "Id");
        }
    }
}
