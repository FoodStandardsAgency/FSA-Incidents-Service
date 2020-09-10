using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class closeSignalPt1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClosedSignalReasons",
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
                    table.PrimaryKey("PK_ClosedSignalReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClosedSignalTeams",
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
                    table.PrimaryKey("PK_ClosedSignalTeams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SignalClosedNoIncident",
                columns: table => new
                {
                    SignalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(nullable: false),
                    ReasonId = table.Column<int>(nullable: false),
                    UserReason = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalClosedNoIncident", x => x.SignalId);
                    table.ForeignKey(
                        name: "FK_SignalClosedNoIncident_ClosedSignalReasons_ReasonId",
                        column: x => x.ReasonId,
                        principalTable: "ClosedSignalReasons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignalClosedNoIncident_ClosedSignalTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "ClosedSignalTeams",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ClosedSignalReasons",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Czech Republic sampling" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Duplicate of..." },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FDA alert re US border rejection" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Japanese Import alert" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "No UK distribution" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "No useful information" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "RASFF notification" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Research on MySupermarket, Amazon and Google negative for distribution to the UK" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UK RASFF" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UK Govt. Quarterly Report" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "UK Recall" }
                });

            migrationBuilder.InsertData(
                table: "ClosedSignalTeams",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "NFCU" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Relevant Policy lead" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Imported foods" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SignalClosedNoIncident_ReasonId",
                table: "SignalClosedNoIncident",
                column: "ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SignalClosedNoIncident_TeamId",
                table: "SignalClosedNoIncident",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SignalClosedNoIncident");

            migrationBuilder.DropTable(
                name: "ClosedSignalReasons");

            migrationBuilder.DropTable(
                name: "ClosedSignalTeams");
        }
    }
}
