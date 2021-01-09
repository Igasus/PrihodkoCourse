using Microsoft.EntityFrameworkCore.Migrations;

namespace PrihodkoCourse.Migrations
{
    public partial class InitWithDiseaseMedicament_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiseaseMedicament_Diseases_DiseaseId",
                table: "DiseaseMedicament");

            migrationBuilder.DropForeignKey(
                name: "FK_DiseaseMedicament_Medicaments_MedicamentId",
                table: "DiseaseMedicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiseaseMedicament",
                table: "DiseaseMedicament");

            migrationBuilder.RenameTable(
                name: "DiseaseMedicament",
                newName: "DiseasesMedicaments");

            migrationBuilder.RenameIndex(
                name: "IX_DiseaseMedicament_MedicamentId",
                table: "DiseasesMedicaments",
                newName: "IX_DiseasesMedicaments_MedicamentId");

            migrationBuilder.RenameIndex(
                name: "IX_DiseaseMedicament_DiseaseId",
                table: "DiseasesMedicaments",
                newName: "IX_DiseasesMedicaments_DiseaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiseasesMedicaments",
                table: "DiseasesMedicaments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiseasesMedicaments_Diseases_DiseaseId",
                table: "DiseasesMedicaments",
                column: "DiseaseId",
                principalTable: "Diseases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiseasesMedicaments_Medicaments_MedicamentId",
                table: "DiseasesMedicaments",
                column: "MedicamentId",
                principalTable: "Medicaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiseasesMedicaments_Diseases_DiseaseId",
                table: "DiseasesMedicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_DiseasesMedicaments_Medicaments_MedicamentId",
                table: "DiseasesMedicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiseasesMedicaments",
                table: "DiseasesMedicaments");

            migrationBuilder.RenameTable(
                name: "DiseasesMedicaments",
                newName: "DiseaseMedicament");

            migrationBuilder.RenameIndex(
                name: "IX_DiseasesMedicaments_MedicamentId",
                table: "DiseaseMedicament",
                newName: "IX_DiseaseMedicament_MedicamentId");

            migrationBuilder.RenameIndex(
                name: "IX_DiseasesMedicaments_DiseaseId",
                table: "DiseaseMedicament",
                newName: "IX_DiseaseMedicament_DiseaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiseaseMedicament",
                table: "DiseaseMedicament",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiseaseMedicament_Diseases_DiseaseId",
                table: "DiseaseMedicament",
                column: "DiseaseId",
                principalTable: "Diseases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiseaseMedicament_Medicaments_MedicamentId",
                table: "DiseaseMedicament",
                column: "MedicamentId",
                principalTable: "Medicaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
