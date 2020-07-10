using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class OhBoy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "UnitQuantities",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "SignalStatus",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ProductTypes",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Products",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ProductPackSizes",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ProductFBOItems",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ProductDateTypes",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ProductDates",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Priorities",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "PersonaRoles",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Organisations",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "OrganisationRoles",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "OMITGroups",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "NotifierTypes",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Notifiers",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "IncidentStatus",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Incidents",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "IncidentOMITGroups",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "IncidentLinks",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "IncidentComments",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "FBOTypes",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "FBOs",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "DeathIllnesss",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "DataSources",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Countries",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ContactMethods",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Classifications",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Categories",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "BatchCodes",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "AdminLeads",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "UnitQuantities");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "SignalStatus");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ProductPackSizes");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ProductFBOItems");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ProductDateTypes");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ProductDates");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Priorities");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "PersonaRoles");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "OrganisationRoles");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "OMITGroups");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "NotifierTypes");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Notifiers");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "IncidentStatus");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "IncidentOMITGroups");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "IncidentLinks");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "IncidentComments");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "FBOTypes");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "FBOs");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "DeathIllnesss");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "DataSources");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ContactMethods");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Classifications");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "BatchCodes");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "AdminLeads");
        }
    }
}
