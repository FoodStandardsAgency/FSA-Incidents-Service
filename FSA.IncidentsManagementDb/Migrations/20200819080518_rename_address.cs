using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class rename_address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FBOs_Organisations_OrganisationId",
                table: "FBOs");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifiers_Organisations_OrganisationId",
                table: "Notifiers");

            migrationBuilder.DropTable(
                name: "Organisations");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    MainContact = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    TownCity = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    ContactMethodId = table.Column<int>(nullable: false),
                    Uprn = table.Column<long>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_ContactMethods_ContactMethodId",
                        column: x => x.ContactMethodId,
                        principalTable: "ContactMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ContactMethodId",
                table: "Addresses",
                column: "ContactMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_FBOs_Addresses_OrganisationId",
                table: "FBOs",
                column: "OrganisationId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifiers_Addresses_OrganisationId",
                table: "Notifiers",
                column: "OrganisationId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FBOs_Addresses_OrganisationId",
                table: "FBOs");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifiers_Addresses_OrganisationId",
                table: "Notifiers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMethodId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TownCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uprn = table.Column<long>(type: "bigint", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organisations_ContactMethods_ContactMethodId",
                        column: x => x.ContactMethodId,
                        principalTable: "ContactMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organisations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_ContactMethodId",
                table: "Organisations",
                column: "ContactMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_CountryId",
                table: "Organisations",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_FBOs_Organisations_OrganisationId",
                table: "FBOs",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifiers_Organisations_OrganisationId",
                table: "Notifiers",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
