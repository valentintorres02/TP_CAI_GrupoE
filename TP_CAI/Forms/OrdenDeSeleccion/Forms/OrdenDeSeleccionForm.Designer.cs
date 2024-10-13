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
            GenerarOrdenButton = new Button();
            VolverAlMenuButton = new Button();
            LimpiarButton = new Button();
            OrdenesPreparacionListView = new ListView();
            IdOrdenPreparacion = new ColumnHeader();
            Prioridad = new ColumnHeader();
            FechaCreacion = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            Cliente = new ColumnHeader();
            FiltrarButton = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            LimpiarFiltroButton = new Button();
            PrioridadLbl = new Label();
            Clientelbl = new Label();
            FechaCreacionLbl = new Label();
            FcehaEntregalbl = new Label();
            SeleccionarTodoButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 21);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar órdenes de preparación";
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(215, 236);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(454, 25);
            GenerarOrdenButton.TabIndex = 2;
            GenerarOrdenButton.Text = "Generar orden de selección";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click;
            // 
            // VolverAlMenuButton
            // 
            VolverAlMenuButton.Location = new Point(12, 275);
            VolverAlMenuButton.Name = "VolverAlMenuButton";
            VolverAlMenuButton.Size = new Size(144, 23);
            VolverAlMenuButton.TabIndex = 4;
            VolverAlMenuButton.Text = "Volver al Menú Principal";
            VolverAlMenuButton.UseVisualStyleBackColor = true;
            VolverAlMenuButton.Click += VolverAlMenuButton_Click;
            // 
            // LimpiarButton
            // 
            LimpiarButton.Location = new Point(12, 236);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(79, 23);
            LimpiarButton.TabIndex = 5;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            LimpiarButton.Click += LimpiarButton_Click;
            // 
            // OrdenesPreparacionListView
            // 
            OrdenesPreparacionListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, Prioridad, FechaCreacion, FechaEntrega, Cliente });
            OrdenesPreparacionListView.Location = new Point(12, 89);
            OrdenesPreparacionListView.Name = "OrdenesPreparacionListView";
            OrdenesPreparacionListView.Size = new Size(657, 141);
            OrdenesPreparacionListView.TabIndex = 6;
            OrdenesPreparacionListView.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionListView.View = View.Details;
            // 
            // IdOrdenPreparacion
            // 
            IdOrdenPreparacion.Text = "ID Orden";
            IdOrdenPreparacion.Width = 80;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 120;
            // 
            // FechaCreacion
            // 
            FechaCreacion.Text = "Fecha de Creacion";
            FechaCreacion.Width = 150;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.Width = 150;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 200;
            // 
            // FiltrarButton
            // 
            FiltrarButton.Location = new Point(594, 52);
            FiltrarButton.Name = "FiltrarButton";
            FiltrarButton.Size = new Size(75, 23);
            FiltrarButton.TabIndex = 7;
            FiltrarButton.Text = "Filtrar";
            FiltrarButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(128, 52);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 23);
            comboBox2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(303, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(101, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.Value = new DateTime(2024, 10, 13, 14, 13, 45, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(410, 53);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(99, 23);
            dateTimePicker2.TabIndex = 11;
            dateTimePicker2.Value = new DateTime(2024, 10, 13, 14, 14, 1, 0);
            // 
            // LimpiarFiltroButton
            // 
            LimpiarFiltroButton.Location = new Point(515, 53);
            LimpiarFiltroButton.Name = "LimpiarFiltroButton";
            LimpiarFiltroButton.Size = new Size(75, 23);
            LimpiarFiltroButton.TabIndex = 12;
            LimpiarFiltroButton.Text = "Limpiar";
            LimpiarFiltroButton.UseVisualStyleBackColor = true;
            // 
            // PrioridadLbl
            // 
            PrioridadLbl.AutoSize = true;
            PrioridadLbl.Location = new Point(14, 36);
            PrioridadLbl.Name = "PrioridadLbl";
            PrioridadLbl.Size = new Size(55, 15);
            PrioridadLbl.TabIndex = 13;
            PrioridadLbl.Text = "Prioridad";
            // 
            // Clientelbl
            // 
            Clientelbl.AutoSize = true;
            Clientelbl.Location = new Point(130, 35);
            Clientelbl.Name = "Clientelbl";
            Clientelbl.Size = new Size(44, 15);
            Clientelbl.TabIndex = 14;
            Clientelbl.Text = "Cliente";
            // 
            // FechaCreacionLbl
            // 
            FechaCreacionLbl.AutoSize = true;
            FechaCreacionLbl.Location = new Point(303, 35);
            FechaCreacionLbl.Name = "FechaCreacionLbl";
            FechaCreacionLbl.Size = new Size(96, 15);
            FechaCreacionLbl.TabIndex = 15;
            FechaCreacionLbl.Text = "Fecha de Ingreso";
            // 
            // FcehaEntregalbl
            // 
            FcehaEntregalbl.AutoSize = true;
            FcehaEntregalbl.Location = new Point(410, 35);
            FcehaEntregalbl.Name = "FcehaEntregalbl";
            FcehaEntregalbl.Size = new Size(97, 15);
            FcehaEntregalbl.TabIndex = 16;
            FcehaEntregalbl.Text = "Fecha de Entrega";
            // 
            // SeleccionarTodoButton
            // 
            SeleccionarTodoButton.Location = new Point(97, 236);
            SeleccionarTodoButton.Name = "SeleccionarTodoButton";
            SeleccionarTodoButton.Size = new Size(112, 23);
            SeleccionarTodoButton.TabIndex = 17;
            SeleccionarTodoButton.Text = "Seleecionar Todo";
            SeleccionarTodoButton.UseVisualStyleBackColor = true;
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 309);
            Controls.Add(SeleccionarTodoButton);
            Controls.Add(FcehaEntregalbl);
            Controls.Add(FechaCreacionLbl);
            Controls.Add(Clientelbl);
            Controls.Add(PrioridadLbl);
            Controls.Add(LimpiarFiltroButton);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(FiltrarButton);
            Controls.Add(OrdenesPreparacionListView);
            Controls.Add(LimpiarButton);
            Controls.Add(VolverAlMenuButton);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "OrdenDeSeleccionForm";
            Text = "Crear Orden de Selección";
            Load += OrdenDeSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GenerarOrdenButton;
        private Button VolverAlMenuButton;
        private Button LimpiarButton;
		private ListView OrdenesPreparacionListView;
		private Button FiltrarButton;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private DateTimePicker dateTimePicker1;
		private DateTimePicker dateTimePicker2;
		private Button LimpiarFiltroButton;
		private ColumnHeader IdOrdenPreparacion;
		private ColumnHeader Prioridad;
		private ColumnHeader FechaCreacion;
		private ColumnHeader FechaEntrega;
		private Label PrioridadLbl;
		private Label Clientelbl;
		private Label FechaCreacionLbl;
		private Label FcehaEntregalbl;
		private ColumnHeader Cliente;
		private Button SeleccionarTodoButton;
	}
}