using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class Kevin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastChangedById",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "LastChangedDate",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "LastChangedById",
                table: "IncidentOMITGroups");

            migrationBuilder.DropColumn(
                name: "LastChangedDate",
                table: "IncidentOMITGroups");

            migrationBuilder.DropColumn(
                name: "IncidentProductId",
                table: "IncidentComments");

            migrationBuilder.DropColumn(
                name: "LastChangedBy",
                table: "IncidentComments");

            migrationBuilder.DropColumn(
                name: "LastChangedDate",
                table: "IncidentComments");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "IncidentOMITGroups",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "IncidentOMITGroups",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "IncidentOMITGroups",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "IncidentOMITGroups",
                nullable: false,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LastChangedById",
                table: "Organisations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangedDate",
                table: "Organisations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "IncidentOMITGroups",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "IncidentOMITGroups",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "IncidentOMITGroups",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "IncidentOMITGroups",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AddColumn<int>(
                name: "LastChangedById",
                table: "IncidentOMITGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangedDate",
                table: "IncidentOMITGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IncidentProductId",
                table: "IncidentComments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastChangedBy",
                table: "IncidentComments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangedDate",
                table: "IncidentComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
