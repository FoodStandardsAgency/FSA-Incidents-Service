using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class sensitiveWidoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SensitiveInfo",
                table: "Signals",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SensitiveInfo",
                table: "Incidents",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SensitiveInfo",
                table: "Signals");

            migrationBuilder.DropColumn(
                name: "SensitiveInfo",
                table: "Incidents");
        }
    }
}
