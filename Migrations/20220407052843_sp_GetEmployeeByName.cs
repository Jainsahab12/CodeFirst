using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class sp_GetEmployeeByName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                        var sp = @"CREATE PROCEDURE [dbo].[sp_GetEmployeeByName] 
             -- Add the parameters for the stored procedure here
             @emp_name varchar(40)
            AS
            BEGIN
            -- SET NOCOUNT ON added to prevent extra result sets from
             -- interfering with SELECT statements.
             SET NOCOUNT ON;
             -- Insert statements for procedure here
             SELECT ID, Code, FirstName, LastName, Email, Mobile, DOJ, 
            DepartmentId from Employees 
             where FirstName like '%' + @emp_name + '%' 
            or LastName like '%' + @emp_name + '%'
            END";
                        migrationBuilder.Sql(sp);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
