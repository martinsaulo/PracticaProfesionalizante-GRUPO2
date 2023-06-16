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
        public int caloriasMililitro { get; set; }
        public override int DevolverCalorias()
        {
            return mililitros * caloriasMililitro;
        }
        public override string DevolverCantidad()
        {
            return mililitros + "ml";
        }
    }
}
