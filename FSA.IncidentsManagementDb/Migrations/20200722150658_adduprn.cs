using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class adduprn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Uprn",
                table: "Organisations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uprn",
                table: "Organisations");
        }
    }
}
