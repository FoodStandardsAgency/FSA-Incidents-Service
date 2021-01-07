using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class seedNotifier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NotifierTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NotifierTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NotifierTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "NotifierTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Industry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NotifierTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Public individual");

            migrationBuilder.InsertData(
                table: "NotifierTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Retailer" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Manufacturer" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Undefined" }
                });
        }
    }
}
