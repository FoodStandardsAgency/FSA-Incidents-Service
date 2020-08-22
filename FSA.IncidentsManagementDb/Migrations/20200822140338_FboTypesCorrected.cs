using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class FboTypesCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FBOTypeId",
                table: "ProductFBOItems");

            migrationBuilder.AddColumn<int>(
                name: "FboTypes",
                table: "ProductFBOItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FboTypes",
                table: "ProductFBOItems");

            migrationBuilder.AddColumn<int>(
                name: "FBOTypeId",
                table: "ProductFBOItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
