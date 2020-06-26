using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class secondVersePtMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "FaxAddress",
                table: "Organisations");

            migrationBuilder.AlterColumn<int>(
                name: "OrganisationRoleId",
                table: "Organisations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations",
                column: "OrganisationRoleId",
                principalTable: "OrganisationRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations");

            migrationBuilder.AlterColumn<int>(
                name: "OrganisationRoleId",
                table: "Organisations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FaxAddress",
                table: "Organisations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Organisations_OrganisationRoles_OrganisationRoleId",
                table: "Organisations",
                column: "OrganisationRoleId",
                principalTable: "OrganisationRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
