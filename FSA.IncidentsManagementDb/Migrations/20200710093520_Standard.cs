using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class Standard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_DataSources_DataSourceId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DataSourceId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "ContactMethods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "DataSourceId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SignalUrl",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "SignalUrl",
                table: "Incidents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SignalUrl",
                table: "Incidents");

            migrationBuilder.AddColumn<int>(
                name: "DataSourceId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SignalUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ContactMethods",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[] { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Fax" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_DataSourceId",
                table: "Products",
                column: "DataSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_DataSources_DataSourceId",
                table: "Products",
                column: "DataSourceId",
                principalTable: "DataSources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
