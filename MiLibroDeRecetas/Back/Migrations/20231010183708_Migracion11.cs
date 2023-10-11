using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class Migracion11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etiquetas_Recetas_RecetaId",
                table: "Etiquetas");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientesReceta_Ingredientes_Ingrediente_Id",
                table: "IngredientesReceta");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientesReceta_Recetas_RecetaId",
                table: "IngredientesReceta");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasos_Recetas_RecetaId",
                table: "Pasos");

            migrationBuilder.DropForeignKey(
                name: "FK_Recetas_Usuarios_UsuarioId",
                table: "Recetas");

            migrationBuilder.DropIndex(
                name: "IX_Etiquetas_RecetaId",
                table: "Etiquetas");

            migrationBuilder.DropColumn(
                name: "RecetaId",
                table: "Etiquetas");

            migrationBuilder.RenameColumn(
                name: "Ingrediente_Id",
                table: "IngredientesReceta",
                newName: "IngredienteId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientesReceta_Ingrediente_Id",
                table: "IngredientesReceta",
                newName: "IX_IngredientesReceta_IngredienteId");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Recetas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RecetaId",
                table: "Pasos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RecetaId",
                table: "IngredientesReceta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EtiquetasRecetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecetaId = table.Column<int>(type: "int", nullable: false),
                    EtiquetaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtiquetasRecetas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EtiquetasRecetas_Etiquetas_EtiquetaId",
                        column: x => x.EtiquetaId,
                        principalTable: "Etiquetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EtiquetasRecetas_Recetas_RecetaId",
                        column: x => x.RecetaId,
                        principalTable: "Recetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EtiquetasRecetas_EtiquetaId",
                table: "EtiquetasRecetas",
                column: "EtiquetaId");

            migrationBuilder.CreateIndex(
                name: "IX_EtiquetasRecetas_RecetaId",
                table: "EtiquetasRecetas",
                column: "RecetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientesReceta_Ingredientes_IngredienteId",
                table: "IngredientesReceta",
                column: "IngredienteId",
                principalTable: "Ingredientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientesReceta_Recetas_RecetaId",
                table: "IngredientesReceta",
                column: "RecetaId",
                principalTable: "Recetas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pasos_Recetas_RecetaId",
                table: "Pasos",
                column: "RecetaId",
                principalTable: "Recetas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recetas_Usuarios_UsuarioId",
                table: "Recetas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientesReceta_Ingredientes_IngredienteId",
                table: "IngredientesReceta");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientesReceta_Recetas_RecetaId",
                table: "IngredientesReceta");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasos_Recetas_RecetaId",
                table: "Pasos");

            migrationBuilder.DropForeignKey(
                name: "FK_Recetas_Usuarios_UsuarioId",
                table: "Recetas");

            migrationBuilder.DropTable(
                name: "EtiquetasRecetas");

            migrationBuilder.RenameColumn(
                name: "IngredienteId",
                table: "IngredientesReceta",
                newName: "Ingrediente_Id");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientesReceta_IngredienteId",
                table: "IngredientesReceta",
                newName: "IX_IngredientesReceta_Ingrediente_Id");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Recetas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RecetaId",
                table: "Pasos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RecetaId",
                table: "IngredientesReceta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RecetaId",
                table: "Etiquetas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Etiquetas_RecetaId",
                table: "Etiquetas",
                column: "RecetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etiquetas_Recetas_RecetaId",
                table: "Etiquetas",
                column: "RecetaId",
                principalTable: "Recetas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientesReceta_Ingredientes_Ingrediente_Id",
                table: "IngredientesReceta",
                column: "Ingrediente_Id",
                principalTable: "Ingredientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientesReceta_Recetas_RecetaId",
                table: "IngredientesReceta",
                column: "RecetaId",
                principalTable: "Recetas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasos_Recetas_RecetaId",
                table: "Pasos",
                column: "RecetaId",
                principalTable: "Recetas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recetas_Usuarios_UsuarioId",
                table: "Recetas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
