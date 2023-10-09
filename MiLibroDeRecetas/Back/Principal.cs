using System.Security.Cryptography;
using System.Text;

namespace Back
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();
        
        private byte[] ConseguirHash(string texto)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(texto));
        }
        private string EncriptadoConHash (string texto)
        {
            StringBuilder stringRetornado = new StringBuilder();
            foreach (byte b in ConseguirHash(texto))
                stringRetornado.Append(b.ToString("X2"));

            return stringRetornado.ToString();
        }
        public bool InicioSesionValido(string NombreUsuario, string ContraseniaUsuario)
        {
            var usuarioEncontrado = context.Usuarios.SingleOrDefault(x => x.Nombre == NombreUsuario);
            if (usuarioEncontrado == null)
            {
                throw new NullReferenceException("Nombre de usuario no encontrado.");
            }
            return (usuarioEncontrado.Contrasenia == EncriptadoConHash(ContraseniaUsuario));
        }
        public bool NombreYaExistente (string NombreUsuario)
        {
            var usuarioEncontrado = context.Usuarios.SingleOrDefault(x => x.Nombre == NombreUsuario);
            
            return (usuarioEncontrado != null);
        }
        public Usuario DevolverUsuario(string NombreUsuario)
        {
            var usuarioEncontrado = context.Usuarios.SingleOrDefault(x => x.Nombre == NombreUsuario);

            if(usuarioEncontrado != null){
                return usuarioEncontrado;
            }
            else
            {
                throw new NullReferenceException("Usuario no encontrado.");
            }
            
        }
        public void AltaUsuario (string NombreUsuario, string ContraseniaUsuario)
        {
            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Nombre = NombreUsuario;
            nuevoUsuario.Contrasenia = EncriptadoConHash(ContraseniaUsuario);
            nuevoUsuario.Recetas = new List<Receta>();

            context.Usuarios.Add(nuevoUsuario);
            context.SaveChanges();
        }
        public void AltaReceta (Receta nuevaReceta, int idUsuario)
        {
            var usuarioEncontrado = context.Usuarios.Find(idUsuario);
            if(usuarioEncontrado != null)
            {
                nuevaReceta.Fecha_Creacion = DateTime.Now;
                nuevaReceta.Fecha_Modificacion = DateTime.Now;
                usuarioEncontrado.Recetas.Add(nuevaReceta);
                context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("Usuario no encontrado.");
            }
        }
        public void BajaReceta(int Id)
        {
            var recetaEncontrada = context.Recetas.Find(Id);
            if (recetaEncontrada != null)
            {
                context.Recetas.Remove(recetaEncontrada);
                context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("Receta no encontrada.");
            }
        }
        public void ModificacionReceta(Receta RecetaNueva)
        {
            var recetaEncontrada = context.Recetas.Find(RecetaNueva.Id);
            if (recetaEncontrada != null)
            {
                recetaEncontrada = RecetaNueva;
                recetaEncontrada.Fecha_Modificacion = DateTime.Now;
                context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("Receta no encontrada.");
            }
        }
        public List<Receta> FiltrarPorEtiqueta(List<Receta> Recetas, Etiqueta etiqueta)
        {
            List<Receta> recetasRetornadas = new List<Receta>();
            foreach (Receta x in Recetas)
            {
                if (x.EtiquetaIncluida(etiqueta))
                {
                    recetasRetornadas.Add(x);
                }
            }
            return recetasRetornadas;
        }
        public List<Receta> DevolverRecetasUsuario(int idUsuario)
        {
            var usuarioEncontrado = context.Usuarios.Find(idUsuario);
            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado.Recetas;
            }
            else
            {
                throw new NullReferenceException("Usuario no encontrado.");
            }
        } 
        public void AltaEtiqueta (string NombreEtiqueta)
        {
            Etiqueta nuevaEtiqueta = new Etiqueta();
            nuevaEtiqueta.Nombre = NombreEtiqueta;

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
            else
            {
                throw new NullReferenceException("Etiqueta no encontrada.");
            }
        }
        public List<Etiqueta> DevolverListaEtiquetas()
        {
            return context.Etiquetas.ToList();
        }
        public void AltaIngrediente(Ingrediente nuevoIngrediente)
        {
            context.Ingredientes.Add(nuevoIngrediente);
            context.SaveChanges();
        }
        public void ModificacionIngrediente(Ingrediente nuevoIngrediente)
        {
            var ingredienteEncontrado = context.Ingredientes.Find(nuevoIngrediente.Id);
            if (ingredienteEncontrado != null)
            {
                ingredienteEncontrado = nuevoIngrediente;
                context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("Ingrediente no encontrado.");
            }
        }
        public void BajaIngrediente(int Id)
        {
            var ingredienteEncontrado = context.Ingredientes.Find(Id);
            if (ingredienteEncontrado != null)
            {
                context.Ingredientes.Remove(ingredienteEncontrado);
                context.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("Ingrediente no encontrado.");
            }
        }
        public List<Ingrediente> DevolverListaIngredientes()
        {
            return context.Ingredientes.ToList();
        }
    }
}