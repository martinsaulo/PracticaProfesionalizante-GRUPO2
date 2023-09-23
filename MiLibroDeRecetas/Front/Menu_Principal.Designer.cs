namespace Front
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            menuStrip1 = new MenuStrip();
            cuentaToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            btnRecetas = new Button();
            btnIngredientes = new Button();
            btnEtiquetas = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cuentaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            cuentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            cuentaToolStripMenuItem.Size = new Size(57, 20);
            cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(143, 22);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(143, 22);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // btnRecetas
            // 
            btnRecetas.Location = new Point(49, 27);
            btnRecetas.Name = "btnRecetas";
            btnRecetas.Size = new Size(345, 411);
            btnRecetas.TabIndex = 2;
            btnRecetas.Text = "Mis Recetas";
            btnRecetas.UseVisualStyleBackColor = true;
            // 
            // btnIngredientes
            // 
            btnIngredientes.Location = new Point(426, 27);
            btnIngredientes.Name = "btnIngredientes";
            btnIngredientes.Size = new Size(302, 193);
            btnIngredientes.TabIndex = 3;
            btnIngredientes.Text = "Ingredientes";
            btnIngredientes.UseVisualStyleBackColor = true;
            btnIngredientes.Click += btnIngredientes_Click;
            // 
            // btnEtiquetas
            // 
            btnEtiquetas.Location = new Point(426, 247);
            btnEtiquetas.Name = "btnEtiquetas";
            btnEtiquetas.Size = new Size(302, 191);
            btnEtiquetas.TabIndex = 5;
            btnEtiquetas.Text = "Etiquetas";
            btnEtiquetas.UseVisualStyleBackColor = true;
            btnEtiquetas.Click += btnEtiquetas_Click;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEtiquetas);
            Controls.Add(btnIngredientes);
            Controls.Add(btnRecetas);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Menu_Principal";
            Text = "Menú principal";
            Load += Menu_Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cuentaToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private Button btnRecetas;
        private Button btnIngredientes;
        private Button btnEtiquetas;
    }
}