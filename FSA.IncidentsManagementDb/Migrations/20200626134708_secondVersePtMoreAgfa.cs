using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class secondVersePtMoreAgfa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NotifierTypeDb",
                table: "NotifierTypeDb");

            migrationBuilder.RenameTable(
                name: "NotifierTypeDb",
                newName: "NotifierTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotifierTypes",
                table: "NotifierTypes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NotifierTypes",
                table: "NotifierTypes");

            migrationBuilder.RenameTable(
                name: "NotifierTypes",
                newName: "NotifierTypeDb");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotifierTypeDb",
                table: "NotifierTypeDb",
                column: "Id");
        }
    }
}
