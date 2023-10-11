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
        public Ingrediente Ingrediente {  get; set; }
        public int RecetaId { get; set; }
        public int Cantidad { get; set; }
        public string CantidadTipo { 

            get 
            {
                switch (Ingrediente.Tipo)
                {
                    case "Unidad":
                        return Ingrediente.Nombre + ": " + Cantidad + " unidad/es";

                    case "Gramo":
                        return Ingrediente.Nombre + ": " + Cantidad + "g";

                    case "Mililitro":
                        return Ingrediente.Nombre + ": " + Cantidad + "ml";
                    default:
                        return "Se ha producido un error";
                }
            } 
        }

        public double DevolverCalorias() {
            return Cantidad * Ingrediente.Calorias;
        }
    }
}
