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

        public static void AgregarReceta(Receta nuevaReceta) 
        {
            nuevaReceta.idReceta = listaRecetas.Last().idReceta + 1;
            listaRecetas.Add(nuevaReceta);
        }
        public static void EliminarReceta(int idRecetaEliminada) 
        {
            Receta recetaEliminada = listaRecetas.Find(x => x.idReceta == idRecetaEliminada);
            if (recetaEliminada != null)
            {
                listaRecetas.Remove(recetaEliminada);
            }
            
        }
        public static void ModificarReceta(int idRecetaModificada, Receta recetaModificada) 
        {
            int viejaRecetaIndex = listaRecetas.FindIndex(x => x.idReceta == idRecetaModificada);
            recetaModificada.fechaCreacion = listaRecetas[viejaRecetaIndex].fechaCreacion;
            listaRecetas[viejaRecetaIndex] = recetaModificada;
            listaRecetas[viejaRecetaIndex].idReceta = idRecetaModificada;
            listaRecetas[viejaRecetaIndex].ultimaModificacion = DateTime.Now;
        }
        //Arreglar
        public static void AgregarEtiqueta(Etiqueta nuevaEtiqueta)
        {
            listaEtiquetas.Add(nuevaEtiqueta);
        }
        public static void EliminarEtiqueta(Etiqueta EtiquetaEliminar)
        {
            listaEtiquetas.Remove(EtiquetaEliminar);
        }
        public static void AgregarIngrediente(Ingrediente nuevoIngrediente)
        {
            listaIngredites.Add(nuevoIngrediente);
        }
        public static void EliminarIngrediente(Ingrediente ingrienteEliminar)
        {
            listaIngredites.Remove(ingrienteEliminar);
        }
        public static void ModificarIngrediente(int idIngredienteViejo, Ingrediente ingredienteModificado) 
        {
            Ingrediente viejoIngrediente = listaIngredites.Find(x => x.idIngrediente == idIngredienteViejo);
            viejoIngrediente = ingredienteModificado;
            viejoIngrediente.idIngrediente = idIngredienteViejo;
        }
        public static void ImportarReceta(string rutaArchivo) { }
        public static void ExportarReceta(string rutaArchivo, Receta recetaExportada) { }
    }
}
