using Microsoft.EntityFrameworkCore.Migrations;

namespace PrihodkoCourse.Migrations
{
    public partial class Init_With_MedicamentsSubstitutes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StockQuantity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Substitutes",
                columns: table => new
                {
                    OriginalMedicamentId = table.Column<int>(nullable: false),
                    SubstituteMedicamentId = table.Column<int>(nullable: false),
                    DosageMultiplier = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substitutes", x => new { x.OriginalMedicamentId, x.SubstituteMedicamentId });
                    table.ForeignKey(
                        name: "FK_Substitutes_Medicaments_OriginalMedicamentId",
                        column: x => x.OriginalMedicamentId,
                        principalTable: "Medicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Substitutes_Medicaments_SubstituteMedicamentId",
                        column: x => x.SubstituteMedicamentId,
                        principalTable: "Medicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Substitutes_SubstituteMedicamentId",
                table: "Substitutes",
                column: "SubstituteMedicamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Substitutes");

            migrationBuilder.DropTable(
                name: "Medicaments");
        }
    }
}
