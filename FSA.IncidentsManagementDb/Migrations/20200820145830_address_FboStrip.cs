using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class address_FboStrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_FBOs_PrincipalFBOId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFBOItems_FBOs_FBOId",
                table: "ProductFBOItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFBOItems",
                table: "ProductFBOItems");

            migrationBuilder.DropIndex(
                name: "IX_ProductFBOItems_FBOId",
                table: "ProductFBOItems");

            migrationBuilder.DropColumn(
                name: "FBOId",
                table: "ProductFBOItems");

            migrationBuilder.DropColumn(
                name: "FBOTypeId",
                table: "FBOs");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "ProductFBOItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FBODbId",
                table: "ProductFBOItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FBOTypeId",
                table: "ProductFBOItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFBOItems",
                table: "ProductFBOItems",
                columns: new[] { "ProductId", "AddressId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFBOItems_AddressId",
                table: "ProductFBOItems",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFBOItems_FBODbId",
                table: "ProductFBOItems",
                column: "FBODbId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Addresses_PrincipalFBOId",
                table: "Incidents",
                column: "PrincipalFBOId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFBOItems_Addresses_AddressId",
                table: "ProductFBOItems",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFBOItems_FBOs_FBODbId",
                table: "ProductFBOItems",
                column: "FBODbId",
                principalTable: "FBOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Addresses_PrincipalFBOId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFBOItems_Addresses_AddressId",
                table: "ProductFBOItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFBOItems_FBOs_FBODbId",
                table: "ProductFBOItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFBOItems",
                table: "ProductFBOItems");

            migrationBuilder.DropIndex(
                name: "IX_ProductFBOItems_AddressId",
                table: "ProductFBOItems");

            migrationBuilder.DropIndex(
                name: "IX_ProductFBOItems_FBODbId",
                table: "ProductFBOItems");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "ProductFBOItems");

            migrationBuilder.DropColumn(
                name: "FBODbId",
                table: "ProductFBOItems");

            migrationBuilder.DropColumn(
                name: "FBOTypeId",
                table: "ProductFBOItems");

            migrationBuilder.AddColumn<int>(
                name: "FBOId",
                table: "ProductFBOItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FBOTypeId",
                table: "FBOs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFBOItems",
                table: "ProductFBOItems",
                columns: new[] { "ProductId", "FBOId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFBOItems_FBOId",
                table: "ProductFBOItems",
                column: "FBOId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_FBOs_PrincipalFBOId",
                table: "Incidents",
                column: "PrincipalFBOId",
                principalTable: "FBOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFBOItems_FBOs_FBOId",
                table: "ProductFBOItems",
                column: "FBOId",
                principalTable: "FBOs",
                principalColumn: "Id");
        }
    }
}
