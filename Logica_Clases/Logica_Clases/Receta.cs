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
        public List<Etiqueta> listaEtiquetas { get; set; }
        public List<Ingrediente> listaIngredientes { get; set; }
        public List<string> listaPasos { get; set; }

        public int CalcularCalorias() 
        {
            int calorias = 0;
            foreach(var x in listaIngredientes)
            {
                calorias += x.caloriasIngrediente; // Ver
            }
            return 0;
        }

        public Receta
            (string nombre, string descripcion, List<Etiqueta> listaEtiquetas_,
            List<Ingrediente> listaIngredientes_, List<string> listaPasos_) 
        {
            nombreReceta = nombre;
            descripcionReceta = descripcion;
            fechaCreacion = DateTime.Now;
            ultimaModificacion = DateTime.Now;
            caloriasTotales = CalcularCalorias();
            listaEtiquetas = listaEtiquetas_;
            listaIngredientes = listaIngredientes_;
            listaPasos = listaPasos_;

        }
    }
}
