using Microsoft.EntityFrameworkCore.Migrations;

namespace PrihodkoCourse.Migrations
{
    public partial class InitWithDosage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dosages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseMedicamentId = table.Column<int>(nullable: false),
                    MinAge = table.Column<int>(nullable: false),
                    Dose = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dosages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dosages_DiseasesMedicaments_DiseaseMedicamentId",
                        column: x => x.DiseaseMedicamentId,
                        principalTable: "DiseasesMedicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dosages_DiseaseMedicamentId",
                table: "Dosages",
                column: "DiseaseMedicamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dosages");
        }
    }
}
