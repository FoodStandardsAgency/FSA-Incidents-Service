using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class LinksFixer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignalLinks_Signals_FromId1",
                table: "SignalLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalLinks_Signals_ToId1",
                table: "SignalLinks");

            migrationBuilder.DropIndex(
                name: "IX_SignalLinks_FromId1",
                table: "SignalLinks");

            migrationBuilder.DropIndex(
                name: "IX_SignalLinks_ToId1",
                table: "SignalLinks");

            migrationBuilder.DropColumn(
                name: "FromId1",
                table: "SignalLinks");

            migrationBuilder.DropColumn(
                name: "ToId1",
                table: "SignalLinks");

            migrationBuilder.CreateIndex(
                name: "IX_SignalLinks_ToId",
                table: "SignalLinks",
                column: "ToId");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalLinks_Signals_FromId",
                table: "SignalLinks",
                column: "FromId",
                principalTable: "Signals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalLinks_Signals_ToId",
                table: "SignalLinks",
                column: "ToId",
                principalTable: "Signals",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignalLinks_Signals_FromId",
                table: "SignalLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_SignalLinks_Signals_ToId",
                table: "SignalLinks");

            migrationBuilder.DropIndex(
                name: "IX_SignalLinks_ToId",
                table: "SignalLinks");

            migrationBuilder.AddColumn<int>(
                name: "FromId1",
                table: "SignalLinks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToId1",
                table: "SignalLinks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SignalLinks_FromId1",
                table: "SignalLinks",
                column: "FromId1");

            migrationBuilder.CreateIndex(
                name: "IX_SignalLinks_ToId1",
                table: "SignalLinks",
                column: "ToId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalLinks_Signals_FromId1",
                table: "SignalLinks",
                column: "FromId1",
                principalTable: "Signals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SignalLinks_Signals_ToId1",
                table: "SignalLinks",
                column: "ToId1",
                principalTable: "Signals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
