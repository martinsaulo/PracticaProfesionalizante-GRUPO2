using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }
        public int IdUsuarioLoggeado { get; set; }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnEtiquetas_Click(object sender, EventArgs e)
        {
            EtiquetasABM nuevaVentana = new EtiquetasABM();

            this.Visible = false;
            nuevaVentana.ShowDialog();
            this.Visible = true;

        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            IngredientesABM nuevaVentana = new IngredientesABM();

            this.Visible = false;
            nuevaVentana.ShowDialog();
            this.Visible = true;
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            PantallaRecetas nuevaVentana = new PantallaRecetas();

            this.Visible = false;
            nuevaVentana.IdUsuarioLogueado = IdUsuarioLoggeado;
            nuevaVentana.ShowDialog();
            this.Visible = true;
        }
    }
}
