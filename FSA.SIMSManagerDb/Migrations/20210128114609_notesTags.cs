using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class notesTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagFlags",
                table: "SignalNotes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagFlags",
                table: "OnlineFormNotes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagFlags",
                table: "IncidentNotes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NoteTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteTags", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ClosedSignalReasons",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RASFF - Confirmed UK Distribution" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Historic Signal" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Known Issue" }
                });

            migrationBuilder.InsertData(
                table: "NoteTags",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 2048, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Translation" },
                    { 1024, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Screenshot" },
                    { 512, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk assessment" },
                    { 256, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Recipients List" },
                    { 128, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Public warning / Press release" },
                    { 64, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Picture" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Phytosanitary Certifcate" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Health certifiacte" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Follow up notification" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Bill / Delivery Document" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Analytical report" },
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "CVED/CED" },
                    { 4096, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Video File" },
                    { 8192, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Other" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NoteTags");

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

            migrationBuilder.DropColumn(
                name: "TagFlags",
                table: "SignalNotes");

            migrationBuilder.DropColumn(
                name: "TagFlags",
                table: "OnlineFormNotes");

            migrationBuilder.DropColumn(
                name: "TagFlags",
                table: "IncidentNotes");
        }
    }
}
