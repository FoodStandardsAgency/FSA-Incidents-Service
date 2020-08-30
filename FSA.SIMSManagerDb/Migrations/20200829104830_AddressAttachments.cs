using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class AddressAttachments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentAttachments_Incidents_IncidentId",
                table: "IncidentAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentStakeholders_Incidents_IncidentId",
                table: "IncidentStakeholders");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalAttachments_Signals_SignalId",
                table: "SignalAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalStakeholders_Signals_SignalId",
                table: "SignalStakeholders");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "SignalAttachments");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "IncidentAttachments");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentAttachments_Incidents_IncidentId",
                table: "IncidentAttachments",
                column: "IncidentId",
                principalTable: "Incidents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentStakeholders_Incidents_IncidentId",
                table: "IncidentStakeholders",
                column: "IncidentId",
                principalTable: "Incidents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalAttachments_Signals_SignalId",
                table: "SignalAttachments",
                column: "SignalId",
                principalTable: "Signals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalStakeholders_Signals_SignalId",
                table: "SignalStakeholders",
                column: "SignalId",
                principalTable: "Signals",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentAttachments_Incidents_IncidentId",
                table: "IncidentAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentStakeholders_Incidents_IncidentId",
                table: "IncidentStakeholders");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalAttachments_Signals_SignalId",
                table: "SignalAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalStakeholders_Signals_SignalId",
                table: "SignalStakeholders");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "SignalAttachments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "IncidentAttachments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentAttachments_Incidents_IncidentId",
                table: "IncidentAttachments",
                column: "IncidentId",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentStakeholders_Incidents_IncidentId",
                table: "IncidentStakeholders",
                column: "IncidentId",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalAttachments_Signals_SignalId",
                table: "SignalAttachments",
                column: "SignalId",
                principalTable: "Signals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalStakeholders_Signals_SignalId",
                table: "SignalStakeholders",
                column: "SignalId",
                principalTable: "Signals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
