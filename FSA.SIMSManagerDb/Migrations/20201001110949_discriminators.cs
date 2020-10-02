using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class discriminators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId",
                table: "IncidentStakeholders");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId",
                table: "SignalStakeholders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StakeholderDiscriminatorDb",
                table: "StakeholderDiscriminatorDb");

            migrationBuilder.RenameTable(
                name: "StakeholderDiscriminatorDb",
                newName: "StakeholderDiscriminators");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StakeholderDiscriminators",
                table: "StakeholderDiscriminators",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId",
                table: "IncidentStakeholders",
                column: "StakeholderDiscriminatorId",
                principalTable: "StakeholderDiscriminators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId",
                table: "SignalStakeholders",
                column: "StakeholderDiscriminatorId",
                principalTable: "StakeholderDiscriminators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncidentStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId",
                table: "IncidentStakeholders");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId",
                table: "SignalStakeholders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StakeholderDiscriminators",
                table: "StakeholderDiscriminators");

            migrationBuilder.RenameTable(
                name: "StakeholderDiscriminators",
                newName: "StakeholderDiscriminatorDb");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StakeholderDiscriminatorDb",
                table: "StakeholderDiscriminatorDb",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId",
                table: "IncidentStakeholders",
                column: "StakeholderDiscriminatorId",
                principalTable: "StakeholderDiscriminatorDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalStakeholders_StakeholderDiscriminatorDb_StakeholderDiscriminatorId",
                table: "SignalStakeholders",
                column: "StakeholderDiscriminatorId",
                principalTable: "StakeholderDiscriminatorDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
