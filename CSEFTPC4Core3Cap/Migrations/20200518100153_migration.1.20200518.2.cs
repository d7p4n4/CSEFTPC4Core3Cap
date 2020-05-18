using Microsoft.EntityFrameworkCore.Migrations;

namespace CSEFTPC4Core3Cap.Migrations
{
    public partial class migration1202005182 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ac4yPersistentChilds_Ac4yIdentificationBase_Ac4YIdentificationId",
                table: "Ac4yPersistentChilds");

            migrationBuilder.RenameColumn(
                name: "Ac4YIdentificationId",
                table: "Ac4yPersistentChilds",
                newName: "Ac4yIdentificationId");

            migrationBuilder.RenameIndex(
                name: "IX_Ac4yPersistentChilds_Ac4YIdentificationId",
                table: "Ac4yPersistentChilds",
                newName: "IX_Ac4yPersistentChilds_Ac4yIdentificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ac4yPersistentChilds_Ac4yIdentificationBase_Ac4yIdentificationId",
                table: "Ac4yPersistentChilds",
                column: "Ac4yIdentificationId",
                principalTable: "Ac4yIdentificationBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ac4yPersistentChilds_Ac4yIdentificationBase_Ac4yIdentificationId",
                table: "Ac4yPersistentChilds");

            migrationBuilder.RenameColumn(
                name: "Ac4yIdentificationId",
                table: "Ac4yPersistentChilds",
                newName: "Ac4YIdentificationId");

            migrationBuilder.RenameIndex(
                name: "IX_Ac4yPersistentChilds_Ac4yIdentificationId",
                table: "Ac4yPersistentChilds",
                newName: "IX_Ac4yPersistentChilds_Ac4YIdentificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ac4yPersistentChilds_Ac4yIdentificationBase_Ac4YIdentificationId",
                table: "Ac4yPersistentChilds",
                column: "Ac4YIdentificationId",
                principalTable: "Ac4yIdentificationBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
