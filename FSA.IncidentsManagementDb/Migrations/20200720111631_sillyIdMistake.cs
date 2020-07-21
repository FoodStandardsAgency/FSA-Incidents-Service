using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class sillyIdMistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "e-trader");

            migrationBuilder.UpdateData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Exporter");

            migrationBuilder.UpdateData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "Farmer");

            migrationBuilder.InsertData(
                table: "FBOTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hospitality/Food service" },
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Importer" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Manufacturer" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Packer/filler" },
                    { 512, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Processor" },
                    { 1024, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Producer" },
                    { 2048, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Retailer" },
                    { 4096, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Storage" },
                    { 8192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Supplier" },
                    { 16384, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Trader/Broker" },
                    { 32768, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Transporter" },
                    { 65536, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wholesaler" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 4096);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 8192);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 16384);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 32768);

            migrationBuilder.DeleteData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 65536);

            migrationBuilder.UpdateData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Exporter");

            migrationBuilder.UpdateData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Manufacturer");

            migrationBuilder.UpdateData(
                table: "FBOTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "Transporter");

            migrationBuilder.InsertData(
                table: "FBOTypes",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "e-trader" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Farmer" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Hospitality/Food service" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Importer" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Packer/filler" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Processor" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Producer" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Retailer" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Storage" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Supplier" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Trader/Broker" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wholesaler" }
                });
        }
    }
}
