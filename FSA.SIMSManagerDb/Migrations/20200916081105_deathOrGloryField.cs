using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class deathOrGloryField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_DeathIllnesss_DeathIllnessId",
                table: "Incidents");

            migrationBuilder.AlterColumn<int>(
                name: "DeathIllnessId",
                table: "Incidents",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_DeathIllnesss_DeathIllnessId",
                table: "Incidents",
                column: "DeathIllnessId",
                principalTable: "DeathIllnesss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_DeathIllnesss_DeathIllnessId",
                table: "Incidents");

            migrationBuilder.AlterColumn<int>(
                name: "DeathIllnessId",
                table: "Incidents",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_DeathIllnesss_DeathIllnessId",
                table: "Incidents",
                column: "DeathIllnessId",
                principalTable: "DeathIllnesss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
