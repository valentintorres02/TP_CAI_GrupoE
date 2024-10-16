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
            label1 = new Label();
            ProductosGroup = new GroupBox();
            listView1 = new ListView();
            Ubicacion = new ColumnHeader();
            CantidadProducto = new ColumnHeader();
            label6 = new Label();
            label4 = new Label();
            ProductosDisponiblesListView = new ListView();
            IdOrden = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            CrearOrdenButton = new Button();
            button1 = new Button();
            IdProducto = new ColumnHeader();
            DescripcionProducto = new ColumnHeader();
            ProductosGroup.SuspendLayout();
            SuspendLayout();
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
            // ProductosGroup
            // 
            ProductosGroup.Controls.Add(listView1);
            ProductosGroup.Controls.Add(label6);
            ProductosGroup.Controls.Add(label4);
            ProductosGroup.Controls.Add(ProductosDisponiblesListView);
            ProductosGroup.Location = new Point(15, 33);
            ProductosGroup.Name = "ProductosGroup";
            ProductosGroup.Size = new Size(1224, 346);
            ProductosGroup.TabIndex = 19;
            ProductosGroup.TabStop = false;
            ProductosGroup.Text = "Órdenes a seleccionar";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Ubicacion, CantidadProducto, IdProducto, DescripcionProducto });
            listView1.Location = new Point(537, 37);
            listView1.Name = "listView1";
            listView1.Size = new Size(675, 289);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Ubicacion
            // 
            Ubicacion.Text = "Ubicacion";
            Ubicacion.Width = 180;
            // 
            // CantidadProducto
            // 
            CantidadProducto.Text = "Cantidad";
            CantidadProducto.Width = 150;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(529, 19);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 6;
            label6.Text = "Ítems a Seleccionar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(181, 15);
            label4.TabIndex = 1;
            label4.Text = "Órdenes de Selección pendientes";
            // 
            // ProductosDisponiblesListView
            // 
            ProductosDisponiblesListView.Columns.AddRange(new ColumnHeader[] { IdOrden, FechaEntrega });
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
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.Width = 250;
            // 
            // CrearOrdenButton
            // 
            CrearOrdenButton.Enabled = false;
            CrearOrdenButton.Location = new Point(15, 395);
            CrearOrdenButton.Name = "CrearOrdenButton";
            CrearOrdenButton.Size = new Size(604, 103);
            CrearOrdenButton.TabIndex = 21;
            CrearOrdenButton.Text = "Marcar como Seleccionada";
            CrearOrdenButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(625, 395);
            button1.Name = "button1";
            button1.Size = new Size(602, 103);
            button1.TabIndex = 20;
            button1.Text = "Volver al Menú Principal";
            button1.UseVisualStyleBackColor = true;
            // 
            // IdProducto
            // 
            IdProducto.Text = "ID Producto";
            IdProducto.Width = 120;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.Text = "Descripcion";
            DescripcionProducto.Width = 220;
            // 
            // GestionOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 525);
            Controls.Add(CrearOrdenButton);
            Controls.Add(button1);
            Controls.Add(ProductosGroup);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "GestionOrdenSeleccionForm";
            Text = "GestionOrdenSeleccionForm";
            Load += GestionOrdenSeleccionForm_Load;
            ProductosGroup.ResumeLayout(false);
            ProductosGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox ProductosGroup;
        private ListView listView1;
        private ColumnHeader Ubicacion;
        private ColumnHeader CantidadProducto;
        private Label label6;
        private Label label4;
        private ListView ProductosDisponiblesListView;
        private ColumnHeader IdOrden;
        private ColumnHeader FechaEntrega;
        private Button CrearOrdenButton;
        private Button button1;
        private ColumnHeader IdProducto;
        private ColumnHeader DescripcionProducto;
    }
}