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
    public partial class Inicio_Sesion : Form
    {
        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro ventanaRegistro = new Registro();
            this.Visible = false;
            ventanaRegistro.ShowDialog();
            this.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Menu_Principal ventanaMenu = new Menu_Principal();
            ventanaMenu.ShowDialog();

            this.Visible = true;
        }
    }
}
