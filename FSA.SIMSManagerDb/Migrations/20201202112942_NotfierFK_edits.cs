using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class NotfierFK_edits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnlineForms_NotifierTypes_NotifierTypeId",
                table: "OnlineForms");

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineForms_NotifierTypes_NotifierTypeId",
                table: "OnlineForms",
                column: "NotifierTypeId",
                principalTable: "NotifierTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnlineForms_NotifierTypes_NotifierTypeId",
                table: "OnlineForms");

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineForms_NotifierTypes_NotifierTypeId",
                table: "OnlineForms",
                column: "NotifierTypeId",
                principalTable: "NotifierTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
