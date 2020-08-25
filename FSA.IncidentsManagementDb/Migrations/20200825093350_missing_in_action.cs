using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class missing_in_action : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FBOs_Addresses_OrganisationId",
                table: "FBOs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFBOItems_FBOs_FBODbId",
                table: "ProductFBOItems");

            migrationBuilder.DropIndex(
                name: "IX_ProductFBOItems_FBODbId",
                table: "ProductFBOItems");

            migrationBuilder.DropIndex(
                name: "IX_FBOs_OrganisationId",
                table: "FBOs");

            migrationBuilder.DropColumn(
                name: "FBODbId",
                table: "ProductFBOItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FBODbId",
                table: "ProductFBOItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFBOItems_FBODbId",
                table: "ProductFBOItems",
                column: "FBODbId");

            migrationBuilder.CreateIndex(
                name: "IX_FBOs_OrganisationId",
                table: "FBOs",
                column: "OrganisationId");

            migrationBuilder.AddForeignKey(
                name: "FK_FBOs_Addresses_OrganisationId",
                table: "FBOs",
                column: "OrganisationId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFBOItems_FBOs_FBODbId",
                table: "ProductFBOItems",
                column: "FBODbId",
                principalTable: "FBOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
