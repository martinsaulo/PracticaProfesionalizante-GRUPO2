using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Clases
{
    public class Receta
    {
        public int idReceta { get; set; }
        public string nombreReceta { get; set; }
        public string descripcionReceta { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime ultimaModificacion { get; set; }
        public int caloriasTotales { get; set; }
        public List<Etiqueta> listaEtiquetas { get; set; } = new List<Etiqueta>();
        public List<Ingrediente> listaIngredientes { get; set; }

        public int CalcularCalorias() { return 0; }
    }
}
