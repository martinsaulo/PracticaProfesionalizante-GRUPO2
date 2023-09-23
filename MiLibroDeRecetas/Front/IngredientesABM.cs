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
using System.Windows.Forms.Design.Behavior;

namespace Front
{
    public partial class IngredientesABM : Form
    {
        public IngredientesABM()
        {
            InitializeComponent();
        }
        Principal BDD = new Principal();
        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BDD.DevolverListaIngredientes();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngredientesABM_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BDD.DevolverListaIngredientes();
            comboBoxTipos.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCalorias1.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                Ingrediente nuevoIngrediente = new Ingrediente();
                nuevoIngrediente.Nombre = txtNombre.Text;
                nuevoIngrediente.Calorias = double.Parse(txtCalorias1.Text);
                nuevoIngrediente.Tipo = comboBoxTipos.SelectedText;

                BDD.AltaIngrediente(nuevoIngrediente);
                ActualizarDataGridView();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un ingrediente.");
            }
            else
            {
                BDD.BajaIngrediente((int)dataGridView1.CurrentRow.Cells[0].Value);
                ActualizarDataGridView();
            }
        }
    }
}
