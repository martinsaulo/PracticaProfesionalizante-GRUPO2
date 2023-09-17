namespace Back
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public bool NombreYaExistente (string NombreUsuario)
        {
            var usuarioEncontrado = context.Usuarios.SingleOrDefault(x => x.Nombre == NombreUsuario);
            
            return (usuarioEncontrado != null);
        }

        public void AltaUsuario (Usuario nuevoUsuario)
        {
            context.Usuarios.Add(nuevoUsuario);
            context.SaveChanges();
        }
        public void AltaReceta (Receta nuevaReceta)
        {
            context.Recetas.Add(nuevaReceta);
            context.SaveChanges();
        }
        public void BajaReceta(int Id)
        {
            var recetaEncontrada = context.Recetas.Find(Id);
            if (recetaEncontrada != null)
            {
                context.Recetas.Remove(recetaEncontrada);
                context.SaveChanges();
            }
        }
        public void ModificacionReceta(Receta RecetaNueva)
        {
            var recetaEncontrada = context.Recetas.Find(RecetaNueva.Id);
            if (recetaEncontrada != null)
            {
                recetaEncontrada = RecetaNueva;
                context.SaveChanges();
            }
        }
        public Receta BuscarReceta(int Id)
        {
            throw new NotImplementedException();
        }
        public void AltaEtiqueta (Etiqueta nuevaEtiqueta)
        {
            context.Etiquetas.Add(nuevaEtiqueta);
            context.SaveChanges();
        }
        public void BajaEtiqueta(int Id)
        {
            var etiquetaEncontrada = context.Etiquetas.Find(Id);
            if (etiquetaEncontrada != null)
            {
                context.Etiquetas.Remove(etiquetaEncontrada);
                context.SaveChanges();
            }
        }
        public void AltaIngrediente(Ingrediente nuevoIngrediente)
        {
            context.Ingredientes.Add(nuevoIngrediente);
            context.SaveChanges();
        }
        public void Bajaingrediente(int Id)
        {
            var ingredienteEncontrado = context.Ingredientes.Find(Id);
            if (ingredienteEncontrado != null)
            {
                context.Ingredientes.Remove(ingredienteEncontrado);
                context.SaveChanges();
            }
        }
    }
}