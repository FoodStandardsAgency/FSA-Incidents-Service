using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class migrateToIncidentCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into incidentsCategoryjoin (incidentId, incidentCategoryId,ModifiedBy,CreatedBy)
                                select i.id, ic.id, '34b97e9d-eb28-444f-87cb-2c6311af8009',i.Createdby 
                                from [dbo].[HazardGroups] h inner join incidentCategories ic on lower(ic.title)=lower(h.title) 
                                inner join incidents i on i.incidentTypeid = h.id;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"delete from incidentscategoryjoin where EXISTS(
                                select incidentId, incidentCategoryId
                                from  incidentscategoryjoin ic 
                                inner join incidents i on i.id = ic.IncidentId
                                where i.IncidentTypeId <> 0)");
        }
    }
}
