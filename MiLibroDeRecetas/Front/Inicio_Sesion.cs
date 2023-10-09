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
    public partial class Inicio_Sesion : Form
    {
        public Inicio_Sesion()
        {
            InitializeComponent();
        }
        Principal BDD = new Principal();
        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro ventanaRegistro = new Registro();
            this.Visible = false;
            ventanaRegistro.ShowDialog();
            this.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (txtContrasenia.Text != "" || txtNombre.Text != "")
            {
                if (BDD.NombreYaExistente(txtNombre.Text))
                {
                    if (BDD.InicioSesionValido(txtNombre.Text, txtContrasenia.Text))
                    {
                        this.Visible = false;
                        Menu_Principal ventanaMenu = new Menu_Principal();
                        ventanaMenu.IdUsuarioLoggeado = BDD.DevolverUsuario(txtNombre.Text).Id;
                        ventanaMenu.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }

                }
                else
                {
                    MessageBox.Show("Nombre de usuario incorrecto.");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos.");
            }
            
        }

        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {

        }
    }
}
