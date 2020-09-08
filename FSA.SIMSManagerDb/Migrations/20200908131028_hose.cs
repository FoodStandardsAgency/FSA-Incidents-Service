using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class hose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "SignalStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "SortOrder",
                value: 100);

            migrationBuilder.UpdateData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "SortOrder",
                value: 200);

            migrationBuilder.UpdateData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "SortOrder",
                value: 400);

            migrationBuilder.UpdateData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "SortOrder",
                value: 500);

            migrationBuilder.InsertData(
                table: "SignalStatus",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "SortOrder", "Title" },
                values: new object[] { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", 300, "Pending" });

            migrationBuilder.CreateIndex(
                name: "IX_Signals_SignalStatusId",
                table: "Signals",
                column: "SignalStatusId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Signals_SignalStatus_SignalStatusId",
                table: "Signals",
                column: "SignalStatusId",
                principalTable: "SignalStatus",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Signals_SignalStatus_SignalStatusId",
                table: "Signals");

            migrationBuilder.DropIndex(
                name: "IX_Signals_SignalStatusId",
                table: "Signals");

            migrationBuilder.DeleteData(
                table: "SignalStatus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "SignalStatus");
        }
    }
}
