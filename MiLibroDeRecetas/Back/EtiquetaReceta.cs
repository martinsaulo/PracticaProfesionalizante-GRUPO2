using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Back
{
    public class EtiquetaReceta
    {
        public int Id { get; set; }
        public int RecetaId { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public string NombreEtiqueta { get { return Etiqueta.Nombre; } }
    }
}
