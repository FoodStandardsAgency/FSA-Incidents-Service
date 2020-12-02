using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class onlineForm_Notfier_edits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnlineForms_HazardGroups_IncidentTypeId",
                table: "OnlineForms");

            migrationBuilder.DropIndex(
                name: "IX_OnlineForms_IncidentTypeId",
                table: "OnlineForms");

            migrationBuilder.DropColumn(
                name: "IncidentTypeId",
                table: "OnlineForms");

            migrationBuilder.DropColumn(
                name: "NotifierType",
                table: "OnlineForms");

            migrationBuilder.AddColumn<int>(
                name: "NotifierTypeId",
                table: "OnlineForms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OnlineFormReference",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Addresses",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "County",
                table: "Addresses",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Addresses",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Addresses",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.DropColumn(
                name: "OnlineFormReference",
                table: "Incidents");

            migrationBuilder.AddColumn<int>(
                name: "IncidentTypeId",
                table: "OnlineForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NotifierType",
                table: "OnlineForms",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "County",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OnlineForms_IncidentTypeId",
                table: "OnlineForms",
                column: "IncidentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineForms_HazardGroups_IncidentTypeId",
                table: "OnlineForms",
                column: "IncidentTypeId",
                principalTable: "HazardGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
