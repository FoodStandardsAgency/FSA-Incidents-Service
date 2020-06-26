using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class ForStrongTeeth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FBOTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBOTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotifierTypeDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifierTypeDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FBOs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    FBOTypeId = table.Column<int>(nullable: false),
                    OrganisationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FBOs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FBOs_FBOTypes_FBOTypeId",
                        column: x => x.FBOTypeId,
                        principalTable: "FBOTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FBOs_Organisations_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFBOItems",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    FBOId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFBOItems", x => new { x.ProductId, x.FBOId });
                    table.ForeignKey(
                        name: "FK_ProductFBOItems_FBOs_FBOId",
                        column: x => x.FBOId,
                        principalTable: "FBOs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFBOItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FBOs_FBOTypeId",
                table: "FBOs",
                column: "FBOTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FBOs_OrganisationId",
                table: "FBOs",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFBOItems_FBOId",
                table: "ProductFBOItems",
                column: "FBOId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotifierTypeDb");

            migrationBuilder.DropTable(
                name: "ProductFBOItems");

            migrationBuilder.DropTable(
                name: "FBOs");

            migrationBuilder.DropTable(
                name: "FBOTypes");
        }
    }
}
