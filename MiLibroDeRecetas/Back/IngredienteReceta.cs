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
        public string CantidadTipo { 

            get 
            {
                switch (Ingrediente_.Tipo)
                {
                    case "Unidad":
                        return Ingrediente_.Nombre + ": " +Cantidad + " unidad/es";

                    case "Gramo":
                        return Ingrediente_.Nombre + ": " + Cantidad + "g";

                    case "Mililitro":
                        return Ingrediente_.Nombre + ": " + Cantidad + "ml";
                    default:
                        return "Se ha producido un error";
                }
            } 
        }

        public double DevolverCalorias() {
            return Cantidad * Ingrediente_.Calorias;
        }
    }
}
