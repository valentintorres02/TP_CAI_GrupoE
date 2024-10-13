namespace TP_CAI.Forms.GestionOrdenSeleccion.Forms
{
    partial class GestionOrdenSeleccionForm
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
			VolverAlMenuButton = new Button();
			GenerarOrdenButton = new Button();
			label1 = new Label();
			OrdenesSeleccionListView = new ListView();
			IdOrden = new ColumnHeader();
			DocumentoCliente = new ColumnHeader();
			Estado = new ColumnHeader();
			ProductosListView = new ListView();
			ID = new ColumnHeader();
			DescripcionProducto = new ColumnHeader();
			CantidadProducto = new ColumnHeader();
			UbicacionProducto = new ColumnHeader();
			ProductosButton = new Button();
			FechaCreacion = new ColumnHeader();
			Productoslbl = new Label();
			SuspendLayout();
			// 
			// VolverAlMenuButton
			// 
			VolverAlMenuButton.Location = new Point(15, 431);
			VolverAlMenuButton.Name = "VolverAlMenuButton";
			VolverAlMenuButton.Size = new Size(144, 23);
			VolverAlMenuButton.TabIndex = 14;
			VolverAlMenuButton.Text = "Volver al Menú Principal";
			VolverAlMenuButton.UseVisualStyleBackColor = true;
			VolverAlMenuButton.Click += VolverAlMenuButton_Click_1;
			// 
			// GenerarOrdenButton
			// 
			GenerarOrdenButton.Location = new Point(175, 431);
			GenerarOrdenButton.Name = "GenerarOrdenButton";
			GenerarOrdenButton.Size = new Size(397, 25);
			GenerarOrdenButton.TabIndex = 12;
			GenerarOrdenButton.Text = "Seleccionar";
			GenerarOrdenButton.UseVisualStyleBackColor = true;
			GenerarOrdenButton.Click += GenerarOrdenButton_Click_1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(237, 21);
			label1.TabIndex = 11;
			label1.Text = "Seleccionar órdenes de selección";
			// 
			// OrdenesSeleccionListView
			// 
			OrdenesSeleccionListView.CheckBoxes = true;
			OrdenesSeleccionListView.Columns.AddRange(new ColumnHeader[] { IdOrden, DocumentoCliente, Estado, FechaCreacion });
			OrdenesSeleccionListView.FullRowSelect = true;
			OrdenesSeleccionListView.Location = new Point(12, 30);
			OrdenesSeleccionListView.Margin = new Padding(2);
			OrdenesSeleccionListView.Name = "OrdenesSeleccionListView";
			OrdenesSeleccionListView.Size = new Size(557, 156);
			OrdenesSeleccionListView.TabIndex = 16;
			OrdenesSeleccionListView.UseCompatibleStateImageBehavior = false;
			OrdenesSeleccionListView.View = View.Details;
			// 
			// IdOrden
			// 
			IdOrden.Text = "ID Orden";
			IdOrden.Width = 100;
			// 
			// DocumentoCliente
			// 
			DocumentoCliente.Text = "CUIT/CUIL Cliente";
			DocumentoCliente.Width = 150;
			// 
			// Estado
			// 
			Estado.Text = "Estado de Orden";
			Estado.Width = 150;
			// 
			// ProductosListView
			// 
			ProductosListView.Columns.AddRange(new ColumnHeader[] { ID, DescripcionProducto, CantidadProducto, UbicacionProducto });
			ProductosListView.Location = new Point(15, 220);
			ProductosListView.Name = "ProductosListView";
			ProductosListView.Size = new Size(554, 204);
			ProductosListView.TabIndex = 17;
			ProductosListView.UseCompatibleStateImageBehavior = false;
			ProductosListView.View = View.Details;
			// 
			// ID
			// 
			ID.Text = "ID";
			ID.Width = 100;
			// 
			// DescripcionProducto
			// 
			DescripcionProducto.Text = "Descripcion";
			DescripcionProducto.Width = 200;
			// 
			// CantidadProducto
			// 
			CantidadProducto.Text = "Cantidad";
			CantidadProducto.Width = 100;
			// 
			// UbicacionProducto
			// 
			UbicacionProducto.Text = "Ubicacion";
			UbicacionProducto.Width = 150;
			// 
			// ProductosButton
			// 
			ProductosButton.Location = new Point(463, 191);
			ProductosButton.Name = "ProductosButton";
			ProductosButton.Size = new Size(106, 23);
			ProductosButton.TabIndex = 18;
			ProductosButton.Text = "Ver Productos";
			ProductosButton.UseVisualStyleBackColor = true;
			// 
			// FechaCreacion
			// 
			FechaCreacion.Text = "Fecha de Creacion";
			FechaCreacion.Width = 150;
			// 
			// Productoslbl
			// 
			Productoslbl.AutoSize = true;
			Productoslbl.Font = new Font("Segoe UI", 12F);
			Productoslbl.Location = new Point(15, 196);
			Productoslbl.Name = "Productoslbl";
			Productoslbl.Size = new Size(165, 21);
			Productoslbl.TabIndex = 19;
			Productoslbl.Text = "Productos de la Orden";
			// 
			// GestionOrdenSeleccionForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(580, 464);
			Controls.Add(Productoslbl);
			Controls.Add(ProductosButton);
			Controls.Add(ProductosListView);
			Controls.Add(OrdenesSeleccionListView);
			Controls.Add(VolverAlMenuButton);
			Controls.Add(GenerarOrdenButton);
			Controls.Add(label1);
			MaximizeBox = false;
			Name = "GestionOrdenSeleccionForm";
			Text = "GestionOrdenSeleccionForm";
			Load += GestionOrdenSeleccionForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button VolverAlMenuButton;
        private Button GenerarOrdenButton;
        private Label label1;
        private ListView OrdenesSeleccionListView;
        private ColumnHeader IdOrden;
        private ColumnHeader DocumentoCliente;
        private ColumnHeader Estado;
		private ListView ProductosListView;
		private ColumnHeader ID;
		private ColumnHeader DescripcionProducto;
		private ColumnHeader CantidadProducto;
		private ColumnHeader UbicacionProducto;
		private Button ProductosButton;
		private ColumnHeader FechaCreacion;
		private Label Productoslbl;
	}
}