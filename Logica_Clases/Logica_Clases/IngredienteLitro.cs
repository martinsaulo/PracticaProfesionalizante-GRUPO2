using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Clases
{
    public class IngredienteLitro : Ingrediente
    {
        public int mililitros { get; set; }
        public int caloriasPorMililitro { get; set; }
        public override int DevolverCalorias()
        {
            return mililitros * caloriasPorMililitro;
        }
        public override string DevolverCantidad()
        {
            return mililitros + "ml";
        }
    }
}
