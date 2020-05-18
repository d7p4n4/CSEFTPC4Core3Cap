using Microsoft.EntityFrameworkCore.Migrations;

namespace CSEFTPC4Core3Cap.Migrations
{
    public partial class migration1202005153 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "guid",
                table: "Ac4yPersistentChilds",
                newName: "GUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GUID",
                table: "Ac4yPersistentChilds",
                newName: "guid");
        }
    }
}
