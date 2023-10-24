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
    public partial class PantallaRecetas : Form
    {
        public PantallaRecetas()
        {
            InitializeComponent();
        }
        Principal BDD = new Principal();
        int IdUsuarioLogueado = Usuario.Current;
        private void ActualizarDataGridView(List<Receta> lista)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            dataGridView1.Refresh();

            dataGridView1.Columns["Descripcion"].Visible = false;
            dataGridView1.Columns["Titulo"].Width = 160;
            dataGridView1.Columns["Id"].Width = 40;
            dataGridView1.Columns["UsuarioId"].Visible = false;
            dataGridView1.Columns[4].Width = 125;
            dataGridView1.Columns[5].Width = 125;
        }
        private bool ComprobarSeleccion()
        {
            if (dataGridView1.CurrentCell != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Seleccione una receta.");
                return false;
            }
        }

        private void PantallaRecetas_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView(BDD.DevolverRecetasUsuario(IdUsuarioLogueado));
            var eliminarEsto = BDD.DevolverRecetasUsuario(IdUsuarioLogueado);
            comboBoxFiltrar.DataSource = BDD.DevolverListaEtiquetas();
            comboBoxFiltrar.DisplayMember = "Nombre";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            //Actualizar lista de etiquetas

            listBoxEtiquetas.DataSource = null;

            try
            {
                int indexFila = dataGridView1.CurrentCell.RowIndex;
                listBoxEtiquetas.DataSource = ((Receta)dataGridView1.Rows[indexFila].DataBoundItem).Etiquetas;
                listBoxEtiquetas.DisplayMember = "NombreEtiqueta";
            }
            catch (System.NullReferenceException ex)
            {
                listBoxEtiquetas.DataSource = null;
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int indexFila = dataGridView1.CurrentCell.RowIndex;

                BDD.BajaReceta((int)dataGridView1[0, indexFila].Value);
                ActualizarDataGridView(BDD.DevolverRecetasUsuario(IdUsuarioLogueado));
            }
            else
            {
                MessageBox.Show("Seleccione una receta.");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            switch (comboBoxOrdenar.SelectedIndex)
            {
                case 0:
                    ActualizarDataGridView(BDD.DevolverRecetasUsuario(IdUsuarioLogueado).OrderBy(x => x.Titulo).ToList());
                    break;
                case 1:
                    ActualizarDataGridView(BDD.DevolverRecetasUsuario(IdUsuarioLogueado).OrderBy(x => x.Calorias).ToList());
                    break;
                case 2:
                    ActualizarDataGridView(BDD.DevolverRecetasUsuario(IdUsuarioLogueado).OrderBy(x => x.Fecha_Creacion).ToList());
                    break;
                case 3:
                    ActualizarDataGridView(BDD.DevolverRecetasUsuario(IdUsuarioLogueado).OrderBy(x => x.Fecha_Modificacion).ToList());
                    break;
                case -1:
                    MessageBox.Show("Seleccione una opción de ordenamiento.");
                    break;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltrar.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una etiqueta para poder filtrar");
            }
            else
            {
                ActualizarDataGridView(BDD.FiltrarPorEtiqueta(BDD.DevolverRecetasUsuario(IdUsuarioLogueado), 
                    (Etiqueta)comboBoxFiltrar.SelectedItem));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RecetasAltaModificacion nuevaVentana = new RecetasAltaModificacion();

            this.Visible = false;
            nuevaVentana.esModificacion = false;
            nuevaVentana.ShowDialog();
            this.Visible = true;

            ActualizarDataGridView(BDD.DevolverRecetasUsuario(IdUsuarioLogueado));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexFila = e.RowIndex;
                VisorRecetas nuevaVentana = new VisorRecetas();
                nuevaVentana.recetaCargada = BDD.DevolverReceta((int)dataGridView1[0, indexFila].Value);

                this.Visible = false;
                nuevaVentana.ShowDialog();
                this.Visible = true;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("La receta seleccionada no es valida.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                RecetasAltaModificacion nuevaVentana = new RecetasAltaModificacion();
                int indexFila = dataGridView1.CurrentCell.RowIndex;

                nuevaVentana.esModificacion = true;
                nuevaVentana.idReceta = (int)dataGridView1[0, indexFila].Value;

                this.Visible = false;
                nuevaVentana.ShowDialog();
                this.Visible = true;

                BDD = null;
                BDD = new Principal();

                ActualizarDataGridView(BDD.DevolverRecetasUsuario(IdUsuarioLogueado));
            }
            else
            {
                MessageBox.Show("Seleccione una receta.");
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView(BDD.DevolverRecetasUsuario(IdUsuarioLogueado));
        }
    }
}
