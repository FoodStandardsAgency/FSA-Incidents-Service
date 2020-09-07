using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class statusIdPtOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignalStatus_SignalStatus_ParentId",
                table: "SignalStatus");

            migrationBuilder.DropIndex(
                name: "IX_SignalStatus_ParentId",
                table: "SignalStatus");

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "IsOpen",
                table: "SignalStatus");

            migrationBuilder.DropColumn(
                name: "IsUnassigned",
                table: "SignalStatus");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "SignalStatus");

            migrationBuilder.DropColumn(
                name: "SignalStatus",
                table: "Signals");

            migrationBuilder.AddColumn<int>(
                name: "SignalStatusId",
                table: "Signals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Closed : Incident");

            migrationBuilder.UpdateData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Closed : No Incident");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SignalStatusId",
                table: "Signals");

            migrationBuilder.AddColumn<bool>(
                name: "IsOpen",
                table: "SignalStatus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsUnassigned",
                table: "SignalStatus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "SignalStatus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SignalStatus",
                table: "Signals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Closed");

            migrationBuilder.UpdateData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Duplicate");

            migrationBuilder.InsertData(
                table: "SignalStatus",
                columns: new[] { "Id", "CreatedBy", "IsOpen", "IsUnassigned", "ModifiedBy", "ParentId", "Title" },
                values: new object[,]
                {
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Rejected" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Converted to Incident" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Associated to Incident" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Converted to Signal" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Associated to Signal" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", false, false, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", null, "Merged to Incident" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SignalStatus_ParentId",
                table: "SignalStatus",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalStatus_SignalStatus_ParentId",
                table: "SignalStatus",
                column: "ParentId",
                principalTable: "SignalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
