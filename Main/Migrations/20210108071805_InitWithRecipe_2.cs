using Microsoft.EntityFrameworkCore.Migrations;

namespace PrihodkoCourse.Migrations
{
    public partial class InitWithRecipe_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Clients_ClientId",
                table: "Recipe");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Diseases_DiseaseId",
                table: "Recipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe");

            migrationBuilder.RenameTable(
                name: "Recipe",
                newName: "Recipes");

            migrationBuilder.RenameIndex(
                name: "IX_Recipe_DiseaseId",
                table: "Recipes",
                newName: "IX_Recipes_DiseaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Recipe_ClientId",
                table: "Recipes",
                newName: "IX_Recipes_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Clients_ClientId",
                table: "Recipes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Diseases_DiseaseId",
                table: "Recipes",
                column: "DiseaseId",
                principalTable: "Diseases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Clients_ClientId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Diseases_DiseaseId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.RenameTable(
                name: "Recipes",
                newName: "Recipe");

            migrationBuilder.RenameIndex(
                name: "IX_Recipes_DiseaseId",
                table: "Recipe",
                newName: "IX_Recipe_DiseaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Recipes_ClientId",
                table: "Recipe",
                newName: "IX_Recipe_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Clients_ClientId",
                table: "Recipe",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Diseases_DiseaseId",
                table: "Recipe",
                column: "DiseaseId",
                principalTable: "Diseases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
