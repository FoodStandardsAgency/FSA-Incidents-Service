using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class RahRah : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastChangedById",
                table: "IncidentIncidentLinks");

            migrationBuilder.DropColumn(
                name: "LastChangedDate",
                table: "IncidentIncidentLinks");

            migrationBuilder.AddColumn<string>(
                name: "FaxAddress",
                table: "Organisations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainContact",
                table: "Organisations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactMethodId",
                table: "Incidents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Incidents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Incidents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "IncidentIncidentLinks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "IncidentIncidentLinks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "IncidentIncidentLinks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "IncidentIncidentLinks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaxAddress",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "MainContact",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "ContactMethodId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "IncidentIncidentLinks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "IncidentIncidentLinks");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "IncidentIncidentLinks");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "IncidentIncidentLinks");

            migrationBuilder.AddColumn<int>(
                name: "LastChangedById",
                table: "IncidentIncidentLinks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangedDate",
                table: "IncidentIncidentLinks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
