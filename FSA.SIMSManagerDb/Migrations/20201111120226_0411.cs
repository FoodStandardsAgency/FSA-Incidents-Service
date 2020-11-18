using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class _0411 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Not Enough Information for Follow-Up");

            migrationBuilder.InsertData(
                table: "ClosedSignalReasons",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[] { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Not a food or feed safety issue" });

            migrationBuilder.UpdateData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "Incident Lead");

            migrationBuilder.UpdateData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 17,
                column: "Title",
                value: "Incident Support");

            migrationBuilder.UpdateData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Gallons (gal)");

            migrationBuilder.UpdateData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Grams (g)");

            migrationBuilder.UpdateData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "Kilograms (kg)");

            migrationBuilder.UpdateData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Title",
                value: "Litres (l)");

            migrationBuilder.UpdateData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 19,
                column: "Title",
                value: "Tonnes (t)");

            migrationBuilder.InsertData(
                table: "UnitQuantities",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Millilitres (ml)" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ounces (oz)" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pints (pt)" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Pounds (lb)" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Units" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "ClosedSignalReasons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Not Enough Information for  Follow-Up");

            migrationBuilder.UpdateData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "Incident Lead?");

            migrationBuilder.UpdateData(
                table: "StakeholderIncidentRoles",
                keyColumn: "Id",
                keyValue: 17,
                column: "Title",
                value: "Incident Support?");

            migrationBuilder.UpdateData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Gallons");

            migrationBuilder.UpdateData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Grams");

            migrationBuilder.UpdateData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "kg");

            migrationBuilder.UpdateData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Title",
                value: "Litres");

            migrationBuilder.UpdateData(
                table: "UnitQuantities",
                keyColumn: "Id",
                keyValue: 19,
                column: "Title",
                value: "tonnes");

            migrationBuilder.InsertData(
                table: "UnitQuantities",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ppt" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ppm" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "ppb" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "mSv" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "mg/litre" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "mg/kg" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/M3" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/M2" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/l" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bq/Kg" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "µSv" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "nSv" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "µg/kg" }
                });
        }
    }
}
