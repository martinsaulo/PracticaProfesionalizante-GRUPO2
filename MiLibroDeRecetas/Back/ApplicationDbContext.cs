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
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<Paso> Pasos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GABRIEL\\SQLEXPRESS;database=PruebaEF;trusted_connection=true;Encrypt=False");
        }
    }
}
