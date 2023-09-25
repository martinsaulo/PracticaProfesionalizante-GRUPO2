namespace Front
{
    partial class IngredientesABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientesABM));
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnOrdenar = new Button();
            btnVolver = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            comboBoxTipos = new ComboBox();
            label3 = new Label();
            txtCalorias1 = new NumericUpDown();
            btnEliminar = new Button();
            comboBoxOrden = new ComboBox();
            Id = new DataGridViewTextBoxColumn();
            Ingrediente = new DataGridViewTextBoxColumn();
            Calorias = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCalorias1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Ingrediente, Calorias, Tipo });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(428, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(446, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(151, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Ingrediente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(447, 241);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(151, 23);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(447, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(151, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(447, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 82);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Calorias";
            // 
            // comboBoxTipos
            // 
            comboBoxTipos.FormattingEnabled = true;
            comboBoxTipos.Items.AddRange(new object[] { "Unidad", "Gramo", "Miligramo" });
            comboBoxTipos.Location = new Point(447, 144);
            comboBoxTipos.Name = "comboBoxTipos";
            comboBoxTipos.Size = new Size(150, 23);
            comboBoxTipos.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 126);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 9;
            label3.Text = "Tipos";
            // 
            // txtCalorias1
            // 
            txtCalorias1.DecimalPlaces = 2;
            txtCalorias1.Location = new Point(447, 100);
            txtCalorias1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtCalorias1.Name = "txtCalorias1";
            txtCalorias1.Size = new Size(150, 23);
            txtCalorias1.TabIndex = 10;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(447, 212);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar Ingrediente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // comboBoxOrden
            // 
            comboBoxOrden.FormattingEnabled = true;
            comboBoxOrden.Items.AddRange(new object[] { "Alfabeticamente", "Por calorias", "Por tipo", "Por id" });
            comboBoxOrden.Location = new Point(448, 270);
            comboBoxOrden.Name = "comboBoxOrden";
            comboBoxOrden.Size = new Size(150, 23);
            comboBoxOrden.TabIndex = 12;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "Id";
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            Id.Width = 35;
            // 
            // Ingrediente
            // 
            Ingrediente.DataPropertyName = "Nombre";
            Ingrediente.Frozen = true;
            Ingrediente.HeaderText = "Ingrediente";
            Ingrediente.Name = "Ingrediente";
            Ingrediente.Resizable = DataGridViewTriState.False;
            Ingrediente.SortMode = DataGridViewColumnSortMode.Programmatic;
            Ingrediente.Width = 150;
            // 
            // Calorias
            // 
            Calorias.DataPropertyName = "Calorias";
            Calorias.HeaderText = "Calorias";
            Calorias.Name = "Calorias";
            Calorias.Resizable = DataGridViewTriState.False;
            Calorias.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.Resizable = DataGridViewTriState.False;
            Tipo.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // IngredientesABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 450);
            Controls.Add(comboBoxOrden);
            Controls.Add(btnEliminar);
            Controls.Add(txtCalorias1);
            Controls.Add(label3);
            Controls.Add(comboBoxTipos);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnOrdenar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IngredientesABM";
            Text = "Ingredientes";
            Load += IngredientesABM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCalorias1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnOrdenar;
        private Button btnVolver;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private NumericUpDown txtCalorias1;
        private ComboBox comboBoxTipos;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button btnEliminar;
        private ComboBox comboBoxOrden;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Ingrediente;
        private DataGridViewTextBoxColumn Calorias;
        private DataGridViewTextBoxColumn Tipo;
    }
}