using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Receta
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<IngredienteReceta> Ingredientes { get; set; }
        public List<EtiquetaReceta> Etiquetas { get; set; }
        public List<Paso> Pasos { get; set; }
        public int Calorias { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        public int UsuarioId { get; set; }
        public void CalcularCalorias()
        {
            double total = 0;

            foreach(var ingrediente in Ingredientes)
            {
                total += ingrediente.DevolverCalorias();
            }
            Calorias = (int)total;
        }
    }
}
