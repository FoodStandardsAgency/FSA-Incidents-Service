using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class removeIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Countrys",
                table: "Countrys");

            migrationBuilder.DropColumn(
                name: "AdminLeadId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "FieldOfficerId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "LastChangedById",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "LastChangedDate",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "LeadOfficerId",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "_reserved_importref",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "LastChangedById",
                table: "IncidentComments");

            migrationBuilder.RenameTable(
                name: "Countrys",
                newName: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "AdminLead",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FieldOfficer",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeadOfficer",
                table: "Incidents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastChangedBy",
                table: "IncidentComments",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "AdminLead",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "FieldOfficer",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "LeadOfficer",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "LastChangedBy",
                table: "IncidentComments");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Countrys");

            migrationBuilder.AddColumn<int>(
                name: "AdminLeadId",
                table: "Incidents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FieldOfficerId",
                table: "Incidents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastChangedById",
                table: "Incidents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangedDate",
                table: "Incidents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LeadOfficerId",
                table: "Incidents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_reserved_importref",
                table: "Incidents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastChangedById",
                table: "IncidentComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countrys",
                table: "Countrys",
                column: "Id");
        }
    }
}
