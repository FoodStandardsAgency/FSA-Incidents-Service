using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class removemAINcontact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainContact",
                table: "Addresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainContact",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
