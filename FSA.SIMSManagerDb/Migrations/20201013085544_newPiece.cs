using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class newPiece : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignalClosedNoIncident_ClosedSignalTeams_TeamId",
                table: "SignalClosedNoIncident");

            migrationBuilder.DropIndex(
                name: "IX_SignalClosedNoIncident_TeamId",
                table: "SignalClosedNoIncident");

            migrationBuilder.DeleteData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClosedSignalTeams",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "SignalClosedNoIncident");

            migrationBuilder.AddColumn<int>(
                name: "TeamIds",
                table: "SignalClosedNoIncident",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamIds",
                table: "SignalClosedNoIncident");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "SignalClosedNoIncident",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ClosedSignalTeams",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "National Food Crime Unit (NFCU)" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Policy lead" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Imported foods" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Food Industry Liasion Group (FILG)" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Comms" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Referred to LA/PA for Information only" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Team" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SignalClosedNoIncident_TeamId",
                table: "SignalClosedNoIncident",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_SignalClosedNoIncident_ClosedSignalTeams_TeamId",
                table: "SignalClosedNoIncident",
                column: "TeamId",
                principalTable: "ClosedSignalTeams",
                principalColumn: "Id");
        }
    }
}
