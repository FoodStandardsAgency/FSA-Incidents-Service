using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class yikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_NotifierDb_LeadLocalAuthorityId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_NotifierDb_NotifierId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_NotifierDb_NotifierTypes_NotifierTypeId",
                table: "NotifierDb");

            migrationBuilder.DropForeignKey(
                name: "FK_NotifierDb_Organisations_OrganisationId",
                table: "NotifierDb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotifierDb",
                table: "NotifierDb");

            migrationBuilder.RenameTable(
                name: "NotifierDb",
                newName: "Notifiers");

            migrationBuilder.RenameIndex(
                name: "IX_NotifierDb_OrganisationId",
                table: "Notifiers",
                newName: "IX_Notifiers_OrganisationId");

            migrationBuilder.RenameIndex(
                name: "IX_NotifierDb_NotifierTypeId",
                table: "Notifiers",
                newName: "IX_Notifiers_NotifierTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "NotifierTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Notifiers",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Notifiers",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Notifiers",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Notifiers",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifiers",
                table: "Notifiers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Notifiers_LeadLocalAuthorityId",
                table: "Incidents",
                column: "LeadLocalAuthorityId",
                principalTable: "Notifiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Notifiers_NotifierId",
                table: "Incidents",
                column: "NotifierId",
                principalTable: "Notifiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifiers_NotifierTypes_NotifierTypeId",
                table: "Notifiers",
                column: "NotifierTypeId",
                principalTable: "NotifierTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifiers_Organisations_OrganisationId",
                table: "Notifiers",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Notifiers_LeadLocalAuthorityId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Notifiers_NotifierId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifiers_NotifierTypes_NotifierTypeId",
                table: "Notifiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifiers_Organisations_OrganisationId",
                table: "Notifiers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifiers",
                table: "Notifiers");

            migrationBuilder.RenameTable(
                name: "Notifiers",
                newName: "NotifierDb");

            migrationBuilder.RenameIndex(
                name: "IX_Notifiers_OrganisationId",
                table: "NotifierDb",
                newName: "IX_NotifierDb_OrganisationId");

            migrationBuilder.RenameIndex(
                name: "IX_Notifiers_NotifierTypeId",
                table: "NotifierDb",
                newName: "IX_NotifierDb_NotifierTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "NotifierTypes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "NotifierDb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "NotifierDb",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "NotifierDb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "NotifierDb",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotifierDb",
                table: "NotifierDb",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_NotifierDb_LeadLocalAuthorityId",
                table: "Incidents",
                column: "LeadLocalAuthorityId",
                principalTable: "NotifierDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_NotifierDb_NotifierId",
                table: "Incidents",
                column: "NotifierId",
                principalTable: "NotifierDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NotifierDb_NotifierTypes_NotifierTypeId",
                table: "NotifierDb",
                column: "NotifierTypeId",
                principalTable: "NotifierTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotifierDb_Organisations_OrganisationId",
                table: "NotifierDb",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
