using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class modeAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Notifiers_LeadLocalAuthorityId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Notifiers_NotifierId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "FirstNameDept",
                table: "Stakeholders");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Stakeholders");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AddressContacts");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AddressContacts");

            migrationBuilder.AddColumn<string>(
                name: "GovDept",
                table: "Stakeholders",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Stakeholders",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AddressContacts",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Addresses_LeadLocalAuthorityId",
                table: "Incidents",
                column: "LeadLocalAuthorityId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Addresses_NotifierId",
                table: "Incidents",
                column: "NotifierId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Addresses_LeadLocalAuthorityId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Addresses_NotifierId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "GovDept",
                table: "Stakeholders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Stakeholders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AddressContacts");

            migrationBuilder.AddColumn<string>(
                name: "FirstNameDept",
                table: "Stakeholders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Stakeholders",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AddressContacts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AddressContacts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Notifiers_LeadLocalAuthorityId",
                table: "Incidents",
                column: "LeadLocalAuthorityId",
                principalTable: "Notifiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Notifiers_NotifierId",
                table: "Incidents",
                column: "NotifierId",
                principalTable: "Notifiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
