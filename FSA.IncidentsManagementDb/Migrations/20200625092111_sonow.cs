using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class sonow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DateTypeDb",
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
                    table.PrimaryKey("PK_DateTypeDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Name = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    CountryOfOriginId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    AmountUnitType = table.Column<int>(nullable: false),
                    AmountUnitTypeIdId = table.Column<int>(nullable: true),
                    BatchCodes = table.Column<string>(nullable: true),
                    PackDescription = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    DataSourceId = table.Column<int>(nullable: true),
                    SignalUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_UnitQuantities_AmountUnitTypeIdId",
                        column: x => x.AmountUnitTypeIdId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Countries_CountryOfOriginId",
                        column: x => x.CountryOfOriginId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_DataSources_DataSourceId",
                        column: x => x.DataSourceId,
                        principalTable: "DataSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    DateTypeId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ProductDbId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDates_DateTypeDb_DateTypeId",
                        column: x => x.DateTypeId,
                        principalTable: "DateTypeDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDates_Products_ProductDbId",
                        column: x => x.ProductDbId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductPackSizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Size = table.Column<string>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPackSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPackSizes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPackSizes_UnitQuantities_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDates_DateTypeId",
                table: "ProductDates",
                column: "DateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDates_ProductDbId",
                table: "ProductDates",
                column: "ProductDbId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPackSizes_ProductId",
                table: "ProductPackSizes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPackSizes_UnitId",
                table: "ProductPackSizes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AmountUnitTypeIdId",
                table: "Products",
                column: "AmountUnitTypeIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CountryOfOriginId",
                table: "Products",
                column: "CountryOfOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DataSourceId",
                table: "Products",
                column: "DataSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDates");

            migrationBuilder.DropTable(
                name: "ProductPackSizes");

            migrationBuilder.DropTable(
                name: "DateTypeDb");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
