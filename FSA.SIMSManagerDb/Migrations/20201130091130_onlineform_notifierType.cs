using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class onlineform_notifierType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotifierType",
                table: "OnlineForms");

            migrationBuilder.AddColumn<int>(
                name: "NotifierTypeId",
                table: "OnlineForms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OnlineForms_NotifierTypeId",
                table: "OnlineForms",
                column: "NotifierTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineForms_NotifierTypes_NotifierTypeId",
                table: "OnlineForms",
                column: "NotifierTypeId",
                principalTable: "NotifierTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnlineForms_NotifierTypes_NotifierTypeId",
                table: "OnlineForms");

            migrationBuilder.DropIndex(
                name: "IX_OnlineForms_NotifierTypeId",
                table: "OnlineForms");

            migrationBuilder.DropColumn(
                name: "NotifierTypeId",
                table: "OnlineForms");

            migrationBuilder.AddColumn<string>(
                name: "NotifierType",
                table: "OnlineForms",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }
    }
}
