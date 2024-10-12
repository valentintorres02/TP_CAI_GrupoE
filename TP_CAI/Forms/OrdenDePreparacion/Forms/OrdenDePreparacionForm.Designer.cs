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
			VolverAlMenuButton = new Button();
			ProductosGroup = new GroupBox();
			EliminarProductoButton = new Button();
			label6 = new Label();
			ProductosAgregadosListView = new ListView();
			AgregarProductoButton = new Button();
			CantidadLabel = new Label();
			CantidadTextBox = new TextBox();
			label4 = new Label();
			ProductosDisponiblesListView = new ListView();
			InfoOrdenGroup = new GroupBox();
			label8 = new Label();
			label7 = new Label();
			DniTransportistaTextBox = new TextBox();
			PrioridadComboBox = new ComboBox();
			CrearOrdenButton = new Button();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
			ContinuarButton.Location = new Point(717, 26);
			ContinuarButton.Name = "ContinuarButton";
			ContinuarButton.Size = new Size(156, 23);
			ContinuarButton.TabIndex = 5;
			ContinuarButton.Text = "Continuar";
			ContinuarButton.UseVisualStyleBackColor = true;
			ContinuarButton.Click += ContinuarButton_Click;
			// 
			// VolverAlMenuButton
			// 
			VolverAlMenuButton.Location = new Point(12, 345);
			VolverAlMenuButton.Name = "VolverAlMenuButton";
			VolverAlMenuButton.Size = new Size(153, 23);
			VolverAlMenuButton.TabIndex = 6;
			VolverAlMenuButton.Text = "Volver al Menú Principal";
			VolverAlMenuButton.UseVisualStyleBackColor = true;
			VolverAlMenuButton.Click += VolverAlMenuButton_Click;
			// 
			// ProductosGroup
			// 
			ProductosGroup.Controls.Add(EliminarProductoButton);
			ProductosGroup.Controls.Add(label6);
			ProductosGroup.Controls.Add(ProductosAgregadosListView);
			ProductosGroup.Controls.Add(AgregarProductoButton);
			ProductosGroup.Controls.Add(CantidadLabel);
			ProductosGroup.Controls.Add(CantidadTextBox);
			ProductosGroup.Controls.Add(label4);
			ProductosGroup.Controls.Add(ProductosDisponiblesListView);
			ProductosGroup.Location = new Point(12, 64);
			ProductosGroup.Name = "ProductosGroup";
			ProductosGroup.Size = new Size(861, 180);
			ProductosGroup.TabIndex = 7;
			ProductosGroup.TabStop = false;
			ProductosGroup.Text = "Productos";
			// 
			// EliminarProductoButton
			// 
			EliminarProductoButton.Enabled = false;
			EliminarProductoButton.Location = new Point(443, 137);
			EliminarProductoButton.Name = "EliminarProductoButton";
			EliminarProductoButton.Size = new Size(408, 29);
			EliminarProductoButton.TabIndex = 7;
			EliminarProductoButton.Text = "Eliminar producto seleccionado de la Orden";
			EliminarProductoButton.UseVisualStyleBackColor = true;
			EliminarProductoButton.Click += EliminarProductoButton_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(443, 19);
			label6.Name = "label6";
			label6.Size = new Size(260, 15);
			label6.TabIndex = 6;
			label6.Text = "Productos Agregados a la Orden de Preparación";
			// 
			// ProductosAgregadosListView
			// 
			ProductosAgregadosListView.Location = new Point(443, 37);
			ProductosAgregadosListView.Name = "ProductosAgregadosListView";
			ProductosAgregadosListView.Size = new Size(408, 97);
			ProductosAgregadosListView.TabIndex = 5;
			ProductosAgregadosListView.UseCompatibleStateImageBehavior = false;
			ProductosAgregadosListView.View = View.Details;
			// 
			// AgregarProductoButton
			// 
			AgregarProductoButton.Enabled = false;
			AgregarProductoButton.Location = new Point(243, 137);
			AgregarProductoButton.Name = "AgregarProductoButton";
			AgregarProductoButton.Size = new Size(171, 23);
			AgregarProductoButton.TabIndex = 4;
			AgregarProductoButton.Text = "Agregar Producto a la Orden";
			AgregarProductoButton.UseVisualStyleBackColor = true;
			AgregarProductoButton.Click += AgregarProductoButton_Click;
			// 
			// CantidadLabel
			// 
			CantidadLabel.AutoSize = true;
			CantidadLabel.Location = new Point(6, 141);
			CantidadLabel.Name = "CantidadLabel";
			CantidadLabel.Size = new Size(110, 15);
			CantidadLabel.TabIndex = 3;
			CantidadLabel.Text = "Cantidad a agregar:";
			// 
			// CantidadTextBox
			// 
			CantidadTextBox.Enabled = false;
			CantidadTextBox.Location = new Point(122, 137);
			CantidadTextBox.Name = "CantidadTextBox";
			CantidadTextBox.Size = new Size(115, 23);
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
			ProductosDisponiblesListView.Location = new Point(6, 37);
			ProductosDisponiblesListView.Name = "ProductosDisponiblesListView";
			ProductosDisponiblesListView.Size = new Size(408, 97);
			ProductosDisponiblesListView.TabIndex = 0;
			ProductosDisponiblesListView.UseCompatibleStateImageBehavior = false;
			ProductosDisponiblesListView.View = View.Details;
			// 
			// InfoOrdenGroup
			// 
			InfoOrdenGroup.Controls.Add(label8);
			InfoOrdenGroup.Controls.Add(label7);
			InfoOrdenGroup.Controls.Add(DniTransportistaTextBox);
			InfoOrdenGroup.Controls.Add(PrioridadComboBox);
			InfoOrdenGroup.Location = new Point(12, 250);
			InfoOrdenGroup.Name = "InfoOrdenGroup";
			InfoOrdenGroup.Size = new Size(558, 79);
			InfoOrdenGroup.TabIndex = 8;
			InfoOrdenGroup.TabStop = false;
			InfoOrdenGroup.Text = "Información de Orden de Preparación";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(272, 22);
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
			DniTransportistaTextBox.Location = new Point(272, 40);
			DniTransportistaTextBox.Name = "DniTransportistaTextBox";
			DniTransportistaTextBox.Size = new Size(280, 23);
			DniTransportistaTextBox.TabIndex = 8;
			// 
			// PrioridadComboBox
			// 
			PrioridadComboBox.FormattingEnabled = true;
			PrioridadComboBox.Items.AddRange(new object[] { "Baja", "Media", "Alta" });
			PrioridadComboBox.Location = new Point(6, 40);
			PrioridadComboBox.Name = "PrioridadComboBox";
			PrioridadComboBox.Size = new Size(260, 23);
			PrioridadComboBox.TabIndex = 9;
			// 
			// CrearOrdenButton
			// 
			CrearOrdenButton.Enabled = false;
			CrearOrdenButton.Location = new Point(576, 257);
			CrearOrdenButton.Name = "CrearOrdenButton";
			CrearOrdenButton.Size = new Size(297, 72);
			CrearOrdenButton.TabIndex = 9;
			CrearOrdenButton.Text = "Crear Orden de Preparación";
			CrearOrdenButton.UseVisualStyleBackColor = true;
			CrearOrdenButton.Click += CrearOrdenButton_Click;
			// 
			// OrdenDePreparacionForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(880, 374);
			Controls.Add(CrearOrdenButton);
			Controls.Add(InfoOrdenGroup);
			Controls.Add(ProductosGroup);
			Controls.Add(VolverAlMenuButton);
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
        private Button VolverAlMenuButton;
        private GroupBox ProductosGroup;
        private Label label4;
        private ListView ProductosDisponiblesListView;
        private Label label6;
        private ListView ProductosAgregadosListView;
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
    }
}