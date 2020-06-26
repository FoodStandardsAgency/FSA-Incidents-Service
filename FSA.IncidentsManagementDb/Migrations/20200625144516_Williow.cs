using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class Williow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDates_DateTypeDb_DateTypeId",
                table: "ProductDates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DateTypeDb",
                table: "DateTypeDb");

            migrationBuilder.RenameTable(
                name: "DateTypeDb",
                newName: "ProductDateTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDateTypes",
                table: "ProductDateTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDates_ProductDateTypes_DateTypeId",
                table: "ProductDates",
                column: "DateTypeId",
                principalTable: "ProductDateTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDates_ProductDateTypes_DateTypeId",
                table: "ProductDates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDateTypes",
                table: "ProductDateTypes");

            migrationBuilder.RenameTable(
                name: "ProductDateTypes",
                newName: "DateTypeDb");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DateTypeDb",
                table: "DateTypeDb",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDates_DateTypeDb_DateTypeId",
                table: "ProductDates",
                column: "DateTypeId",
                principalTable: "DateTypeDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
