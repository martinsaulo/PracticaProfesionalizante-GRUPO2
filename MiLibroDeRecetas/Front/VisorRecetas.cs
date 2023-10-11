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
    public partial class VisorRecetas : Form
    {
        public VisorRecetas()
        {
            InitializeComponent();
        }
        public Receta recetaCargada { get; set; }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisorRecetas_Load(object sender, EventArgs e)
        {
            this.Text = recetaCargada.Titulo;

            lblTitulo.Text = recetaCargada.Titulo;
            lblCreacion.Text = "Creación: " + recetaCargada.Fecha_Creacion.ToShortDateString();
            lblModificacion.Text = "Ultima modificación: " + recetaCargada.Fecha_Modificacion.ToShortDateString();
            lblCalorias.Text = "Calorias: " + recetaCargada.Calorias.ToString();

            try
            {
                listBoxEtiquetas.DataSource = recetaCargada.Etiquetas;
                listBoxEtiquetas.DisplayMember = "NombreEtiqueta";
            }
            catch (NullReferenceException ex)
            {
                listBoxEtiquetas.DataSource = null;
            }

            try
            {
                listBoxIngredientes.DataSource = recetaCargada.Ingredientes;
                listBoxIngredientes.DisplayMember = "CantidadTipo";
            }
            catch (NullReferenceException ex)
            {
                listBoxIngredientes.DataSource = null;
            }

            dataGridViewPasos.DataSource = recetaCargada.Pasos;
            dataGridViewPasos.Columns["Id"].Visible = false;
            dataGridViewPasos.Columns["RecetaId"].Visible = false;
        }
    }
}
