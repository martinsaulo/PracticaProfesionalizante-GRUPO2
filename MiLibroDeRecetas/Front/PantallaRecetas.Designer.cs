namespace Front
{
    partial class PantallaRecetas
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
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnFiltrar = new Button();
            btnOrdenar = new Button();
            btnModificar = new Button();
            btnVolver = new Button();
            comboBoxFiltrar = new ComboBox();
            comboBoxOrdenar = new ComboBox();
            listBoxEtiquetas = new ListBox();
            label1 = new Label();
            Id = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Calorias = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            FechaModificacion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Titulo, Calorias, FechaCreacion, FechaModificacion });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(593, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(611, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Nueva receta";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(611, 70);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(177, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar receta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(611, 144);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(177, 23);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(611, 217);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(177, 23);
            btnOrdenar.TabIndex = 4;
            btnOrdenar.Text = "Ordenar por";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(611, 41);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar receta";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(684, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(104, 23);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // comboBoxFiltrar
            // 
            comboBoxFiltrar.FormattingEnabled = true;
            comboBoxFiltrar.Location = new Point(611, 115);
            comboBoxFiltrar.Name = "comboBoxFiltrar";
            comboBoxFiltrar.Size = new Size(177, 23);
            comboBoxFiltrar.TabIndex = 7;
            // 
            // comboBoxOrdenar
            // 
            comboBoxOrdenar.FormattingEnabled = true;
            comboBoxOrdenar.Items.AddRange(new object[] { "Alfabeticamente", "Por calorias", "Por fecha de creación", "Por ultima modificación" });
            comboBoxOrdenar.Location = new Point(611, 188);
            comboBoxOrdenar.Name = "comboBoxOrdenar";
            comboBoxOrdenar.Size = new Size(177, 23);
            comboBoxOrdenar.TabIndex = 8;
            // 
            // listBoxEtiquetas
            // 
            listBoxEtiquetas.FormattingEnabled = true;
            listBoxEtiquetas.ItemHeight = 15;
            listBoxEtiquetas.Location = new Point(611, 271);
            listBoxEtiquetas.Name = "listBoxEtiquetas";
            listBoxEtiquetas.Size = new Size(177, 139);
            listBoxEtiquetas.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(611, 253);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 10;
            label1.Text = "Etiquetas:";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Titulo
            // 
            Titulo.DataPropertyName = "Titulo";
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            // 
            // Calorias
            // 
            Calorias.DataPropertyName = "Calorias";
            Calorias.HeaderText = "Calorias";
            Calorias.Name = "Calorias";
            Calorias.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.DataPropertyName = "Fecha_Creacion";
            FechaCreacion.HeaderText = "Fecha creacion";
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.ReadOnly = true;
            // 
            // FechaModificacion
            // 
            FechaModificacion.DataPropertyName = "Fecha_Modificacion";
            FechaModificacion.HeaderText = "Fecha modificacion";
            FechaModificacion.Name = "FechaModificacion";
            FechaModificacion.ReadOnly = true;
            // 
            // PantallaRecetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBoxEtiquetas);
            Controls.Add(comboBoxOrdenar);
            Controls.Add(comboBoxFiltrar);
            Controls.Add(btnVolver);
            Controls.Add(btnModificar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnFiltrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Name = "PantallaRecetas";
            Text = "Recetas";
            Load += PantallaRecetas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnFiltrar;
        private Button btnOrdenar;
        private Button btnModificar;
        private Button btnVolver;
        private ComboBox comboBoxFiltrar;
        private ComboBox comboBoxOrdenar;
        private ListBox listBoxEtiquetas;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Calorias;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn FechaModificacion;
    }
}