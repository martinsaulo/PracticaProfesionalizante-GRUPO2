using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Back
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<Paso> Pasos { get; set; }
        public DbSet<IngredienteReceta> IngredientesReceta { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-FU6CNU8\\SQLEXPRESS;database=MiLibroDeRecetasBDD;trusted_connection=true;Encrypt=False");
        }
    }
}
