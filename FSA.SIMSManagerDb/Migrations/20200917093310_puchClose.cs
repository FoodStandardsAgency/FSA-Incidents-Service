using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class puchClose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Food Policy Lead");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Imported Foods");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Food Industry Liason Group (FILG)");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Comms");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Referred to LA/PA for Information Only");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "Incident Team");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Czech Republic sampling");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Duplicate of...");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "FDA alert re US border rejection");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Japanese Import alert");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "No UK distribution");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "No useful information");

            migrationBuilder.InsertData(
                table: "ClosedSignalReasons",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RASFF notification" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Research on MySupermarket, Amazon and Google negative for distribution to the UK" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UK RASFF" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UK Govt. Quarterly Report" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UK Recall" }
                });
        }
    }
}
