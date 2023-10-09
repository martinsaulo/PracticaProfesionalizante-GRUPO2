using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class Migracion05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredientes_Recetas_RecetaId",
                table: "Ingredientes");

            migrationBuilder.DropIndex(
                name: "IX_Ingredientes_RecetaId",
                table: "Ingredientes");

            migrationBuilder.DropColumn(
                name: "RecetaId",
                table: "Ingredientes");

            migrationBuilder.AddColumn<int>(
                name: "RecetaId",
                table: "IngredientesReceta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesReceta_RecetaId",
                table: "IngredientesReceta",
                column: "RecetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientesReceta_Recetas_RecetaId",
                table: "IngredientesReceta",
                column: "RecetaId",
                principalTable: "Recetas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientesReceta_Recetas_RecetaId",
                table: "IngredientesReceta");

            migrationBuilder.DropIndex(
                name: "IX_IngredientesReceta_RecetaId",
                table: "IngredientesReceta");

            migrationBuilder.DropColumn(
                name: "RecetaId",
                table: "IngredientesReceta");

            migrationBuilder.AddColumn<int>(
                name: "RecetaId",
                table: "Ingredientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_RecetaId",
                table: "Ingredientes",
                column: "RecetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredientes_Recetas_RecetaId",
                table: "Ingredientes",
                column: "RecetaId",
                principalTable: "Recetas",
                principalColumn: "Id");
        }
    }
}
