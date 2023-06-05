using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Clases
{
    public class Biblioteca
    {
        public List<Receta> listaRecetas { get; set; } = new List<Receta>();

        public void CrearReceta(string nombreReceta, string descripcionReceta, List<Etiqueta> listaEtiquetas,
            List<Ingrediente> listaIngredientes) 
        {
            Receta nuevaReceta = new Receta();
            nuevaReceta.idReceta = listaRecetas.Count;
            nuevaReceta.nombreReceta = nombreReceta;
            nuevaReceta.descripcionReceta = descripcionReceta;
            nuevaReceta.fechaCreacion = DateTime.Now;
            nuevaReceta.ultimaModificacion = DateTime.Now;
            nuevaReceta.listaIngredientes = listaIngredientes;
            nuevaReceta.listaEtiquetas = listaEtiquetas;
            nuevaReceta.caloriasTotales = nuevaReceta.CalcularCalorias();

            listaRecetas.Add(nuevaReceta);
        }
        public void EliminarReceta(int idRecetaEliminada) 
        {
            Receta recetaEliminada = listaRecetas.Find(x => x.idReceta == idRecetaEliminada);
            if (recetaEliminada != null)
            {
                listaRecetas.Remove(recetaEliminada);
            }
            
        }
        public void ModificarReceta(int idRecetaModificada) 
        {
            Receta recetaModificada = listaRecetas.Find(x => x.idReceta == idRecetaModificada);
        }
        public void ImportarReceta(string rutaArchivo) { }
        public void ExportarReceta(string rutaArchivo, Receta recetaExportada) { }
    }
}
