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
            PrioridadCombobox = new ComboBox();
            ClienteCombobox = new ComboBox();
            FechaEntregaCombobox = new DateTimePicker();
            LimpiarFiltroButton = new Button();
            PrioridadLbl = new Label();
            Clientelbl = new Label();
            FcehaEntregalbl = new Label();
            SeleccionarTodoButton = new Button();
            OrdenesGroup = new GroupBox();
            EliminarProductoButton = new Button();
            label6 = new Label();
            AgregarProductoButton = new Button();
            label4 = new Label();
            OrdenesPreparacionPendientesListView = new ListView();
            IdOrden = new ColumnHeader();
            DocumentoCliente = new ColumnHeader();
            CrearOrdenButton = new Button();
            VolverButton = new Button();
            Prioridad = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            OrdenesPreparacionSeleccionadasListView = new ListView();
            IdOrden2 = new ColumnHeader();
            Prioridad2 = new ColumnHeader();
            DocumentoCliente2 = new ColumnHeader();
            FechaEntrega2 = new ColumnHeader();
            EliminarTodoButton = new Button();
            OrdenesGroup.SuspendLayout();
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
            LimpiarButton.Location = new Point(480, 332);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(99, 31);
            LimpiarButton.TabIndex = 5;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            LimpiarButton.Click += LimpiarButton_Click;
            // 
            // FiltrarButton
            // 
            FiltrarButton.Location = new Point(869, 40);
            FiltrarButton.Name = "FiltrarButton";
            FiltrarButton.Size = new Size(162, 40);
            FiltrarButton.TabIndex = 7;
            FiltrarButton.Text = "Filtrar";
            FiltrarButton.UseVisualStyleBackColor = true;
            // 
            // PrioridadCombobox
            // 
            PrioridadCombobox.FormattingEnabled = true;
            PrioridadCombobox.Location = new Point(10, 57);
            PrioridadCombobox.Name = "PrioridadCombobox";
            PrioridadCombobox.Size = new Size(267, 23);
            PrioridadCombobox.TabIndex = 8;
            // 
            // ClienteCombobox
            // 
            ClienteCombobox.FormattingEnabled = true;
            ClienteCombobox.Location = new Point(283, 57);
            ClienteCombobox.Name = "ClienteCombobox";
            ClienteCombobox.Size = new Size(313, 23);
            ClienteCombobox.TabIndex = 9;
            // 
            // FechaEntregaCombobox
            // 
            FechaEntregaCombobox.Format = DateTimePickerFormat.Short;
            FechaEntregaCombobox.Location = new Point(602, 57);
            FechaEntregaCombobox.Name = "FechaEntregaCombobox";
            FechaEntregaCombobox.Size = new Size(261, 23);
            FechaEntregaCombobox.TabIndex = 11;
            FechaEntregaCombobox.Value = new DateTime(2024, 10, 13, 14, 14, 1, 0);
            // 
            // LimpiarFiltroButton
            // 
            LimpiarFiltroButton.Location = new Point(1037, 39);
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
            Clientelbl.Location = new Point(283, 40);
            Clientelbl.Name = "Clientelbl";
            Clientelbl.Size = new Size(44, 15);
            Clientelbl.TabIndex = 14;
            Clientelbl.Text = "Cliente";
            // 
            // FcehaEntregalbl
            // 
            FcehaEntregalbl.AutoSize = true;
            FcehaEntregalbl.Location = new Point(602, 39);
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
            // 
            // OrdenesGroup
            // 
            OrdenesGroup.Controls.Add(EliminarTodoButton);
            OrdenesGroup.Controls.Add(OrdenesPreparacionSeleccionadasListView);
            OrdenesGroup.Controls.Add(SeleccionarTodoButton);
            OrdenesGroup.Controls.Add(EliminarProductoButton);
            OrdenesGroup.Controls.Add(label6);
            OrdenesGroup.Controls.Add(AgregarProductoButton);
            OrdenesGroup.Controls.Add(label4);
            OrdenesGroup.Controls.Add(OrdenesPreparacionPendientesListView);
            OrdenesGroup.Controls.Add(LimpiarButton);
            OrdenesGroup.Location = new Point(9, 96);
            OrdenesGroup.Name = "OrdenesGroup";
            OrdenesGroup.Size = new Size(1190, 372);
            OrdenesGroup.TabIndex = 18;
            OrdenesGroup.TabStop = false;
            OrdenesGroup.Text = "Órdenes";
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Enabled = false;
            EliminarProductoButton.Location = new Point(606, 332);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(390, 31);
            EliminarProductoButton.TabIndex = 7;
            EliminarProductoButton.Text = "Eliminar de la Orden de Selección";
            EliminarProductoButton.UseVisualStyleBackColor = true;
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
            // AgregarProductoButton
            // 
            AgregarProductoButton.Enabled = false;
            AgregarProductoButton.Location = new Point(6, 332);
            AgregarProductoButton.Name = "AgregarProductoButton";
            AgregarProductoButton.Size = new Size(285, 31);
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
            // OrdenesPreparacionPendientesListView
            // 
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
            // DocumentoCliente
            // 
            DocumentoCliente.Text = "CUIT/CUIL Cliente";
            DocumentoCliente.Width = 240;
            // 
            // CrearOrdenButton
            // 
            CrearOrdenButton.Enabled = false;
            CrearOrdenButton.Location = new Point(9, 489);
            CrearOrdenButton.Name = "CrearOrdenButton";
            CrearOrdenButton.Size = new Size(587, 103);
            CrearOrdenButton.TabIndex = 19;
            CrearOrdenButton.Text = "Crear Orden de Selección";
            CrearOrdenButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(602, 489);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(586, 103);
            VolverButton.TabIndex = 18;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 100;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.Width = 130;
            // 
            // OrdenesPreparacionSeleccionadasListView
            // 
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
            // EliminarTodoButton
            // 
            EliminarTodoButton.Location = new Point(1002, 332);
            EliminarTodoButton.Name = "EliminarTodoButton";
            EliminarTodoButton.Size = new Size(177, 31);
            EliminarTodoButton.TabIndex = 19;
            EliminarTodoButton.Text = "Eliminar Todo";
            EliminarTodoButton.UseVisualStyleBackColor = true;
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 606);
            Controls.Add(CrearOrdenButton);
            Controls.Add(VolverButton);
            Controls.Add(OrdenesGroup);
            Controls.Add(FcehaEntregalbl);
            Controls.Add(Clientelbl);
            Controls.Add(PrioridadLbl);
            Controls.Add(LimpiarFiltroButton);
            Controls.Add(FechaEntregaCombobox);
            Controls.Add(ClienteCombobox);
            Controls.Add(PrioridadCombobox);
            Controls.Add(FiltrarButton);
            Controls.Add(VolverAlMenuButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "OrdenDeSeleccionForm";
            Text = "Crear Orden de Selección";
            Load += OrdenDeSeleccionForm_Load;
            OrdenesGroup.ResumeLayout(false);
            OrdenesGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button VolverAlMenuButton;
        private Button LimpiarButton;
		private Button FiltrarButton;
		private ComboBox PrioridadCombobox;
		private ComboBox ClienteCombobox;
		private DateTimePicker FechaEntregaCombobox;
		private Button LimpiarFiltroButton;
		private Label PrioridadLbl;
		private Label Clientelbl;
		private Label FcehaEntregalbl;
		private Button SeleccionarTodoButton;
        private GroupBox OrdenesGroup;
        private Button EliminarProductoButton;
        private Label label6;
        private Button AgregarProductoButton;
        private Label label4;
        private ListView OrdenesPreparacionPendientesListView;
        private ColumnHeader IdOrden;
        private ColumnHeader DocumentoCliente;
        private Button CrearOrdenButton;
        private Button VolverButton;
        private ColumnHeader Prioridad;
        private ColumnHeader FechaEntrega;
        private Button EliminarTodoButton;
        private ListView OrdenesPreparacionSeleccionadasListView;
        private ColumnHeader IdOrden2;
        private ColumnHeader Prioridad2;
        private ColumnHeader DocumentoCliente2;
        private ColumnHeader FechaEntrega2;
    }
}