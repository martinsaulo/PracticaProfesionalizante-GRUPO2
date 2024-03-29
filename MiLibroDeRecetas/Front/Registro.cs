﻿using Back;
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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        Principal BDD = new Principal();
        public bool ComprobarContrasenia()
        {
            if (txtContrasenia.Text != txtConfirmarContrasenia.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden, vuelva a intentarlo.");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ComprobarNombre()
        {
            
            if (BDD.NombreYaExistente(txtNombre.Text))
            {
                MessageBox.Show("El nombre de usuario ya existe. Intente con otro.");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtContrasenia.Text == "" || txtConfirmarContrasenia.Text == "") 
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                if (ComprobarNombre() && ComprobarContrasenia())
                {

                    BDD.AltaUsuario(txtNombre.Text, txtContrasenia.Text);
                    this.Close();
                }
            }

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
