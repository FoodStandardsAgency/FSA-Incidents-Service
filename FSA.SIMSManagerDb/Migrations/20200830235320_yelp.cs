using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class yelp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProductDates_IncidentProductDb_IncidentId",
                table: "IncidentProductDates");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProductDb_UnitQuantities_AmountUnitTypeId",
                table: "IncidentProductDb");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProductDb_Countries_CountryOfOriginId",
                table: "IncidentProductDb");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProductDb_Incidents_IncidentId",
                table: "IncidentProductDb");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProductDb_IncidentProductDb_ProductTypeId",
                table: "IncidentProductDb");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProductFbos_IncidentProductDb_ProductId1",
                table: "IncidentProductFbos");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProductPackSizes_IncidentProductDb_IncidentId",
                table: "IncidentProductPackSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProductDates_SignalProductDb_SignalId",
                table: "SignalProductDates");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProductDb_UnitQuantities_AmountUnitTypeId",
                table: "SignalProductDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProductDb_Countries_CountryOfOriginId",
                table: "SignalProductDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProductDb_SignalProductDb_ProductTypeId",
                table: "SignalProductDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProductDb_Signals_SignalId",
                table: "SignalProductDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProductFbos_SignalProductDb_ProductId1",
                table: "SignalProductFbos");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProductPackSizes_SignalProductDb_SignalId",
                table: "SignalProductPackSizes");

            migrationBuilder.DropIndex(
                name: "IX_SignalProductFbos_ProductId1",
                table: "SignalProductFbos");

            migrationBuilder.DropIndex(
                name: "IX_IncidentProductFbos_ProductId1",
                table: "IncidentProductFbos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignalProductDb",
                table: "SignalProductDb");

            migrationBuilder.DropIndex(
                name: "IX_SignalProductDb_SignalId",
                table: "SignalProductDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncidentProductDb",
                table: "IncidentProductDb");

            migrationBuilder.DropIndex(
                name: "IX_IncidentProductDb_IncidentId",
                table: "IncidentProductDb");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "SignalProductPackSizes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "SignalProductFbos");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "SignalProductFbos");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "SignalProductDates");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "IncidentProductPackSizes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "IncidentProductFbos");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "IncidentProductFbos");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "IncidentProductDates");

            migrationBuilder.DropColumn(
                name: "SignalId",
                table: "SignalProductDb");

            migrationBuilder.DropColumn(
                name: "IncidentId",
                table: "IncidentProductDb");

            migrationBuilder.RenameTable(
                name: "SignalProductDb",
                newName: "SignalProducts");

            migrationBuilder.RenameTable(
                name: "IncidentProductDb",
                newName: "IncidentProducts");

            migrationBuilder.RenameColumn(
                name: "SignalId",
                table: "SignalProductFbos",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "IncidentId",
                table: "IncidentProductFbos",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_SignalProductDb_ProductTypeId",
                table: "SignalProducts",
                newName: "IX_SignalProducts_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_SignalProductDb_CountryOfOriginId",
                table: "SignalProducts",
                newName: "IX_SignalProducts_CountryOfOriginId");

            migrationBuilder.RenameIndex(
                name: "IX_SignalProductDb_AmountUnitTypeId",
                table: "SignalProducts",
                newName: "IX_SignalProducts_AmountUnitTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_IncidentProductDb_ProductTypeId",
                table: "IncidentProducts",
                newName: "IX_IncidentProducts_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_IncidentProductDb_CountryOfOriginId",
                table: "IncidentProducts",
                newName: "IX_IncidentProducts_CountryOfOriginId");

            migrationBuilder.RenameIndex(
                name: "IX_IncidentProductDb_AmountUnitTypeId",
                table: "IncidentProducts",
                newName: "IX_IncidentProducts_AmountUnitTypeId");

            migrationBuilder.AddColumn<int>(
                name: "HostId",
                table: "SignalProducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HostId",
                table: "IncidentProducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignalProducts",
                table: "SignalProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncidentProducts",
                table: "IncidentProducts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProducts_HostId",
                table: "SignalProducts",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProducts_HostId",
                table: "IncidentProducts",
                column: "HostId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProductDates_IncidentProducts_IncidentId",
                table: "IncidentProductDates",
                column: "IncidentId",
                principalTable: "IncidentProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProductFbos_IncidentProducts_ProductId",
                table: "IncidentProductFbos",
                column: "ProductId",
                principalTable: "IncidentProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProductPackSizes_IncidentProducts_IncidentId",
                table: "IncidentProductPackSizes",
                column: "IncidentId",
                principalTable: "IncidentProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProducts_UnitQuantities_AmountUnitTypeId",
                table: "IncidentProducts",
                column: "AmountUnitTypeId",
                principalTable: "UnitQuantities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProducts_Countries_CountryOfOriginId",
                table: "IncidentProducts",
                column: "CountryOfOriginId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProducts_Incidents_HostId",
                table: "IncidentProducts",
                column: "HostId",
                principalTable: "Incidents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProducts_ProductTypes_ProductTypeId",
                table: "IncidentProducts",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProductDates_SignalProducts_SignalId",
                table: "SignalProductDates",
                column: "SignalId",
                principalTable: "SignalProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProductFbos_SignalProducts_ProductId",
                table: "SignalProductFbos",
                column: "ProductId",
                principalTable: "SignalProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProductPackSizes_SignalProducts_SignalId",
                table: "SignalProductPackSizes",
                column: "SignalId",
                principalTable: "SignalProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProducts_UnitQuantities_AmountUnitTypeId",
                table: "SignalProducts",
                column: "AmountUnitTypeId",
                principalTable: "UnitQuantities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProducts_Countries_CountryOfOriginId",
                table: "SignalProducts",
                column: "CountryOfOriginId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProducts_Signals_HostId",
                table: "SignalProducts",
                column: "HostId",
                principalTable: "Signals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProducts_ProductTypes_ProductTypeId",
                table: "SignalProducts",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProductDates_IncidentProducts_IncidentId",
                table: "IncidentProductDates");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProductFbos_IncidentProducts_ProductId",
                table: "IncidentProductFbos");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProductPackSizes_IncidentProducts_IncidentId",
                table: "IncidentProductPackSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProducts_UnitQuantities_AmountUnitTypeId",
                table: "IncidentProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProducts_Countries_CountryOfOriginId",
                table: "IncidentProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProducts_Incidents_HostId",
                table: "IncidentProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentProducts_ProductTypes_ProductTypeId",
                table: "IncidentProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProductDates_SignalProducts_SignalId",
                table: "SignalProductDates");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProductFbos_SignalProducts_ProductId",
                table: "SignalProductFbos");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProductPackSizes_SignalProducts_SignalId",
                table: "SignalProductPackSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProducts_UnitQuantities_AmountUnitTypeId",
                table: "SignalProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProducts_Countries_CountryOfOriginId",
                table: "SignalProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProducts_Signals_HostId",
                table: "SignalProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalProducts_ProductTypes_ProductTypeId",
                table: "SignalProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignalProducts",
                table: "SignalProducts");

            migrationBuilder.DropIndex(
                name: "IX_SignalProducts_HostId",
                table: "SignalProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncidentProducts",
                table: "IncidentProducts");

            migrationBuilder.DropIndex(
                name: "IX_IncidentProducts_HostId",
                table: "IncidentProducts");

            migrationBuilder.DropColumn(
                name: "HostId",
                table: "SignalProducts");

            migrationBuilder.DropColumn(
                name: "HostId",
                table: "IncidentProducts");

            migrationBuilder.RenameTable(
                name: "SignalProducts",
                newName: "SignalProductDb");

            migrationBuilder.RenameTable(
                name: "IncidentProducts",
                newName: "IncidentProductDb");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "SignalProductFbos",
                newName: "SignalId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "IncidentProductFbos",
                newName: "IncidentId");

            migrationBuilder.RenameIndex(
                name: "IX_SignalProducts_ProductTypeId",
                table: "SignalProductDb",
                newName: "IX_SignalProductDb_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_SignalProducts_CountryOfOriginId",
                table: "SignalProductDb",
                newName: "IX_SignalProductDb_CountryOfOriginId");

            migrationBuilder.RenameIndex(
                name: "IX_SignalProducts_AmountUnitTypeId",
                table: "SignalProductDb",
                newName: "IX_SignalProductDb_AmountUnitTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_IncidentProducts_ProductTypeId",
                table: "IncidentProductDb",
                newName: "IX_IncidentProductDb_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_IncidentProducts_CountryOfOriginId",
                table: "IncidentProductDb",
                newName: "IX_IncidentProductDb_CountryOfOriginId");

            migrationBuilder.RenameIndex(
                name: "IX_IncidentProducts_AmountUnitTypeId",
                table: "IncidentProductDb",
                newName: "IX_IncidentProductDb_AmountUnitTypeId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "SignalProductPackSizes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "SignalProductFbos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "SignalProductFbos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "SignalProductDates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "IncidentProductPackSizes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "IncidentProductFbos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "IncidentProductFbos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "IncidentProductDates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SignalId",
                table: "SignalProductDb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IncidentId",
                table: "IncidentProductDb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignalProductDb",
                table: "SignalProductDb",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncidentProductDb",
                table: "IncidentProductDb",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductFbos_ProductId1",
                table: "SignalProductFbos",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductFbos_ProductId1",
                table: "IncidentProductFbos",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_SignalProductDb_SignalId",
                table: "SignalProductDb",
                column: "SignalId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentProductDb_IncidentId",
                table: "IncidentProductDb",
                column: "IncidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProductDates_IncidentProductDb_IncidentId",
                table: "IncidentProductDates",
                column: "IncidentId",
                principalTable: "IncidentProductDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProductDb_UnitQuantities_AmountUnitTypeId",
                table: "IncidentProductDb",
                column: "AmountUnitTypeId",
                principalTable: "UnitQuantities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProductDb_Countries_CountryOfOriginId",
                table: "IncidentProductDb",
                column: "CountryOfOriginId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProductDb_Incidents_IncidentId",
                table: "IncidentProductDb",
                column: "IncidentId",
                principalTable: "Incidents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProductDb_IncidentProductDb_ProductTypeId",
                table: "IncidentProductDb",
                column: "ProductTypeId",
                principalTable: "IncidentProductDb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProductFbos_IncidentProductDb_ProductId1",
                table: "IncidentProductFbos",
                column: "ProductId1",
                principalTable: "IncidentProductDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentProductPackSizes_IncidentProductDb_IncidentId",
                table: "IncidentProductPackSizes",
                column: "IncidentId",
                principalTable: "IncidentProductDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProductDates_SignalProductDb_SignalId",
                table: "SignalProductDates",
                column: "SignalId",
                principalTable: "SignalProductDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProductDb_UnitQuantities_AmountUnitTypeId",
                table: "SignalProductDb",
                column: "AmountUnitTypeId",
                principalTable: "UnitQuantities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProductDb_Countries_CountryOfOriginId",
                table: "SignalProductDb",
                column: "CountryOfOriginId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProductDb_SignalProductDb_ProductTypeId",
                table: "SignalProductDb",
                column: "ProductTypeId",
                principalTable: "SignalProductDb",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProductDb_Signals_SignalId",
                table: "SignalProductDb",
                column: "SignalId",
                principalTable: "Signals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProductFbos_SignalProductDb_ProductId1",
                table: "SignalProductFbos",
                column: "ProductId1",
                principalTable: "SignalProductDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalProductPackSizes_SignalProductDb_SignalId",
                table: "SignalProductPackSizes",
                column: "SignalId",
                principalTable: "SignalProductDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
