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

            return (usuarioEncontrado.Contrasenia == EncriptadoConHash(ContraseniaUsuario));
        }
        public bool NombreYaExistente (string NombreUsuario)
        {
            var usuarioEncontrado = context.Usuarios.SingleOrDefault(x => x.Nombre == NombreUsuario);
            
            return (usuarioEncontrado != null);
        }
        public Usuario? DevolverUsuario(string NombreUsuario)
        {
            var usuarioEncontrado = context.Usuarios.SingleOrDefault(x => x.Nombre == NombreUsuario);

            return usuarioEncontrado;
        }
        public void AltaUsuario (string NombreUsuario, string ContraseniaUsuario)
        {
            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Nombre = NombreUsuario;
            nuevoUsuario.Contrasenia = EncriptadoConHash(ContraseniaUsuario);

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
        }
        public void BajaIngrediente(int Id)
        {
            var ingredienteEncontrado = context.Ingredientes.Find(Id);
            if (ingredienteEncontrado != null)
            {
                context.Ingredientes.Remove(ingredienteEncontrado);
                context.SaveChanges();
            }
        }
        public List<Ingrediente> DevolverListaIngredientes()
        {
            return context.Ingredientes.ToList();
        }
    }
}