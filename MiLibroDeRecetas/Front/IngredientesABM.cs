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
            dataGridView1.DataSource = BDD.DevolverListaIngredientes();
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["Tipo"]).DataSource = new List<string> { "Mililitro", "Unidad", "Gramo" };
            AjustarAnchoColumnas();
        }
        private void AjustarAnchoColumnas()
        {
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 150;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngredientesABM_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
            comboBoxTipos.SelectedIndex = 0;
            comboBoxOrden.SelectedIndex = 0;
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
                nuevoIngrediente.Tipo = comboBoxTipos.SelectedItem.ToString();

                BDD.AltaIngrediente(nuevoIngrediente);
                ActualizarDataGridView();
                txtNombre.Clear();
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Ingrediente ingredienteModificado = new Ingrediente();

            ingredienteModificado.Id = (int)dataGridView1[0, e.RowIndex].Value;
            ingredienteModificado.Nombre = dataGridView1[1, e.RowIndex].Value.ToString();
            ingredienteModificado.Calorias = (double)dataGridView1[2, e.RowIndex].Value;
            ingredienteModificado.Tipo = dataGridView1[3, e.RowIndex].Value.ToString();

            BDD.ModificacionIngrediente(ingredienteModificado);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            switch (comboBoxOrden.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = BDD.DevolverListaIngredientes().OrderBy(x => x.Nombre).ToList();
                    AjustarAnchoColumnas();
                    break;
                case 1:
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = BDD.DevolverListaIngredientes().OrderBy(x => x.Calorias).ToList();
                    AjustarAnchoColumnas();
                    break;
                case 2:
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = BDD.DevolverListaIngredientes().OrderBy(x => x.Tipo).ToList();
                    AjustarAnchoColumnas();
                    break;
                case 3:
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = BDD.DevolverListaIngredientes().OrderBy(x => x.Id).ToList();
                    AjustarAnchoColumnas();
                    break;
            }
        }

    }
}
