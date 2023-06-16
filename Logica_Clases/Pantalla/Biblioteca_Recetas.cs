using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla
{
    public partial class Biblioteca_Recetas : Form
    {
        public Biblioteca_Recetas()
        {
            InitializeComponent();
        }

        private void etiquetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevaEtiqueta = new etiqueta_nueva();
            nuevaEtiqueta.Show();

        }
    }
}
