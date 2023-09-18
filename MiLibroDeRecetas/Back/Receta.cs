using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Receta
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public List<Etiqueta> Etiquetas { get; set; }
        public List<Paso> Pasos { get; set; }
        public int Calorias { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
    }
}
