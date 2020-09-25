using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class packageCloseSignalRedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "No UK distribution");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Duplicate Signal - Same Source");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Duplicate Signal - Different Source");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "RASFF - No UK Distribution");

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Not Enough Information for  Follow-Up");

            migrationBuilder.UpdateData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "National Food Crime Unit (NFCU)");

            migrationBuilder.UpdateData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Food Policy lead");

            migrationBuilder.InsertData(
                table: "ClosedSignalTeams",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Industry Liasion Group (FILG)" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Comms" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Referred to LA/PA for Information only" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Team" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 7);

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

            migrationBuilder.InsertData(
                table: "ClosedSignalReasons",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[] { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Team" });

            migrationBuilder.UpdateData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "NFCU");

            migrationBuilder.UpdateData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Relevant Policy lead");
        }
    }
}
