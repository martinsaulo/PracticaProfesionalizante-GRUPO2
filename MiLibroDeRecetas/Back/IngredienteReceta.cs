using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class IngredienteReceta
    {
        public int Id { get; set; }
        public Ingrediente Ingrediente_ {  get; set; }
        public int Cantidad { get; set; }

        public int DevolverCalorias() {
            return Cantidad * Ingrediente_.Calorias;
        }
        public string DevolverCantidad()
        {
            return Cantidad + Ingrediente_.Tipo;
        }
    }
}
