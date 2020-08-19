using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class incident_Description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncidentDescription",
                table: "Incidents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IncidentDescription",
                table: "Incidents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
