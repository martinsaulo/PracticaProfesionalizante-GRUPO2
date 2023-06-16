using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Clases
{
    public class IngredienteUnidad : Ingrediente
    {
        public int cantidadIngrediente { get; set; }
        public int caloriasUnidad { get; set; }

        public override int DevolverCalorias()
        {
            return cantidadIngrediente * caloriasUnidad;
        }

        public override string DevolverCantidad()
        {
            return cantidadIngrediente.ToString();
        }
    }
}
