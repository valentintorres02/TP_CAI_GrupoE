namespace TP_CAI.Archivos.Empaquetado.Forms
{
    partial class EmpaquetadoForm
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
            EmpaquetarButton = new Button();
            OrdenesPreparacionListView = new ListView();
            IdProducto = new ColumnHeader();
            Descripcion = new ColumnHeader();
            CantidadProducto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            label1 = new Label();
            Productos = new GroupBox();
            NroOrdenLabel = new Label();
            Productos.SuspendLayout();
            SuspendLayout();
            // 
            // VolverAlMenuButton
            // 
            VolverAlMenuButton.Location = new Point(527, 396);
            VolverAlMenuButton.Name = "VolverAlMenuButton";
            VolverAlMenuButton.Size = new Size(144, 51);
            VolverAlMenuButton.TabIndex = 9;
            VolverAlMenuButton.Text = "Volver al Menú Principal";
            VolverAlMenuButton.UseVisualStyleBackColor = true;
            VolverAlMenuButton.Click += VolverAlMenuButton_Click;
            // 
            // EmpaquetarButton
            // 
            EmpaquetarButton.Location = new Point(8, 396);
            EmpaquetarButton.Name = "EmpaquetarButton";
            EmpaquetarButton.Size = new Size(513, 51);
            EmpaquetarButton.TabIndex = 7;
            EmpaquetarButton.Text = "Empaquetar";
            EmpaquetarButton.UseVisualStyleBackColor = true;
            EmpaquetarButton.Click += GenerarOrdenButton_Click;
            // 
            // OrdenesPreparacionListView
            // 
            OrdenesPreparacionListView.Columns.AddRange(new ColumnHeader[] { IdProducto, Descripcion, CantidadProducto });
            OrdenesPreparacionListView.FullRowSelect = true;
            OrdenesPreparacionListView.Location = new Point(2, 21);
            OrdenesPreparacionListView.Margin = new Padding(2);
            OrdenesPreparacionListView.MultiSelect = false;
            OrdenesPreparacionListView.Name = "OrdenesPreparacionListView";
            OrdenesPreparacionListView.Size = new Size(663, 319);
            OrdenesPreparacionListView.TabIndex = 11;
            OrdenesPreparacionListView.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionListView.View = View.Details;
            // 
            // IdProducto
            // 
            IdProducto.Text = "ID Producto";
            IdProducto.Width = 150;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            Descripcion.Width = 350;
            // 
            // CantidadProducto
            // 
            CantidadProducto.Text = "Cantidad";
            CantidadProducto.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 6;
            label1.Text = "Empaquetar Orden";
            // 
            // Productos
            // 
            Productos.Controls.Add(OrdenesPreparacionListView);
            Productos.Location = new Point(6, 45);
            Productos.Name = "Productos";
            Productos.Size = new Size(670, 345);
            Productos.TabIndex = 12;
            Productos.TabStop = false;
            Productos.Text = "Productos a Empaquetar";
            // 
            // NroOrdenLabel
            // 
            NroOrdenLabel.AutoSize = true;
            NroOrdenLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NroOrdenLabel.Location = new Point(150, 9);
            NroOrdenLabel.Name = "NroOrdenLabel";
            NroOrdenLabel.Size = new Size(37, 21);
            NroOrdenLabel.TabIndex = 13;
            NroOrdenLabel.Text = "000";
            // 
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 459);
            Controls.Add(NroOrdenLabel);
            Controls.Add(Productos);
            Controls.Add(VolverAlMenuButton);
            Controls.Add(EmpaquetarButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "EmpaquetadoForm";
            Text = "Empaquetar";
            FormClosing += EmpaquetadoForm_FormClosing;
            Load += EmpaquetadoForm_Load;
            Productos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LimpiarButton;
        private Button VolverAlMenuButton;
        private Button EmpaquetarButton;
        private ListView OrdenesPreparacionListView;
        private ColumnHeader IdOrden;
        private ColumnHeader DocumentoCliente;
        private ColumnHeader Cantidad;
        private Label label1;
        private GroupBox Productos;
        private ColumnHeader IdProducto;
        private ColumnHeader Descripcion;
        private ColumnHeader CantidadProducto;
        private Label NroOrdenLabel;
    }
}