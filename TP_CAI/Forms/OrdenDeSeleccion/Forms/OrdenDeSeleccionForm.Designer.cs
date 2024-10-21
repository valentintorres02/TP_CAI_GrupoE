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
            LimpiarButton = new Button();
            BuscarButton = new Button();
            PrioridadCombobox = new ComboBox();
            ClienteCombobox = new ComboBox();
            FechaEntregaDatePicker = new DateTimePicker();
            LimpiarFiltroButton = new Button();
            PrioridadLbl = new Label();
            Clientelbl = new Label();
            FcehaEntregalbl = new Label();
            SeleccionarTodoButton = new Button();
            OrdenesGroup = new GroupBox();
            SeleccionarTodoButton2 = new Button();
            LimpiarButton2 = new Button();
            OrdenesPreparacionSeleccionadasListView = new ListView();
            IdOrden2 = new ColumnHeader();
            Prioridad2 = new ColumnHeader();
            DocumentoCliente2 = new ColumnHeader();
            FechaEntrega2 = new ColumnHeader();
            EliminarProductoButton = new Button();
            label6 = new Label();
            AgregarALaOrdenButton = new Button();
            label4 = new Label();
            OrdenesPreparacionPendientesListView = new ListView();
            IdOrden = new ColumnHeader();
            Prioridad = new ColumnHeader();
            DocumentoCliente = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            FiltrosGroup = new GroupBox();
            CrearOrdenButton = new Button();
            VolverButton = new Button();
            OrdenesGroup.SuspendLayout();
            FiltrosGroup.SuspendLayout();
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
            // LimpiarButton
            // 
            LimpiarButton.Location = new Point(480, 332);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(99, 31);
            LimpiarButton.TabIndex = 5;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            LimpiarButton.Click += LimpiarButton_Click;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(861, 19);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(162, 40);
            BuscarButton.TabIndex = 7;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += FiltrarButton_Click;
            // 
            // PrioridadCombobox
            // 
            PrioridadCombobox.FormattingEnabled = true;
            PrioridadCombobox.Location = new Point(4, 36);
            PrioridadCombobox.Name = "PrioridadCombobox";
            PrioridadCombobox.Size = new Size(267, 23);
            PrioridadCombobox.TabIndex = 8;
            // 
            // ClienteCombobox
            // 
            ClienteCombobox.FormattingEnabled = true;
            ClienteCombobox.Location = new Point(275, 36);
            ClienteCombobox.Name = "ClienteCombobox";
            ClienteCombobox.Size = new Size(313, 23);
            ClienteCombobox.TabIndex = 9;
            // 
            // FechaEntregaDatePicker
            // 
            FechaEntregaDatePicker.Format = DateTimePickerFormat.Short;
            FechaEntregaDatePicker.Location = new Point(594, 36);
            FechaEntregaDatePicker.Name = "FechaEntregaDatePicker";
            FechaEntregaDatePicker.ShowCheckBox = true;
            FechaEntregaDatePicker.Size = new Size(261, 23);
            FechaEntregaDatePicker.TabIndex = 11;
            FechaEntregaDatePicker.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // LimpiarFiltroButton
            // 
            LimpiarFiltroButton.Location = new Point(1029, 18);
            LimpiarFiltroButton.Name = "LimpiarFiltroButton";
            LimpiarFiltroButton.Size = new Size(156, 41);
            LimpiarFiltroButton.TabIndex = 12;
            LimpiarFiltroButton.Text = "Limpiar";
            LimpiarFiltroButton.UseVisualStyleBackColor = true;
            LimpiarFiltroButton.Click += LimpiarFiltroButton_Click;
            // 
            // PrioridadLbl
            // 
            PrioridadLbl.AutoSize = true;
            PrioridadLbl.Location = new Point(6, 19);
            PrioridadLbl.Name = "PrioridadLbl";
            PrioridadLbl.Size = new Size(55, 15);
            PrioridadLbl.TabIndex = 13;
            PrioridadLbl.Text = "Prioridad";
            // 
            // Clientelbl
            // 
            Clientelbl.AutoSize = true;
            Clientelbl.Location = new Point(275, 19);
            Clientelbl.Name = "Clientelbl";
            Clientelbl.Size = new Size(44, 15);
            Clientelbl.TabIndex = 14;
            Clientelbl.Text = "Cliente";
            // 
            // FcehaEntregalbl
            // 
            FcehaEntregalbl.AutoSize = true;
            FcehaEntregalbl.Location = new Point(594, 18);
            FcehaEntregalbl.Name = "FcehaEntregalbl";
            FcehaEntregalbl.Size = new Size(97, 15);
            FcehaEntregalbl.TabIndex = 16;
            FcehaEntregalbl.Text = "Fecha de Entrega";
            // 
            // SeleccionarTodoButton
            // 
            SeleccionarTodoButton.Location = new Point(297, 332);
            SeleccionarTodoButton.Name = "SeleccionarTodoButton";
            SeleccionarTodoButton.Size = new Size(177, 31);
            SeleccionarTodoButton.TabIndex = 17;
            SeleccionarTodoButton.Text = "Seleccionar Todo";
            SeleccionarTodoButton.UseVisualStyleBackColor = true;
            SeleccionarTodoButton.Click += SeleccionarTodoButton_Click;
            // 
            // OrdenesGroup
            // 
            OrdenesGroup.Controls.Add(SeleccionarTodoButton2);
            OrdenesGroup.Controls.Add(LimpiarButton2);
            OrdenesGroup.Controls.Add(OrdenesPreparacionSeleccionadasListView);
            OrdenesGroup.Controls.Add(SeleccionarTodoButton);
            OrdenesGroup.Controls.Add(EliminarProductoButton);
            OrdenesGroup.Controls.Add(label6);
            OrdenesGroup.Controls.Add(AgregarALaOrdenButton);
            OrdenesGroup.Controls.Add(label4);
            OrdenesGroup.Controls.Add(OrdenesPreparacionPendientesListView);
            OrdenesGroup.Controls.Add(LimpiarButton);
            OrdenesGroup.Location = new Point(9, 104);
            OrdenesGroup.Name = "OrdenesGroup";
            OrdenesGroup.Size = new Size(1190, 372);
            OrdenesGroup.TabIndex = 18;
            OrdenesGroup.TabStop = false;
            OrdenesGroup.Text = "Órdenes";
            // 
            // SeleccionarTodoButton2
            // 
            SeleccionarTodoButton2.Location = new Point(897, 332);
            SeleccionarTodoButton2.Name = "SeleccionarTodoButton2";
            SeleccionarTodoButton2.Size = new Size(177, 31);
            SeleccionarTodoButton2.TabIndex = 20;
            SeleccionarTodoButton2.Text = "Seleccionar Todo";
            SeleccionarTodoButton2.UseVisualStyleBackColor = true;
            SeleccionarTodoButton2.Click += SeleccionarTodoButton2_Click;
            // 
            // LimpiarButton2
            // 
            LimpiarButton2.Location = new Point(1080, 332);
            LimpiarButton2.Name = "LimpiarButton2";
            LimpiarButton2.Size = new Size(99, 31);
            LimpiarButton2.TabIndex = 19;
            LimpiarButton2.Text = "Limpiar";
            LimpiarButton2.UseVisualStyleBackColor = true;
            LimpiarButton2.Click += LimpiarButton2_Click;
            // 
            // OrdenesPreparacionSeleccionadasListView
            // 
            OrdenesPreparacionSeleccionadasListView.CheckBoxes = true;
            OrdenesPreparacionSeleccionadasListView.Columns.AddRange(new ColumnHeader[] { IdOrden2, Prioridad2, DocumentoCliente2, FechaEntrega2 });
            OrdenesPreparacionSeleccionadasListView.Location = new Point(606, 37);
            OrdenesPreparacionSeleccionadasListView.Name = "OrdenesPreparacionSeleccionadasListView";
            OrdenesPreparacionSeleccionadasListView.Size = new Size(573, 289);
            OrdenesPreparacionSeleccionadasListView.TabIndex = 18;
            OrdenesPreparacionSeleccionadasListView.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionSeleccionadasListView.View = View.Details;
            // 
            // IdOrden2
            // 
            IdOrden2.Text = "ID";
            IdOrden2.Width = 90;
            // 
            // Prioridad2
            // 
            Prioridad2.Text = "Prioridad";
            Prioridad2.Width = 100;
            // 
            // DocumentoCliente2
            // 
            DocumentoCliente2.Text = "CUIT/CUIL Cliente";
            DocumentoCliente2.Width = 240;
            // 
            // FechaEntrega2
            // 
            FechaEntrega2.Text = "Fecha de Entrega";
            FechaEntrega2.Width = 130;
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Location = new Point(606, 332);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(285, 31);
            EliminarProductoButton.TabIndex = 7;
            EliminarProductoButton.Text = "Eliminar de la Orden de Selección";
            EliminarProductoButton.UseVisualStyleBackColor = true;
            EliminarProductoButton.Click += EliminarProductoButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(606, 19);
            label6.Name = "label6";
            label6.Size = new Size(377, 15);
            label6.TabIndex = 6;
            label6.Text = "Órdenes de Preparación seleccionadas en la Orden de Selección actual";
            // 
            // AgregarALaOrdenButton
            // 
            AgregarALaOrdenButton.Location = new Point(6, 332);
            AgregarALaOrdenButton.Name = "AgregarALaOrdenButton";
            AgregarALaOrdenButton.Size = new Size(285, 31);
            AgregarALaOrdenButton.TabIndex = 4;
            AgregarALaOrdenButton.Text = "Agregar a la Orden de Selección";
            AgregarALaOrdenButton.UseVisualStyleBackColor = true;
            AgregarALaOrdenButton.Click += AgregarALaOrdenButton_Click;
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
            // OrdenesPreparacionPendientesListView
            // 
            OrdenesPreparacionPendientesListView.CheckBoxes = true;
            OrdenesPreparacionPendientesListView.Columns.AddRange(new ColumnHeader[] { IdOrden, Prioridad, DocumentoCliente, FechaEntrega });
            OrdenesPreparacionPendientesListView.Location = new Point(6, 37);
            OrdenesPreparacionPendientesListView.Name = "OrdenesPreparacionPendientesListView";
            OrdenesPreparacionPendientesListView.Size = new Size(573, 289);
            OrdenesPreparacionPendientesListView.TabIndex = 0;
            OrdenesPreparacionPendientesListView.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionPendientesListView.View = View.Details;
            // 
            // IdOrden
            // 
            IdOrden.Text = "ID";
            IdOrden.Width = 90;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 100;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.Text = "CUIT/CUIL Cliente";
            DocumentoCliente.Width = 240;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.Width = 130;
            // 
            // FiltrosGroup
            // 
            FiltrosGroup.Controls.Add(PrioridadLbl);
            FiltrosGroup.Controls.Add(PrioridadCombobox);
            FiltrosGroup.Controls.Add(Clientelbl);
            FiltrosGroup.Controls.Add(ClienteCombobox);
            FiltrosGroup.Controls.Add(LimpiarFiltroButton);
            FiltrosGroup.Controls.Add(FcehaEntregalbl);
            FiltrosGroup.Controls.Add(BuscarButton);
            FiltrosGroup.Controls.Add(FechaEntregaDatePicker);
            FiltrosGroup.Location = new Point(9, 33);
            FiltrosGroup.Name = "FiltrosGroup";
            FiltrosGroup.Size = new Size(1190, 65);
            FiltrosGroup.TabIndex = 21;
            FiltrosGroup.TabStop = false;
            FiltrosGroup.Text = "Filtros";
            // 
            // CrearOrdenButton
            // 
            CrearOrdenButton.Location = new Point(9, 497);
            CrearOrdenButton.Name = "CrearOrdenButton";
            CrearOrdenButton.Size = new Size(587, 103);
            CrearOrdenButton.TabIndex = 19;
            CrearOrdenButton.Text = "Crear Orden de Selección";
            CrearOrdenButton.UseVisualStyleBackColor = true;
            CrearOrdenButton.Click += CrearOrdenButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(602, 497);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(586, 103);
            VolverButton.TabIndex = 18;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 618);
            Controls.Add(FiltrosGroup);
            Controls.Add(CrearOrdenButton);
            Controls.Add(VolverButton);
            Controls.Add(OrdenesGroup);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "OrdenDeSeleccionForm";
            Text = "Crear Orden de Selección";
            Load += OrdenDeSeleccionForm_Load;
            OrdenesGroup.ResumeLayout(false);
            OrdenesGroup.PerformLayout();
            FiltrosGroup.ResumeLayout(false);
            FiltrosGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LimpiarButton;
		private Button BuscarButton;
		private ComboBox PrioridadCombobox;
		private ComboBox ClienteCombobox;
		private DateTimePicker FechaEntregaDatePicker;
		private Button LimpiarFiltroButton;
		private Label PrioridadLbl;
		private Label Clientelbl;
		private Label FcehaEntregalbl;
		private Button SeleccionarTodoButton;
        private GroupBox OrdenesGroup;
        private Button EliminarProductoButton;
        private Label label6;
        private Button AgregarALaOrdenButton;
        private Label label4;
        private ListView OrdenesPreparacionPendientesListView;
        private ColumnHeader IdOrden;
        private ColumnHeader DocumentoCliente;
        private Button CrearOrdenButton;
        private Button VolverButton;
        private ColumnHeader Prioridad;
        private ColumnHeader FechaEntrega;
        private ListView OrdenesPreparacionSeleccionadasListView;
        private ColumnHeader IdOrden2;
        private ColumnHeader Prioridad2;
        private ColumnHeader DocumentoCliente2;
        private ColumnHeader FechaEntrega2;
        private Button SeleccionarTodoButton2;
        private Button LimpiarButton2;
        private GroupBox FiltrosGroup;
    }
}