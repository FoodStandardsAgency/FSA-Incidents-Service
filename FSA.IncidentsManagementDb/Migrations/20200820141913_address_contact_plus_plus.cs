using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class address_contact_plus_plus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Stakeholders");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Stakeholders",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstNameDept",
                table: "Stakeholders",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstNameDept",
                table: "Stakeholders");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Stakeholders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Stakeholders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
