using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Clases
{
    public abstract class Ingrediente
    {
        public string nombreIngrediente { get; set; }
        public int idIngrediente { get; set; }

        public abstract int DevolverCalorias();
        public abstract string DevolverCantidad();
    }
}
