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
    public partial class RecetasAltaModificacion : Form
    {
        public RecetasAltaModificacion()
        {
            InitializeComponent();
        }
        Principal BDD = new Principal();
        public int idUsuarioLoggueado { get; set; }
        public bool esModificacion { get; set; }
        public Receta? nuevaReceta { get; set; }
        public int idReceta { get; set; }
        private bool ComprobarTitulo()
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("La receta debe tener un título.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ComprobarIngredientes()
        {
            if (listBoxIngrediente.Items.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("La receta debe tener por lo menos un ingrediente.");
                return false;
            }
        }
        private bool ComprobarPasos()
        {
            if (dataGridViewPasos.Rows.Count > 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("La receta debe tener por lo menos un paso.");
                return false;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecetasAltaModificacion_Load(object sender, EventArgs e)
        {
            comboBoxEtiquetas.DataSource = BDD.DevolverListaEtiquetas();
            comboBoxEtiquetas.DisplayMember = "Nombre";

            comboBoxIngredientes.DataSource = BDD.DevolverListaIngredientes();
            comboBoxIngredientes.DisplayMember = "Nombre";

            listBoxEtiquetas.DisplayMember = "Nombre";
            listBoxIngrediente.DisplayMember = "CantidadTipo";


            nuevaReceta = new Receta();
            nuevaReceta.Etiquetas = new List<EtiquetaReceta>();
            nuevaReceta.Ingredientes = new List<IngredienteReceta>();
            nuevaReceta.Pasos = new List<Paso>();

            if (esModificacion)
            {
                Receta recetaModificar = new Receta();
                recetaModificar = BDD.DevolverReceta(idReceta);

                txtTitulo.Text = recetaModificar.Titulo;
                txtDescripcion.Text = recetaModificar.Descripcion;

                foreach (var et in recetaModificar.Etiquetas)
                {
                    listBoxEtiquetas.Items.Add(et.Etiqueta);
                }

                foreach (var ing in recetaModificar.Ingredientes)
                {
                    listBoxIngrediente.Items.Add(ing);
                }

                int cont = 0;
                foreach (var paso in recetaModificar.Pasos)
                {
                    dataGridViewPasos.Rows.Add(new DataGridViewRow());
                    dataGridViewPasos.Rows[cont].Cells[0].Value = paso.Descripcion;
                    cont++;
                }
            }
        }

        private void btnAgregarEtiqueta_Click(object sender, EventArgs e)
        {
            if (comboBoxEtiquetas.SelectedIndex != -1)
            {
                Etiqueta nuevaEtiqueta = (Etiqueta)comboBoxEtiquetas.SelectedItem;

                listBoxEtiquetas.Items.Add(nuevaEtiqueta);
                comboBoxEtiquetas.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Seleccione una etiqueta.");
            }
        }

        private void btnQuitarEtiqueta_Click(object sender, EventArgs e)
        {
            var etiquetaSeleccionada = listBoxEtiquetas.SelectedItem;

            if (etiquetaSeleccionada != null)
            {
                listBoxEtiquetas.Items.Remove(etiquetaSeleccionada);
            }
            else
            {
                MessageBox.Show("Seleccione una etiqueta.");
            }
        }

        private void btnQuitarIngrediente_Click(object sender, EventArgs e)
        {
            var ingredienteSeleccionado = listBoxIngrediente.SelectedItem;

            if (ingredienteSeleccionado != null)
            {
                listBoxIngrediente.Items.Remove(ingredienteSeleccionado);
            }
            else
            {
                MessageBox.Show("Seleccione un ingrediente.");
            }
        }

        private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            if (comboBoxIngredientes.SelectedIndex != -1)
            {
                if (numCantidad.Value > 0)
                {
                    IngredienteReceta nuevoIngrediente = new IngredienteReceta();

                    nuevoIngrediente.Ingrediente = (Ingrediente)comboBoxIngredientes.SelectedItem;
                    nuevoIngrediente.Cantidad = (int)numCantidad.Value;

                    listBoxIngrediente.Items.Add(nuevoIngrediente);

                    comboBoxIngredientes.SelectedIndex = -1;
                    numCantidad.Value = 0;
                }
                else
                {
                    MessageBox.Show("Cantidad invalida.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ingrediente.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indexFila = dataGridViewPasos.CurrentCell.RowIndex;
            if (indexFila != -1)
            {
                var filaSeleccionada = dataGridViewPasos.Rows[indexFila];

                dataGridViewPasos.Rows.Remove(filaSeleccionada);
            }
            else
            {
                MessageBox.Show("Seleccione un paso.");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarTitulo() && ComprobarIngredientes() && ComprobarPasos())
            {

                nuevaReceta.Titulo = txtTitulo.Text;
                nuevaReceta.Descripcion = txtDescripcion.Text;

                foreach (var item in listBoxEtiquetas.Items)
                {
                    if (item != null)
                    {
                        EtiquetaReceta nuevaEtiqueta = new EtiquetaReceta();
                        nuevaEtiqueta.Etiqueta = (Etiqueta)item;
                        nuevaReceta.Etiquetas.Add(nuevaEtiqueta);
                    }
                }

                foreach (var item in listBoxIngrediente.Items)
                {
                    if (item != null)
                    {
                        nuevaReceta.Ingredientes.Add((IngredienteReceta)item);
                    }
                }

                foreach (DataGridViewRow row in dataGridViewPasos.Rows)
                {
                    if (row != null && row.Cells[0].Value != null)
                    {
                        Paso nuevoPaso = new Paso();
                        nuevoPaso.Descripcion = row.Cells[0].Value.ToString();
                        nuevaReceta.Pasos.Add(nuevoPaso);
                    }
                }

                nuevaReceta.CalcularCalorias();
                if (esModificacion)
                {
                    nuevaReceta.Id = idReceta;
                    BDD.ModificacionReceta(nuevaReceta);
                }
                else
                {
                    BDD.AltaReceta(nuevaReceta, idUsuarioLoggueado);
                }

                this.Close();
            }
        }
    }
}
