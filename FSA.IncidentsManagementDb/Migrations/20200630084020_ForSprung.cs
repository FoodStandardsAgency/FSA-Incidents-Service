using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class ForSprung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations");

            migrationBuilder.DropIndex(
                name: "IX_Organisations_OrganisationRoleId",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "OrganisationRoleId",
                table: "Organisations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganisationRoleId",
                table: "Organisations",
                type: "int",
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
