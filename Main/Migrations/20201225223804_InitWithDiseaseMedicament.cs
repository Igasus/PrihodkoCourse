using Microsoft.EntityFrameworkCore.Migrations;

namespace PrihodkoCourse.Migrations
{
    public partial class InitWithDiseaseMedicament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiseaseMedicament",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseId = table.Column<int>(nullable: false),
                    MedicamentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseMedicament", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiseaseMedicament_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseMedicament_Medicaments_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "Medicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseMedicament_DiseaseId",
                table: "DiseaseMedicament",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseMedicament_MedicamentId",
                table: "DiseaseMedicament",
                column: "MedicamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseaseMedicament");
        }
    }
}
