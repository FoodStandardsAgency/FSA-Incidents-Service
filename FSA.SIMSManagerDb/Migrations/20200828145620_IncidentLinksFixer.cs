using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class IncidentLinksFixer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentLinks_Incidents_FromId1",
                table: "IncidentLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentLinks_Incidents_ToId1",
                table: "IncidentLinks");

            migrationBuilder.DropIndex(
                name: "IX_IncidentLinks_FromId1",
                table: "IncidentLinks");

            migrationBuilder.DropIndex(
                name: "IX_IncidentLinks_ToId1",
                table: "IncidentLinks");

            migrationBuilder.DropColumn(
                name: "FromId1",
                table: "IncidentLinks");

            migrationBuilder.DropColumn(
                name: "ToId1",
                table: "IncidentLinks");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentLinks_ToId",
                table: "IncidentLinks",
                column: "ToId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentLinks_Incidents_FromId",
                table: "IncidentLinks",
                column: "FromId",
                principalTable: "Incidents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentLinks_Incidents_ToId",
                table: "IncidentLinks",
                column: "ToId",
                principalTable: "Incidents",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentLinks_Incidents_FromId",
                table: "IncidentLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentLinks_Incidents_ToId",
                table: "IncidentLinks");

            migrationBuilder.DropIndex(
                name: "IX_IncidentLinks_ToId",
                table: "IncidentLinks");

            migrationBuilder.AddColumn<int>(
                name: "FromId1",
                table: "IncidentLinks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToId1",
                table: "IncidentLinks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IncidentLinks_FromId1",
                table: "IncidentLinks",
                column: "FromId1");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentLinks_ToId1",
                table: "IncidentLinks",
                column: "ToId1");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentLinks_Incidents_FromId1",
                table: "IncidentLinks",
                column: "FromId1",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentLinks_Incidents_ToId1",
                table: "IncidentLinks",
                column: "ToId1",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
