namespace Front
{
    partial class Inicio_Sesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Sesion));
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtContrasenia = new TextBox();
            label3 = new Label();
            linkRegistro = new LinkLabel();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 47);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(124, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 100);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(93, 97);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(124, 23);
            txtContrasenia.TabIndex = 3;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 142);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 4;
            label3.Text = "¿No tienes una cuenta?";
            // 
            // linkRegistro
            // 
            linkRegistro.AutoSize = true;
            linkRegistro.Location = new Point(143, 142);
            linkRegistro.Name = "linkRegistro";
            linkRegistro.Size = new Size(74, 15);
            linkRegistro.TabIndex = 5;
            linkRegistro.TabStop = true;
            linkRegistro.Text = "Haz clic aquí";
            linkRegistro.LinkClicked += linkRegistro_LinkClicked;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(142, 181);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Inicio_Sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 221);
            Controls.Add(btnAceptar);
            Controls.Add(linkRegistro);
            Controls.Add(label3);
            Controls.Add(txtContrasenia);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio_Sesion";
            Text = "Inicio de sesión";
            Load += Inicio_Sesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtContrasenia;
        private Label label3;
        private LinkLabel linkRegistro;
        private Button btnAceptar;
    }
}