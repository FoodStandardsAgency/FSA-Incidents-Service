using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class hoseB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Signals_SignalStatusId",
                table: "Signals");

            migrationBuilder.CreateIndex(
                name: "IX_Signals_SignalStatusId",
                table: "Signals",
                column: "SignalStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Signals_SignalStatusId",
                table: "Signals");

            migrationBuilder.CreateIndex(
                name: "IX_Signals_SignalStatusId",
                table: "Signals",
                column: "SignalStatusId",
                unique: true);
        }
    }
}
