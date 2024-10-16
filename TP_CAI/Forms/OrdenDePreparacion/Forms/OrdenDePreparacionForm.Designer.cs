namespace TP_CAI.Archivos.OrdenDePreparacion.Forms
{
    partial class OrdenDePreparacionForm
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
            ClienteCombobox = new ComboBox();
            label2 = new Label();
            DepositoCombobox = new ComboBox();
            label3 = new Label();
            ContinuarButton = new Button();
            VolverButton = new Button();
            ProductosGroup = new GroupBox();
            EliminarProductoButton = new Button();
            label6 = new Label();
            AgregarProductoButton = new Button();
            CantidadLabel = new Label();
            CantidadTextBox = new TextBox();
            label4 = new Label();
            ProductosDisponiblesListView = new ListView();
            IdProducto = new ColumnHeader();
            DescripcionProducto = new ColumnHeader();
            CantProducto = new ColumnHeader();
            InfoOrdenGroup = new GroupBox();
            FechaEntregaDatePicker = new DateTimePicker();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            DniTransportistaTextBox = new TextBox();
            PrioridadComboBox = new ComboBox();
            CrearOrdenButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ProductosAgregadosListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            EliminarTodoButton = new Button();
            ProductosGroup.SuspendLayout();
            InfoOrdenGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ClienteCombobox
            // 
            ClienteCombobox.FormattingEnabled = true;
            ClienteCombobox.Items.AddRange(new object[] { "GrupoE S.R.L. CUIT 20-44444444-4. ", "C.A.I S.A. CUIT 20-55555555-5" });
            ClienteCombobox.Location = new Point(12, 26);
            ClienteCombobox.Name = "ClienteCombobox";
            ClienteCombobox.Size = new Size(387, 23);
            ClienteCombobox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // DepositoCombobox
            // 
            DepositoCombobox.FormattingEnabled = true;
            DepositoCombobox.Items.AddRange(new object[] { "Deposito ID 5. Av. Cordoba 21211, CABA.", "Deposito ID 7. Belgrano 120, Córdoba." });
            DepositoCombobox.Location = new Point(405, 26);
            DepositoCombobox.Name = "DepositoCombobox";
            DepositoCombobox.Size = new Size(306, 23);
            DepositoCombobox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 8);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Depósito";
            // 
            // ContinuarButton
            // 
            ContinuarButton.Enabled = false;
            ContinuarButton.Location = new Point(717, 8);
            ContinuarButton.Name = "ContinuarButton";
            ContinuarButton.Size = new Size(325, 41);
            ContinuarButton.TabIndex = 5;
            ContinuarButton.Text = "Continuar";
            ContinuarButton.UseVisualStyleBackColor = true;
            ContinuarButton.Click += ContinuarButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(529, 561);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(513, 103);
            VolverButton.TabIndex = 6;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverAlMenuButton_Click;
            // 
            // ProductosGroup
            // 
            ProductosGroup.Controls.Add(EliminarTodoButton);
            ProductosGroup.Controls.Add(ProductosAgregadosListView);
            ProductosGroup.Controls.Add(EliminarProductoButton);
            ProductosGroup.Controls.Add(label6);
            ProductosGroup.Controls.Add(AgregarProductoButton);
            ProductosGroup.Controls.Add(CantidadLabel);
            ProductosGroup.Controls.Add(CantidadTextBox);
            ProductosGroup.Controls.Add(label4);
            ProductosGroup.Controls.Add(ProductosDisponiblesListView);
            ProductosGroup.Location = new Point(12, 80);
            ProductosGroup.Name = "ProductosGroup";
            ProductosGroup.Size = new Size(1030, 372);
            ProductosGroup.TabIndex = 7;
            ProductosGroup.TabStop = false;
            ProductosGroup.Text = "Productos";
            // 
            // EliminarProductoButton
            // 
            EliminarProductoButton.Enabled = false;
            EliminarProductoButton.Location = new Point(529, 336);
            EliminarProductoButton.Name = "EliminarProductoButton";
            EliminarProductoButton.Size = new Size(341, 27);
            EliminarProductoButton.TabIndex = 7;
            EliminarProductoButton.Text = "Eliminar producto seleccionado de la Orden";
            EliminarProductoButton.UseVisualStyleBackColor = true;
            EliminarProductoButton.Click += EliminarProductoButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(529, 19);
            label6.Name = "label6";
            label6.Size = new Size(260, 15);
            label6.TabIndex = 6;
            label6.Text = "Productos Agregados a la Orden de Preparación";
            // 
            // AgregarProductoButton
            // 
            AgregarProductoButton.Enabled = false;
            AgregarProductoButton.Location = new Point(234, 332);
            AgregarProductoButton.Name = "AgregarProductoButton";
            AgregarProductoButton.Size = new Size(265, 31);
            AgregarProductoButton.TabIndex = 4;
            AgregarProductoButton.Text = "Agregar Producto a la Orden";
            AgregarProductoButton.UseVisualStyleBackColor = true;
            AgregarProductoButton.Click += AgregarProductoButton_Click;
            // 
            // CantidadLabel
            // 
            CantidadLabel.AutoSize = true;
            CantidadLabel.Location = new Point(6, 343);
            CantidadLabel.Name = "CantidadLabel";
            CantidadLabel.Size = new Size(110, 15);
            CantidadLabel.TabIndex = 3;
            CantidadLabel.Text = "Cantidad a agregar:";
            // 
            // CantidadTextBox
            // 
            CantidadTextBox.Enabled = false;
            CantidadTextBox.Location = new Point(122, 340);
            CantidadTextBox.Name = "CantidadTextBox";
            CantidadTextBox.Size = new Size(106, 23);
            CantidadTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(279, 15);
            label4.TabIndex = 1;
            label4.Text = "Productos Disponibles en el Depósito Seleccionado:";
            // 
            // ProductosDisponiblesListView
            // 
            ProductosDisponiblesListView.Columns.AddRange(new ColumnHeader[] { IdProducto, DescripcionProducto, CantProducto });
            ProductosDisponiblesListView.Location = new Point(6, 37);
            ProductosDisponiblesListView.Name = "ProductosDisponiblesListView";
            ProductosDisponiblesListView.Size = new Size(493, 289);
            ProductosDisponiblesListView.TabIndex = 0;
            ProductosDisponiblesListView.UseCompatibleStateImageBehavior = false;
            ProductosDisponiblesListView.View = View.Details;
            // 
            // IdProducto
            // 
            IdProducto.Text = "ID";
            IdProducto.Width = 100;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.Text = "Descripcion Producto";
            DescripcionProducto.Width = 250;
            // 
            // CantProducto
            // 
            CantProducto.Text = "Cantidad";
            CantProducto.Width = 150;
            // 
            // InfoOrdenGroup
            // 
            InfoOrdenGroup.Controls.Add(FechaEntregaDatePicker);
            InfoOrdenGroup.Controls.Add(label1);
            InfoOrdenGroup.Controls.Add(label8);
            InfoOrdenGroup.Controls.Add(label7);
            InfoOrdenGroup.Controls.Add(DniTransportistaTextBox);
            InfoOrdenGroup.Controls.Add(PrioridadComboBox);
            InfoOrdenGroup.Location = new Point(12, 458);
            InfoOrdenGroup.Name = "InfoOrdenGroup";
            InfoOrdenGroup.Size = new Size(1030, 79);
            InfoOrdenGroup.TabIndex = 8;
            InfoOrdenGroup.TabStop = false;
            InfoOrdenGroup.Text = "Información de Orden de Preparación";
            // 
            // FechaEntregaDatePicker
            // 
            FechaEntregaDatePicker.Location = new Point(339, 40);
            FechaEntregaDatePicker.Name = "FechaEntregaDatePicker";
            FechaEntregaDatePicker.Size = new Size(316, 23);
            FechaEntregaDatePicker.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 22);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 11;
            label1.Text = "Fecha de entrega";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(661, 22);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 9;
            label8.Text = "DNI Transportista";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 22);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 10;
            label7.Text = "Prioridad";
            // 
            // DniTransportistaTextBox
            // 
            DniTransportistaTextBox.Location = new Point(661, 40);
            DniTransportistaTextBox.Name = "DniTransportistaTextBox";
            DniTransportistaTextBox.Size = new Size(363, 23);
            DniTransportistaTextBox.TabIndex = 8;
            // 
            // PrioridadComboBox
            // 
            PrioridadComboBox.FormattingEnabled = true;
            PrioridadComboBox.Items.AddRange(new object[] { "Baja", "Media", "Alta" });
            PrioridadComboBox.Location = new Point(6, 40);
            PrioridadComboBox.Name = "PrioridadComboBox";
            PrioridadComboBox.Size = new Size(327, 23);
            PrioridadComboBox.TabIndex = 9;
            // 
            // CrearOrdenButton
            // 
            CrearOrdenButton.Enabled = false;
            CrearOrdenButton.Location = new Point(12, 561);
            CrearOrdenButton.Name = "CrearOrdenButton";
            CrearOrdenButton.Size = new Size(511, 103);
            CrearOrdenButton.TabIndex = 9;
            CrearOrdenButton.Text = "Crear Orden de Preparación";
            CrearOrdenButton.UseVisualStyleBackColor = true;
            CrearOrdenButton.Click += CrearOrdenButton_Click;
            // 
            // ProductosAgregadosListView
            // 
            ProductosAgregadosListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            ProductosAgregadosListView.Location = new Point(529, 37);
            ProductosAgregadosListView.Name = "ProductosAgregadosListView";
            ProductosAgregadosListView.Size = new Size(493, 289);
            ProductosAgregadosListView.TabIndex = 8;
            ProductosAgregadosListView.UseCompatibleStateImageBehavior = false;
            ProductosAgregadosListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descripcion Producto";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cantidad";
            columnHeader3.Width = 150;
            // 
            // EliminarTodoButton
            // 
            EliminarTodoButton.Enabled = false;
            EliminarTodoButton.Location = new Point(876, 337);
            EliminarTodoButton.Name = "EliminarTodoButton";
            EliminarTodoButton.Size = new Size(146, 27);
            EliminarTodoButton.TabIndex = 9;
            EliminarTodoButton.Text = "Eliminar Todo";
            EliminarTodoButton.UseVisualStyleBackColor = true;
            // 
            // OrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 679);
            Controls.Add(CrearOrdenButton);
            Controls.Add(InfoOrdenGroup);
            Controls.Add(ProductosGroup);
            Controls.Add(VolverButton);
            Controls.Add(ContinuarButton);
            Controls.Add(label3);
            Controls.Add(DepositoCombobox);
            Controls.Add(label2);
            Controls.Add(ClienteCombobox);
            MaximizeBox = false;
            Name = "OrdenDePreparacionForm";
            Text = "Crear Orden de Preparación";
            Load += OrdenDePreparacionForm_Load;
            ProductosGroup.ResumeLayout(false);
            ProductosGroup.PerformLayout();
            InfoOrdenGroup.ResumeLayout(false);
            InfoOrdenGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox ClienteCombobox;
        private Label label2;
        private ComboBox DepositoCombobox;
        private Label label3;
        private Button ContinuarButton;
        private Button VolverButton;
        private GroupBox ProductosGroup;
        private Label label4;
        private ListView ProductosDisponiblesListView;
        private Label label6;
        private Button AgregarProductoButton;
        private Button EliminarProductoButton;
        private Label label5;
        private TextBox CantidadTextBox;
        private GroupBox InfoOrdenGroup;
        private Label label8;
        private Label label7;
        private TextBox DniTransportistaTextBox;
        private ComboBox PrioridadComboBox;
        private Button CrearOrdenButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label CantidadLabel;
		private ColumnHeader IdProducto;
		private ColumnHeader DescripcionProducto;
		private ColumnHeader CantProducto;
		private Label label1;
		private DateTimePicker FechaEntregaDatePicker;
        private ListView ProductosAgregadosListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button EliminarTodoButton;
    }
}