namespace TP_CAI.Archivos.OrdenDeSeleccion.Forms
{
    partial class OrdenDeSeleccionForm
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
            label1 = new Label();
            VolverAlMenuButton = new Button();
            LimpiarButton = new Button();
            FiltrarButton = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            LimpiarFiltroButton = new Button();
            PrioridadLbl = new Label();
            Clientelbl = new Label();
            FcehaEntregalbl = new Label();
            SeleccionarTodoButton = new Button();
            ProductosGroup = new GroupBox();
            EliminarProductoButton = new Button();
            label6 = new Label();
            AgregarProductoButton = new Button();
            label4 = new Label();
            ProductosDisponiblesListView = new ListView();
            IdOrden = new ColumnHeader();
            DocumentoCliente = new ColumnHeader();
            CrearOrdenButton = new Button();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            ProductosGroup.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 21);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar órdenes de preparación";
            // 
            // VolverAlMenuButton
            // 
            VolverAlMenuButton.Location = new Point(72, 722);
            VolverAlMenuButton.Name = "VolverAlMenuButton";
            VolverAlMenuButton.Size = new Size(144, 23);
            VolverAlMenuButton.TabIndex = 4;
            VolverAlMenuButton.Text = "Volver al Menú Principal";
            VolverAlMenuButton.UseVisualStyleBackColor = true;
            VolverAlMenuButton.Click += VolverAlMenuButton_Click;
            // 
            // LimpiarButton
            // 
            LimpiarButton.Location = new Point(420, 332);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(79, 31);
            LimpiarButton.TabIndex = 5;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            LimpiarButton.Click += LimpiarButton_Click;
            // 
            // FiltrarButton
            // 
            FiltrarButton.Location = new Point(709, 40);
            FiltrarButton.Name = "FiltrarButton";
            FiltrarButton.Size = new Size(162, 40);
            FiltrarButton.TabIndex = 7;
            FiltrarButton.Text = "Filtrar";
            FiltrarButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 23);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(227, 57);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(233, 23);
            comboBox2.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(466, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(237, 23);
            dateTimePicker2.TabIndex = 11;
            dateTimePicker2.Value = new DateTime(2024, 10, 13, 14, 14, 1, 0);
            // 
            // LimpiarFiltroButton
            // 
            LimpiarFiltroButton.Location = new Point(877, 39);
            LimpiarFiltroButton.Name = "LimpiarFiltroButton";
            LimpiarFiltroButton.Size = new Size(162, 41);
            LimpiarFiltroButton.TabIndex = 12;
            LimpiarFiltroButton.Text = "Limpiar";
            LimpiarFiltroButton.UseVisualStyleBackColor = true;
            // 
            // PrioridadLbl
            // 
            PrioridadLbl.AutoSize = true;
            PrioridadLbl.Location = new Point(12, 40);
            PrioridadLbl.Name = "PrioridadLbl";
            PrioridadLbl.Size = new Size(55, 15);
            PrioridadLbl.TabIndex = 13;
            PrioridadLbl.Text = "Prioridad";
            // 
            // Clientelbl
            // 
            Clientelbl.AutoSize = true;
            Clientelbl.Location = new Point(227, 40);
            Clientelbl.Name = "Clientelbl";
            Clientelbl.Size = new Size(44, 15);
            Clientelbl.TabIndex = 14;
            Clientelbl.Text = "Cliente";
            // 
            // FcehaEntregalbl
            // 
            FcehaEntregalbl.AutoSize = true;
            FcehaEntregalbl.Location = new Point(466, 39);
            FcehaEntregalbl.Name = "FcehaEntregalbl";
            FcehaEntregalbl.Size = new Size(97, 15);
            FcehaEntregalbl.TabIndex = 16;
            FcehaEntregalbl.Text = "Fecha de Entrega";
            // 
            // SeleccionarTodoButton
            // 
            SeleccionarTodoButton.Location = new Point(274, 332);
            SeleccionarTodoButton.Name = "SeleccionarTodoButton";
            SeleccionarTodoButton.Size = new Size(140, 31);
            SeleccionarTodoButton.TabIndex = 17;
            SeleccionarTodoButton.Text = "Seleccionar Todo";
            SeleccionarTodoButton.UseVisualStyleBackColor = true;
            // 
            // ProductosGroup
            // 
            ProductosGroup.Controls.Add(listView1);
            ProductosGroup.Controls.Add(SeleccionarTodoButton);
            ProductosGroup.Controls.Add(EliminarProductoButton);
            ProductosGroup.Controls.Add(label6);
            ProductosGroup.Controls.Add(AgregarProductoButton);
            ProductosGroup.Controls.Add(label4);
            ProductosGroup.Controls.Add(ProductosDisponiblesListView);
            ProductosGroup.Controls.Add(LimpiarButton);
            ProductosGroup.Location = new Point(9, 96);
            ProductosGroup.Name = "ProductosGroup";
            ProductosGroup.Size = new Size(1030, 372);
            ProductosGroup.TabIndex = 18;
            ProductosGroup.TabStop = false;
            ProductosGroup.Text = "Órdenes seleccionadas";
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Enabled = false;
            EliminarProductoButton.Location = new Point(529, 336);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(496, 27);
            EliminarProductoButton.TabIndex = 7;
            EliminarProductoButton.Text = "Eliminar de la Orden de Selección";
            EliminarProductoButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(529, 19);
            label6.Name = "label6";
            label6.Size = new Size(377, 15);
            label6.TabIndex = 6;
            label6.Text = "Órdenes de Preparación seleccionadas en la Orden de Selección actual";
            // 
            // AgregarProductoButton
            // 
            AgregarProductoButton.Enabled = false;
            AgregarProductoButton.Location = new Point(6, 332);
            AgregarProductoButton.Name = "AgregarProductoButton";
            AgregarProductoButton.Size = new Size(262, 31);
            AgregarProductoButton.TabIndex = 4;
            AgregarProductoButton.Text = "Agregar a la Orden de Selección";
            AgregarProductoButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(194, 15);
            label4.TabIndex = 1;
            label4.Text = "Órdenes de Preparacion pendientes";
            // 
            // ProductosDisponiblesListView
            // 
            ProductosDisponiblesListView.Columns.AddRange(new ColumnHeader[] { IdOrden, DocumentoCliente });
            ProductosDisponiblesListView.Location = new Point(6, 37);
            ProductosDisponiblesListView.Name = "ProductosDisponiblesListView";
            ProductosDisponiblesListView.Size = new Size(493, 289);
            ProductosDisponiblesListView.TabIndex = 0;
            ProductosDisponiblesListView.UseCompatibleStateImageBehavior = false;
            ProductosDisponiblesListView.View = View.Details;
            // 
            // IdOrden
            // 
            IdOrden.Text = "ID";
            IdOrden.Width = 230;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.Text = "CUIT/CUIL Cliente";
            DocumentoCliente.Width = 250;
            // 
            // CrearOrdenButton
            // 
            CrearOrdenButton.Enabled = false;
            CrearOrdenButton.Location = new Point(9, 489);
            CrearOrdenButton.Name = "CrearOrdenButton";
            CrearOrdenButton.Size = new Size(513, 103);
            CrearOrdenButton.TabIndex = 19;
            CrearOrdenButton.Text = "Crear Orden de Selección";
            CrearOrdenButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(528, 489);
            button1.Name = "button1";
            button1.Size = new Size(511, 103);
            button1.TabIndex = 18;
            button1.Text = "Volver al Menú Principal";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(532, 37);
            listView1.Name = "listView1";
            listView1.Size = new Size(493, 289);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "CUIT/CUIL Cliente";
            columnHeader2.Width = 250;
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 606);
            Controls.Add(CrearOrdenButton);
            Controls.Add(button1);
            Controls.Add(ProductosGroup);
            Controls.Add(FcehaEntregalbl);
            Controls.Add(Clientelbl);
            Controls.Add(PrioridadLbl);
            Controls.Add(LimpiarFiltroButton);
            Controls.Add(dateTimePicker2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(FiltrarButton);
            Controls.Add(VolverAlMenuButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "OrdenDeSeleccionForm";
            Text = "Crear Orden de Selección";
            Load += OrdenDeSeleccionForm_Load;
            ProductosGroup.ResumeLayout(false);
            ProductosGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button VolverAlMenuButton;
        private Button LimpiarButton;
		private Button FiltrarButton;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private DateTimePicker dateTimePicker2;
		private Button LimpiarFiltroButton;
		private Label PrioridadLbl;
		private Label Clientelbl;
		private Label FcehaEntregalbl;
		private Button SeleccionarTodoButton;
        private GroupBox ProductosGroup;
        private Button EliminarProductoButton;
        private Label label6;
        private Button AgregarProductoButton;
        private Label label4;
        private ListView ProductosDisponiblesListView;
        private ColumnHeader IdOrden;
        private ColumnHeader DocumentoCliente;
        private Button CrearOrdenButton;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}