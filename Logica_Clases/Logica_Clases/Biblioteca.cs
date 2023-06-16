using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Clases
{
    public class Biblioteca
    {
        public static List<Receta> listaRecetas { get; set; } = new List<Receta>();
        public static List<Etiqueta> listaEtiquetas { get; set; } = new List<Etiqueta>();
        public static List<Ingrediente> listaIngredites { get; set; } = new List<Ingrediente>();

        public void CrearReceta(Receta nuevaReceta) 
        {
            nuevaReceta.idReceta = listaRecetas.Last().idReceta + 1;
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
        public void ModificarReceta(int idRecetaModificada, Receta recetaModificada) 
        {
            Receta viejaReceta = listaRecetas.Find(x => x.idReceta == idRecetaModificada);
            viejaReceta = recetaModificada;
            viejaReceta.idReceta += idRecetaModificada;
        }
        public void AgregarEtiqueta(Etiqueta nuevaEtiqueta)
        {

        }
        public void ImportarReceta(string rutaArchivo) { }
        public void ExportarReceta(string rutaArchivo, Receta recetaExportada) { }
    }
}
