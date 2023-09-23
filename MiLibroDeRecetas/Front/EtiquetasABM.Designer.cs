namespace Front
{
    partial class EtiquetasABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtiquetasABM));
            listBoxEtiquetas = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            btnVolver = new Button();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // listBoxEtiquetas
            // 
            listBoxEtiquetas.FormattingEnabled = true;
            listBoxEtiquetas.ItemHeight = 15;
            listBoxEtiquetas.Location = new Point(12, 12);
            listBoxEtiquetas.Name = "listBoxEtiquetas";
            listBoxEtiquetas.Size = new Size(265, 424);
            listBoxEtiquetas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(283, 43);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(165, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Añadir Etiqueta";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(283, 101);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(165, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Etiqueta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(283, 72);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(165, 23);
            btnOrdenar.TabIndex = 3;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(283, 413);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(165, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(283, 14);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 5;
            // 
            // EtiquetasABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 450);
            Controls.Add(txtNombre);
            Controls.Add(btnVolver);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(listBoxEtiquetas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EtiquetasABM";
            Text = "Etiquetas";
            Load += EtiquetasABM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEtiquetas;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnOrdenar;
        private Button btnVolver;
        private TextBox txtNombre;
    }
}