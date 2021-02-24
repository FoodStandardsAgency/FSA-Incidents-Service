using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class noteTags_FinalList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 8192);

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Closure Reason");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Distribution Information");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Export/Import");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Food Standards Scotland");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "FSA Alert");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 32,
                column: "Title",
                value: "FSA England");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 64,
                column: "Title",
                value: "FSA Northern Ireland");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 128,
                column: "Title",
                value: "FSA Wales");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 256,
                column: "Title",
                value: "Internal Correspondence");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 512,
                column: "Title",
                value: "IRF / Supplementary Information");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 1024,
                column: "Title",
                value: "Link Reason");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 2048,
                column: "Title",
                value: "Product Details");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 4096,
                column: "Title",
                value: "Risk Assessment and Management");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "CVED/CED");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Analytical report");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Bill / Delivery Document");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Follow up notification");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "Health certifiacte");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 32,
                column: "Title",
                value: "Phytosanitary Certifcate");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 64,
                column: "Title",
                value: "Picture");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 128,
                column: "Title",
                value: "Public warning / Press release");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 256,
                column: "Title",
                value: "Recipients List");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 512,
                column: "Title",
                value: "Risk assessment");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 1024,
                column: "Title",
                value: "Screenshot");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 2048,
                column: "Title",
                value: "Translation");

            migrationBuilder.UpdateData(
                table: "NoteTags",
                keyColumn: "Id",
                keyValue: 4096,
                column: "Title",
                value: "Video File");

            migrationBuilder.InsertData(
                table: "NoteTags",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[] { 8192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" });
        }
    }
}
