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
    public partial class EtiquetasABM : Form
    {
        public EtiquetasABM()
        {
            InitializeComponent();
        }
        Principal BDD = new Principal();
        private void ActualizarLista()
        {
            listBoxEtiquetas.DataSource = null;
            listBoxEtiquetas.DataSource = BDD.DevolverListaEtiquetas();
            listBoxEtiquetas.DisplayMember = "Nombre";
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listBoxEtiquetas.DataSource = null;
            var listaOrdenada = BDD.DevolverListaEtiquetas().OrderBy(x => x.Nombre).ToList();
            listBoxEtiquetas.DataSource = listaOrdenada;
            listBoxEtiquetas.DisplayMember = "Nombre";
        }

        private void EtiquetasABM_Load(object sender, EventArgs e)
        {
            listBoxEtiquetas.DataSource = BDD.DevolverListaEtiquetas();
            listBoxEtiquetas.DisplayMember = "Nombre";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxEtiquetas.SelectedItem == null)
            {
                MessageBox.Show("No hay ninguna etiqueta seleccionada.");
            }
            else
            {
                int idEtiquetaEncontrada = ((Etiqueta)listBoxEtiquetas.SelectedItem).Id;
                BDD.BajaEtiqueta(idEtiquetaEncontrada);

                ActualizarLista();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.");
            }
            else
            {
                BDD.AltaEtiqueta(txtNombre.Text);
                txtNombre.Clear();
                ActualizarLista();
            }
        }
    }
}
