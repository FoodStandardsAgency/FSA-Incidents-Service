using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class address_contact_plus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressContactDb_Addresses_AddressId",
                table: "AddressContactDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressContactDb",
                table: "AddressContactDb");

            migrationBuilder.RenameTable(
                name: "AddressContactDb",
                newName: "AddressContacts");

            migrationBuilder.RenameIndex(
                name: "IX_AddressContactDb_AddressId",
                table: "AddressContacts",
                newName: "IX_AddressContacts_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressContacts",
                table: "AddressContacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressContacts_Addresses_AddressId",
                table: "AddressContacts",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressContacts_Addresses_AddressId",
                table: "AddressContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressContacts",
                table: "AddressContacts");

            migrationBuilder.RenameTable(
                name: "AddressContacts",
                newName: "AddressContactDb");

            migrationBuilder.RenameIndex(
                name: "IX_AddressContacts_AddressId",
                table: "AddressContactDb",
                newName: "IX_AddressContactDb_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressContactDb",
                table: "AddressContactDb",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressContactDb_Addresses_AddressId",
                table: "AddressContactDb",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
