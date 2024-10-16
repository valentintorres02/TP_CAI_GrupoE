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
            OrdenesGroup = new GroupBox();
            ItemsASeleccionarListView = new ListView();
            Ubicacion = new ColumnHeader();
            CantidadProducto = new ColumnHeader();
            IdProducto = new ColumnHeader();
            DescripcionProducto = new ColumnHeader();
            label6 = new Label();
            label4 = new Label();
            OrdenesSeleccionPendientesListView = new ListView();
            IdOrden = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            MarcarComoSeleccionadaButton = new Button();
            VolverButton = new Button();
            OrdenesGroup.SuspendLayout();
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
            // OrdenesGroup
            // 
            OrdenesGroup.Controls.Add(ItemsASeleccionarListView);
            OrdenesGroup.Controls.Add(label6);
            OrdenesGroup.Controls.Add(label4);
            OrdenesGroup.Controls.Add(OrdenesSeleccionPendientesListView);
            OrdenesGroup.Location = new Point(15, 33);
            OrdenesGroup.Name = "OrdenesGroup";
            OrdenesGroup.Size = new Size(1224, 346);
            OrdenesGroup.TabIndex = 19;
            OrdenesGroup.TabStop = false;
            OrdenesGroup.Text = "Órdenes a seleccionar";
            // 
            // ItemsASeleccionarListView
            // 
            ItemsASeleccionarListView.Columns.AddRange(new ColumnHeader[] { Ubicacion, CantidadProducto, IdProducto, DescripcionProducto });
            ItemsASeleccionarListView.Location = new Point(537, 37);
            ItemsASeleccionarListView.Name = "ItemsASeleccionarListView";
            ItemsASeleccionarListView.Size = new Size(675, 289);
            ItemsASeleccionarListView.TabIndex = 18;
            ItemsASeleccionarListView.UseCompatibleStateImageBehavior = false;
            ItemsASeleccionarListView.View = View.Details;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(537, 19);
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
            // OrdenesSeleccionPendientesListView
            // 
            OrdenesSeleccionPendientesListView.Columns.AddRange(new ColumnHeader[] { IdOrden, FechaEntrega });
            OrdenesSeleccionPendientesListView.Location = new Point(6, 37);
            OrdenesSeleccionPendientesListView.Name = "OrdenesSeleccionPendientesListView";
            OrdenesSeleccionPendientesListView.Size = new Size(493, 289);
            OrdenesSeleccionPendientesListView.TabIndex = 0;
            OrdenesSeleccionPendientesListView.UseCompatibleStateImageBehavior = false;
            OrdenesSeleccionPendientesListView.View = View.Details;
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
            // MarcarComoSeleccionadaButton
            // 
            MarcarComoSeleccionadaButton.Enabled = false;
            MarcarComoSeleccionadaButton.Location = new Point(15, 395);
            MarcarComoSeleccionadaButton.Name = "MarcarComoSeleccionadaButton";
            MarcarComoSeleccionadaButton.Size = new Size(604, 103);
            MarcarComoSeleccionadaButton.TabIndex = 21;
            MarcarComoSeleccionadaButton.Text = "Marcar como Seleccionada";
            MarcarComoSeleccionadaButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(625, 395);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(602, 103);
            VolverButton.TabIndex = 20;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // GestionOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 525);
            Controls.Add(MarcarComoSeleccionadaButton);
            Controls.Add(VolverButton);
            Controls.Add(OrdenesGroup);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "GestionOrdenSeleccionForm";
            Text = "GestionOrdenSeleccionForm";
            Load += GestionOrdenSeleccionForm_Load;
            OrdenesGroup.ResumeLayout(false);
            OrdenesGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox OrdenesGroup;
        private ListView ItemsASeleccionarListView;
        private ColumnHeader Ubicacion;
        private ColumnHeader CantidadProducto;
        private Label label6;
        private Label label4;
        private ListView OrdenesSeleccionPendientesListView;
        private ColumnHeader IdOrden;
        private ColumnHeader FechaEntrega;
        private Button MarcarComoSeleccionadaButton;
        private Button VolverButton;
        private ColumnHeader IdProducto;
        private ColumnHeader DescripcionProducto;
    }
}