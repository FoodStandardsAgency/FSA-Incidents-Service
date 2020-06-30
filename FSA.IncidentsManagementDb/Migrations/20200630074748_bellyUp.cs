using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class bellyUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Organisations_LeadLocalAuthorityId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Organisations_NotifierId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Organisations_PrincipalFBOId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_UnitQuantities_AmountUnitTypeIdId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Incidents_IncidentId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AmountUnitTypeIdId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AmountUnitType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AmountUnitTypeIdId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "AmountUnitTypeId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "NotifierTypes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PriorityId",
                table: "Incidents",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IncidentStatusId",
                table: "Incidents",
                nullable: false,
                defaultValue: 4,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "NotifierDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    NotifierTypeId = table.Column<int>(nullable: false),
                    OrganisationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifierDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotifierDb_NotifierTypes_NotifierTypeId",
                        column: x => x.NotifierTypeId,
                        principalTable: "NotifierTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotifierDb_Organisations_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "TBC");

            migrationBuilder.InsertData(
                table: "IncidentStatus",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[] { 4, "Paul", "Paul", "Unassigned" });

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "TBC");

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "High");

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Low");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AmountUnitTypeId",
                table: "Products",
                column: "AmountUnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NotifierDb_NotifierTypeId",
                table: "NotifierDb",
                column: "NotifierTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NotifierDb_OrganisationId",
                table: "NotifierDb",
                column: "OrganisationId");

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
                name: "FK_Incidents_FBOs_PrincipalFBOId",
                table: "Incidents",
                column: "PrincipalFBOId",
                principalTable: "FBOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UnitQuantities_AmountUnitTypeId",
                table: "Products",
                column: "AmountUnitTypeId",
                principalTable: "UnitQuantities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Incidents_IncidentId",
                table: "Products",
                column: "IncidentId",
                principalTable: "Incidents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_NotifierDb_LeadLocalAuthorityId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_NotifierDb_NotifierId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_FBOs_PrincipalFBOId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_UnitQuantities_AmountUnitTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Incidents_IncidentId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "NotifierDb");

            migrationBuilder.DropIndex(
                name: "IX_Products_AmountUnitTypeId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "AmountUnitTypeId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "AmountUnitType",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountUnitTypeIdId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "NotifierTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "PriorityId",
                table: "Incidents",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "IncidentStatusId",
                table: "Incidents",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 4);

            migrationBuilder.UpdateData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "No wait!");

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Unclassified");

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Low");

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "High");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AmountUnitTypeIdId",
                table: "Products",
                column: "AmountUnitTypeIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Organisations_LeadLocalAuthorityId",
                table: "Incidents",
                column: "LeadLocalAuthorityId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Organisations_NotifierId",
                table: "Incidents",
                column: "NotifierId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Organisations_PrincipalFBOId",
                table: "Incidents",
                column: "PrincipalFBOId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UnitQuantities_AmountUnitTypeIdId",
                table: "Products",
                column: "AmountUnitTypeIdId",
                principalTable: "UnitQuantities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Incidents_IncidentId",
                table: "Products",
                column: "IncidentId",
                principalTable: "Incidents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
