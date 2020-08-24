using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.IncidentsManagementDb.Migrations
{
    public partial class skatehgoldeRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StakeholderIncidentRoles",
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
                    table.PrimaryKey("PK_StakeholderIncidentRoles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StakeholderIncidentRoles",
                columns: new[] { "Id", "CreatedBy", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { 1, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Briefing Cell" },
                    { 21, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy Lead - FSA" },
                    { 22, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy Lead - Other Government Department" },
                    { 23, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Strategic Incident Oversight Group (SIOG)" },
                    { 24, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chair, SIOG" },
                    { 25, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Strategic Advisior" },
                    { 26, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Strategic Director" },
                    { 27, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Dairy Inspector" },
                    { 28, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Field Operations - FVC" },
                    { 29, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Field Operations - FVL" },
                    { 30, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSA Business Assurance Auditors" },
                    { 31, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Meat Hygiene Inspector" },
                    { 32, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Poultry Hygiene Inspector" },
                    { 33, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Wine Inspector" },
                    { 34, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Receipt & Management  (RAM) Lead" },
                    { 35, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Stakeholder  Engagement  (SHE) Lead" },
                    { 20, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Chair, IMCG" },
                    { 36, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Receipt & Management (RAM ) Officer" },
                    { 19, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Management Co-ordination Group (IMCG)" },
                    { 17, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Support?" },
                    { 2, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Briefing Cell Manager" },
                    { 3, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Situation Report (SITREP) Lead" },
                    { 4, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Q&A lead" },
                    { 5, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Official Note Taker" },
                    { 6, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Communications Lead" },
                    { 7, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Press Officer" },
                    { 8, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Legal Advisior" },
                    { 9, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Admin Support" },
                    { 10, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Policy/Science Lead" },
                    { 11, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Ministerial Submission Lead" },
                    { 12, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "FSS/FSA Liason" },
                    { 13, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk Manager" },
                    { 14, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Risk Assesor" },
                    { 15, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Manager" },
                    { 16, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Incident Lead?" },
                    { 18, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Operational Incident Management Team (OIMT)" },
                    { 37, "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", "Stakeholder Engagement (SHE) Officer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StakeholderIncidentRoles");
        }
    }
}
