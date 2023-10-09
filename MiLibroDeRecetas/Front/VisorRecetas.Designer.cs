namespace Front
{
    partial class VisorRecetas
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
            btnVolver = new Button();
            lblTitulo = new Label();
            lblCreacion = new Label();
            lblModificacion = new Label();
            lblCalorias = new Label();
            listBoxEtiquetas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBoxIngredientes = new ListBox();
            dataGridViewPasos = new DataGridView();
            Descripcion = new DataGridViewTextBoxColumn();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasos).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(713, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(75, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo";
            // 
            // lblCreacion
            // 
            lblCreacion.AutoSize = true;
            lblCreacion.ForeColor = SystemColors.ControlDark;
            lblCreacion.Location = new Point(12, 41);
            lblCreacion.Name = "lblCreacion";
            lblCreacion.Size = new Size(106, 15);
            lblCreacion.TabIndex = 2;
            lblCreacion.Text = "Creación: 00/00/00";
            // 
            // lblModificacion
            // 
            lblModificacion.AutoSize = true;
            lblModificacion.ForeColor = SystemColors.ControlDark;
            lblModificacion.Location = new Point(12, 56);
            lblModificacion.Name = "lblModificacion";
            lblModificacion.Size = new Size(167, 15);
            lblModificacion.TabIndex = 3;
            lblModificacion.Text = "Ultima modificación: 00/00/00";
            // 
            // lblCalorias
            // 
            lblCalorias.AutoSize = true;
            lblCalorias.ForeColor = SystemColors.ControlDark;
            lblCalorias.Location = new Point(12, 71);
            lblCalorias.Name = "lblCalorias";
            lblCalorias.Size = new Size(79, 15);
            lblCalorias.TabIndex = 4;
            lblCalorias.Text = "Calorias: 0000";
            // 
            // listBoxEtiquetas
            // 
            listBoxEtiquetas.FormattingEnabled = true;
            listBoxEtiquetas.ItemHeight = 15;
            listBoxEtiquetas.Location = new Point(12, 299);
            listBoxEtiquetas.Name = "listBoxEtiquetas";
            listBoxEtiquetas.Size = new Size(167, 139);
            listBoxEtiquetas.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 281);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Etiquetas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "Ingredientes:";
            // 
            // listBoxIngredientes
            // 
            listBoxIngredientes.FormattingEnabled = true;
            listBoxIngredientes.ItemHeight = 15;
            listBoxIngredientes.Location = new Point(12, 124);
            listBoxIngredientes.Name = "listBoxIngredientes";
            listBoxIngredientes.Size = new Size(167, 154);
            listBoxIngredientes.TabIndex = 8;
            // 
            // dataGridViewPasos
            // 
            dataGridViewPasos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPasos.Columns.AddRange(new DataGridViewColumn[] { Descripcion });
            dataGridViewPasos.Location = new Point(221, 56);
            dataGridViewPasos.Name = "dataGridViewPasos";
            dataGridViewPasos.RowTemplate.Height = 25;
            dataGridViewPasos.Size = new Size(567, 353);
            dataGridViewPasos.TabIndex = 9;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 524;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 38);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "Pasos:";
            // 
            // VisorRecetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dataGridViewPasos);
            Controls.Add(listBoxIngredientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxEtiquetas);
            Controls.Add(lblCalorias);
            Controls.Add(lblModificacion);
            Controls.Add(lblCreacion);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolver);
            Name = "VisorRecetas";
            Text = "Titulo";
            Load += VisorRecetas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private Label lblCreacion;
        private Label lblModificacion;
        private Label lblCalorias;
        private ListBox listBoxEtiquetas;
        private Label label1;
        private Label label2;
        private ListBox listBoxIngredientes;
        private DataGridView dataGridViewPasos;
        private Label label3;
        private DataGridViewTextBoxColumn Descripcion;
    }
}