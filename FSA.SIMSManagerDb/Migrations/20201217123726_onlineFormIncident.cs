using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class onlineFormIncident : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnlineFormReference",
                table: "Incidents");

            migrationBuilder.AddColumn<int>(
                name: "OnlineFormId",
                table: "Incidents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OnlineForms_ReferenceNo",
                table: "OnlineForms",
                column: "ReferenceNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OnlineForms_ReferenceNo",
                table: "OnlineForms");

            migrationBuilder.DropColumn(
                name: "OnlineFormId",
                table: "Incidents");

            migrationBuilder.AddColumn<string>(
                name: "OnlineFormReference",
                table: "Incidents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
