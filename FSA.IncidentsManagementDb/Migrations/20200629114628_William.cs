using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class William : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_UnitQuantities_AmountUnitTypeIdId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AmountUnitTypeIdId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "AmountUnitType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AmountUnitTypeIdId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "AmountUnitTypeId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "High");

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Low");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AmountUnitTypeId",
                table: "Products",
                column: "AmountUnitTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UnitQuantities_AmountUnitTypeId",
                table: "Products",
                column: "AmountUnitTypeId",
                principalTable: "UnitQuantities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_UnitQuantities_AmountUnitTypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AmountUnitTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AmountUnitTypeId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "AmountUnitType",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountUnitTypeIdId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Low");

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "High");

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[] { 1, "Paul", "Paul", "Unclassified" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AmountUnitTypeIdId",
                table: "Products",
                column: "AmountUnitTypeIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UnitQuantities_AmountUnitTypeIdId",
                table: "Products",
                column: "AmountUnitTypeIdId",
                principalTable: "UnitQuantities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
