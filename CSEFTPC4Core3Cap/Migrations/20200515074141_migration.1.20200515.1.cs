using Microsoft.EntityFrameworkCore.Migrations;

namespace CSEFTPC4Core3Cap.Migrations
{
    public partial class migration1202005151 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ac4yPersistentChilds");
        }
    }
}
