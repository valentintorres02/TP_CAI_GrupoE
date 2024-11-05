namespace TP_CAI.Archivos.Despacho.Forms
{
    partial class DespachoForm
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
            VolverButton = new Button();
            MarcarComoDespachadasButton = new Button();
            groupBox1 = new GroupBox();
            OrdenesADespacharListView = new ListView();
            IdOrden = new ColumnHeader();
            Estado = new ColumnHeader();
            IdOrdenEntrega = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            SeleccionarTransportistaButton = new Button();
            label1 = new Label();
            TransportistasCombobox = new ComboBox();
            MarcarComoListasButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(540, 376);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(152, 56);
            VolverButton.TabIndex = 11;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // MarcarComoDespachadasButton
            // 
            MarcarComoDespachadasButton.Location = new Point(18, 376);
            MarcarComoDespachadasButton.Name = "MarcarComoDespachadasButton";
            MarcarComoDespachadasButton.Size = new Size(289, 56);
            MarcarComoDespachadasButton.TabIndex = 10;
            MarcarComoDespachadasButton.Text = "Marcar como Despachadas y Generar Remito";
            MarcarComoDespachadasButton.UseVisualStyleBackColor = true;
            MarcarComoDespachadasButton.Click += MarcarComoDespachadasButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OrdenesADespacharListView);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(686, 314);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Órdenes a Despachar";
            // 
            // OrdenesADespacharListView
            // 
            OrdenesADespacharListView.Columns.AddRange(new ColumnHeader[] { IdOrden, Estado, IdOrdenEntrega, FechaEntrega });
            OrdenesADespacharListView.Location = new Point(6, 22);
            OrdenesADespacharListView.Name = "OrdenesADespacharListView";
            OrdenesADespacharListView.Size = new Size(674, 286);
            OrdenesADespacharListView.TabIndex = 0;
            OrdenesADespacharListView.UseCompatibleStateImageBehavior = false;
            OrdenesADespacharListView.View = View.Details;
            // 
            // IdOrden
            // 
            IdOrden.Text = "ID Orden Preparación";
            IdOrden.Width = 190;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 200;
            // 
            // IdOrdenEntrega
            // 
            IdOrdenEntrega.Text = "ID Orden Entrega";
            IdOrdenEntrega.Width = 120;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.Width = 150;
            // 
            // SeleccionarTransportistaButton
            // 
            SeleccionarTransportistaButton.Location = new Point(485, 27);
            SeleccionarTransportistaButton.Name = "SeleccionarTransportistaButton";
            SeleccionarTransportistaButton.Size = new Size(213, 23);
            SeleccionarTransportistaButton.TabIndex = 8;
            SeleccionarTransportistaButton.Text = "Seleccionar";
            SeleccionarTransportistaButton.UseVisualStyleBackColor = true;
            SeleccionarTransportistaButton.Click += SeleccionarTransportistaButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 15);
            label1.TabIndex = 7;
            label1.Text = "Transportistas con Ordenes a Despachar:";
            // 
            // TransportistasCombobox
            // 
            TransportistasCombobox.DropDownHeight = 150;
            TransportistasCombobox.FormattingEnabled = true;
            TransportistasCombobox.IntegralHeight = false;
            TransportistasCombobox.Items.AddRange(new object[] { "DNI 39456294", "DNI 65320644", "DNI 21245675", "DNI 95435677" });
            TransportistasCombobox.Location = new Point(18, 27);
            TransportistasCombobox.Name = "TransportistasCombobox";
            TransportistasCombobox.Size = new Size(461, 23);
            TransportistasCombobox.TabIndex = 6;
            // 
            // MarcarComoListasButton
            // 
            MarcarComoListasButton.Location = new Point(313, 376);
            MarcarComoListasButton.Name = "MarcarComoListasButton";
            MarcarComoListasButton.Size = new Size(221, 56);
            MarcarComoListasButton.TabIndex = 12;
            MarcarComoListasButton.Text = "Marcar como Listas para despacho";
            MarcarComoListasButton.UseVisualStyleBackColor = true;
            MarcarComoListasButton.Click += MarcarComoListasButton_Click;
            // 
            // DespachoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 444);
            Controls.Add(MarcarComoListasButton);
            Controls.Add(VolverButton);
            Controls.Add(MarcarComoDespachadasButton);
            Controls.Add(groupBox1);
            Controls.Add(SeleccionarTransportistaButton);
            Controls.Add(label1);
            Controls.Add(TransportistasCombobox);
            MaximizeBox = false;
            Name = "DespachoForm";
            Text = "Despacho";
            FormClosing += DespachoForm_FormClosing;
            Load += DespachoForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VolverButton;
        private Button MarcarComoDespachadasButton;
        private GroupBox groupBox1;
        private ListView OrdenesADespacharListView;
        private ColumnHeader IdOrden;
        private Button SeleccionarTransportistaButton;
        private Label label1;
        private ComboBox TransportistasCombobox;
		private Button MarcarComoListasButton;
        private ColumnHeader Estado;
        private ColumnHeader IdOrdenEntrega;
        private ColumnHeader FechaEntrega;
    }
}