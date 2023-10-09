namespace Front
{
    partial class RecetasAltaModificacion
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
            txtDescripcion = new TextBox();
            txtTitulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBoxEtiquetas = new ListBox();
            btnAgregarEtiqueta = new Button();
            comboBoxEtiquetas = new ComboBox();
            btnQuitarEtiqueta = new Button();
            listBoxIngrediente = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnQuitarIngrediente = new Button();
            btnAgregarIngrediente = new Button();
            numCantidad = new NumericUpDown();
            label4 = new Label();
            comboBoxIngredientes = new ComboBox();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            dataGridViewPasos = new DataGridView();
            Descripcion = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasos).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 71);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(289, 156);
            txtDescripcion.TabIndex = 0;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 27);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(289, 23);
            txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 250);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // listBoxEtiquetas
            // 
            listBoxEtiquetas.FormattingEnabled = true;
            listBoxEtiquetas.ItemHeight = 15;
            listBoxEtiquetas.Location = new Point(18, 304);
            listBoxEtiquetas.Name = "listBoxEtiquetas";
            listBoxEtiquetas.Size = new Size(283, 139);
            listBoxEtiquetas.TabIndex = 5;
            // 
            // btnAgregarEtiqueta
            // 
            btnAgregarEtiqueta.Location = new Point(191, 268);
            btnAgregarEtiqueta.Name = "btnAgregarEtiqueta";
            btnAgregarEtiqueta.Size = new Size(52, 23);
            btnAgregarEtiqueta.TabIndex = 6;
            btnAgregarEtiqueta.Text = "Añadir";
            btnAgregarEtiqueta.UseVisualStyleBackColor = true;
            btnAgregarEtiqueta.Click += btnAgregarEtiqueta_Click;
            // 
            // comboBoxEtiquetas
            // 
            comboBoxEtiquetas.FormattingEnabled = true;
            comboBoxEtiquetas.Location = new Point(18, 268);
            comboBoxEtiquetas.Name = "comboBoxEtiquetas";
            comboBoxEtiquetas.Size = new Size(167, 23);
            comboBoxEtiquetas.TabIndex = 7;
            // 
            // btnQuitarEtiqueta
            // 
            btnQuitarEtiqueta.Location = new Point(249, 268);
            btnQuitarEtiqueta.Name = "btnQuitarEtiqueta";
            btnQuitarEtiqueta.Size = new Size(52, 23);
            btnQuitarEtiqueta.TabIndex = 8;
            btnQuitarEtiqueta.Text = "Quitar";
            btnQuitarEtiqueta.UseVisualStyleBackColor = true;
            btnQuitarEtiqueta.Click += btnQuitarEtiqueta_Click;
            // 
            // listBoxIngrediente
            // 
            listBoxIngrediente.FormattingEnabled = true;
            listBoxIngrediente.ItemHeight = 15;
            listBoxIngrediente.Location = new Point(173, 21);
            listBoxIngrediente.Name = "listBoxIngrediente";
            listBoxIngrediente.Size = new Size(215, 169);
            listBoxIngrediente.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 205);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Etiquetas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnQuitarIngrediente);
            groupBox2.Controls.Add(btnAgregarIngrediente);
            groupBox2.Controls.Add(numCantidad);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBoxIngredientes);
            groupBox2.Controls.Add(listBoxIngrediente);
            groupBox2.Location = new Point(320, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 205);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingredientes";
            // 
            // btnQuitarIngrediente
            // 
            btnQuitarIngrediente.Location = new Point(92, 124);
            btnQuitarIngrediente.Name = "btnQuitarIngrediente";
            btnQuitarIngrediente.Size = new Size(75, 23);
            btnQuitarIngrediente.TabIndex = 16;
            btnQuitarIngrediente.Text = "Quitar";
            btnQuitarIngrediente.UseVisualStyleBackColor = true;
            btnQuitarIngrediente.Click += btnQuitarIngrediente_Click;
            // 
            // btnAgregarIngrediente
            // 
            btnAgregarIngrediente.Location = new Point(92, 95);
            btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            btnAgregarIngrediente.Size = new Size(75, 23);
            btnAgregarIngrediente.TabIndex = 15;
            btnAgregarIngrediente.Text = "Añadir";
            btnAgregarIngrediente.UseVisualStyleBackColor = true;
            btnAgregarIngrediente.Click += btnAgregarIngrediente_Click;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(6, 66);
            numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(161, 23);
            numCantidad.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 13;
            label4.Text = "Cantidad:";
            // 
            // comboBoxIngredientes
            // 
            comboBoxIngredientes.FormattingEnabled = true;
            comboBoxIngredientes.Location = new Point(6, 22);
            comboBoxIngredientes.Name = "comboBoxIngredientes";
            comboBoxIngredientes.Size = new Size(161, 23);
            comboBoxIngredientes.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(dataGridViewPasos);
            groupBox3.Location = new Point(320, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(462, 245);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pasos";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(381, 215);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridViewPasos
            // 
            dataGridViewPasos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPasos.Columns.AddRange(new DataGridViewColumn[] { Descripcion });
            dataGridViewPasos.Location = new Point(6, 22);
            dataGridViewPasos.Name = "dataGridViewPasos";
            dataGridViewPasos.RowTemplate.Height = 25;
            dataGridViewPasos.Size = new Size(450, 190);
            dataGridViewPasos.TabIndex = 0;
            // 
            // Descripcion
            // 
            Descripcion.Frozen = true;
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 407;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(720, 406);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(720, 435);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // RecetasAltaModificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnQuitarEtiqueta);
            Controls.Add(comboBoxEtiquetas);
            Controls.Add(btnAgregarEtiqueta);
            Controls.Add(listBoxEtiquetas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Controls.Add(txtDescripcion);
            Controls.Add(groupBox1);
            Name = "RecetasAltaModificacion";
            Text = "Nueva receta";
            Load += RecetasAltaModificacion_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private TextBox txtTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBoxEtiquetas;
        private Button btnAgregarEtiqueta;
        private ComboBox comboBoxEtiquetas;
        private Button btnQuitarEtiqueta;
        private ListBox listBoxIngrediente;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAgregarIngrediente;
        private NumericUpDown numCantidad;
        private Label label4;
        private ComboBox comboBoxIngredientes;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnQuitarIngrediente;
        private DataGridView dataGridViewPasos;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Descripcion;
    }
}