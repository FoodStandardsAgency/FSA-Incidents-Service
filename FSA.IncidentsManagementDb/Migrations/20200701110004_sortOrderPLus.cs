using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class sortOrderPLus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SortOrder",
                table: "IncidentStatus",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "SortOrder",
                value: 200);

            migrationBuilder.UpdateData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "SortOrder",
                value: 100);

            migrationBuilder.UpdateData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "SortOrder",
                value: 500);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SortOrder",
                table: "IncidentStatus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "SortOrder",
                value: null);

            migrationBuilder.UpdateData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "SortOrder",
                value: null);

            migrationBuilder.UpdateData(
                table: "IncidentStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "SortOrder",
                value: null);
        }
    }
}
