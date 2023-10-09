using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Usuario
    {
        public Usuario()
        {
            Recetas = new List<Receta>();
            Nombre = "";
            Contrasenia = "";
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public List<Receta> Recetas { get; set; }
    }
}
