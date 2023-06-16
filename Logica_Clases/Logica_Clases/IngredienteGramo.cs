using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Clases
{
    public class IngredienteGramo : Ingrediente
    {
        public int gramos { get; set; }
        public int caloriasGramo { get; set; }
        public override int DevolverCalorias()
        {
            return gramos * caloriasGramo;
        }
        public override string DevolverCantidad()
        {
            return gramos + "g";
        }
    }
}
