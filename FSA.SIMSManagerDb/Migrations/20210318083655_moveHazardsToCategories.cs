using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class moveHazardsToCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into IncidentsCategoryJoin(IncidentId, IncidentCategoryId,ModifiedBy,CreatedBy)
                                      SELECT id, IncidentTypeId-35, '34b97e9d-eb28-444f-87cb-2c6311af8009',Createdby from incidents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"delete from IncidentsCategoryJoin Where EXISTS(
                                        select IncidentId, IncidentCategoryId from IncidentsCategoryJoin icj
                                        inner join incidents i on i.Id = icj.IncidentId 
                                        and i.IncidentTypeId = icj.IncidentCategoryId+35)");

        }
    }
}
