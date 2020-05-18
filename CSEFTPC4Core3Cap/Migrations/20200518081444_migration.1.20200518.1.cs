using Microsoft.EntityFrameworkCore.Migrations;

namespace CSEFTPC4Core3Cap.Migrations
{
    public partial class migration1202005181 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ac4YIdentificationId",
                table: "Ac4yPersistentChilds",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ac4yIdentificationBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    humanId = table.Column<string>(nullable: true),
                    publicHumanId = table.Column<string>(nullable: true),
                    createdAt = table.Column<string>(nullable: true),
                    updatedAt = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    ac4yIdentificationBaseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ac4yIdentificationBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ac4yIdentificationBase_Ac4yIdentificationBase_ac4yIdentificationBaseId",
                        column: x => x.ac4yIdentificationBaseId,
                        principalTable: "Ac4yIdentificationBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ac4yPersistentChilds_Ac4YIdentificationId",
                table: "Ac4yPersistentChilds",
                column: "Ac4YIdentificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Ac4yIdentificationBase_ac4yIdentificationBaseId",
                table: "Ac4yIdentificationBase",
                column: "ac4yIdentificationBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ac4yPersistentChilds_Ac4yIdentificationBase_Ac4YIdentificationId",
                table: "Ac4yPersistentChilds",
                column: "Ac4YIdentificationId",
                principalTable: "Ac4yIdentificationBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ac4yPersistentChilds_Ac4yIdentificationBase_Ac4YIdentificationId",
                table: "Ac4yPersistentChilds");

            migrationBuilder.DropTable(
                name: "Ac4yIdentificationBase");

            migrationBuilder.DropIndex(
                name: "IX_Ac4yPersistentChilds_Ac4YIdentificationId",
                table: "Ac4yPersistentChilds");

            migrationBuilder.DropColumn(
                name: "Ac4YIdentificationId",
                table: "Ac4yPersistentChilds");
        }
    }
}
