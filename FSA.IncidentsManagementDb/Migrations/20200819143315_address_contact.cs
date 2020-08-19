using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class address_contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Addresses");

            migrationBuilder.CreateTable(
                name: "AddressContactDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressContactDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressContactDb_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "StakeholderDiscriminators",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Food Standards Agency (FSA)");

            migrationBuilder.UpdateData(
                table: "StakeholderDiscriminators",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Food/Feed Business Operator (FBO/FeBO)");

            migrationBuilder.CreateIndex(
                name: "IX_AddressContactDb_AddressId",
                table: "AddressContactDb",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressContactDb");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "StakeholderDiscriminators",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "FSA");

            migrationBuilder.UpdateData(
                table: "StakeholderDiscriminators",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "FBO/FeBO");
        }
    }
}
