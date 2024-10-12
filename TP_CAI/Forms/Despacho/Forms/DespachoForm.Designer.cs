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
            label1 = new Label();
            OrdenDeEntregaComboBox = new ComboBox();
            SeleccionarOrdenButton = new Button();
            OrdenesDePreparacionLabel = new Label();
            GenerarRemitoYDespacharButton = new Button();
            VolverAlMenuButton = new Button();
            OrdenesPreparacionListView = new ListView();
            IdOrdenPreparacion = new ColumnHeader();
            DocumentoCliente = new ColumnHeader();
            NombreCliente = new ColumnHeader();
            DNITransportista = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Estado = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(342, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar orden de entrega a despachar";
            // 
            // OrdenDeEntregaComboBox
            // 
            OrdenDeEntregaComboBox.FormattingEnabled = true;
            OrdenDeEntregaComboBox.Items.AddRange(new object[] { "ID Orden de Entrega: 014", "ID Orden de Entrega: 017", "ID Orden de Entrega: 019", "ID Orden de Entrega: 012" });
            OrdenDeEntregaComboBox.Location = new Point(17, 45);
            OrdenDeEntregaComboBox.Margin = new Padding(4, 5, 4, 5);
            OrdenDeEntregaComboBox.Name = "OrdenDeEntregaComboBox";
            OrdenDeEntregaComboBox.Size = new Size(637, 33);
            OrdenDeEntregaComboBox.TabIndex = 1;
            // 
            // SeleccionarOrdenButton
            // 
            SeleccionarOrdenButton.Enabled = false;
            SeleccionarOrdenButton.Location = new Point(664, 45);
            SeleccionarOrdenButton.Margin = new Padding(4, 5, 4, 5);
            SeleccionarOrdenButton.Name = "SeleccionarOrdenButton";
            SeleccionarOrdenButton.Size = new Size(267, 38);
            SeleccionarOrdenButton.TabIndex = 15;
            SeleccionarOrdenButton.Text = "Seleccionar";
            SeleccionarOrdenButton.UseVisualStyleBackColor = true;
            SeleccionarOrdenButton.Click += SeleccionarOrdenButton_Click;
            // 
            // OrdenesDePreparacionLabel
            // 
            OrdenesDePreparacionLabel.AutoSize = true;
            OrdenesDePreparacionLabel.Enabled = false;
            OrdenesDePreparacionLabel.Location = new Point(17, 115);
            OrdenesDePreparacionLabel.Margin = new Padding(4, 0, 4, 0);
            OrdenesDePreparacionLabel.Name = "OrdenesDePreparacionLabel";
            OrdenesDePreparacionLabel.Size = new Size(304, 25);
            OrdenesDePreparacionLabel.TabIndex = 16;
            OrdenesDePreparacionLabel.Text = "Órdenes de Preparación a Despachar";
            // 
            // GenerarRemitoYDespacharButton
            // 
            GenerarRemitoYDespacharButton.Enabled = false;
            GenerarRemitoYDespacharButton.Location = new Point(17, 462);
            GenerarRemitoYDespacharButton.Margin = new Padding(4, 5, 4, 5);
            GenerarRemitoYDespacharButton.Name = "GenerarRemitoYDespacharButton";
            GenerarRemitoYDespacharButton.Size = new Size(914, 65);
            GenerarRemitoYDespacharButton.TabIndex = 17;
            GenerarRemitoYDespacharButton.Text = "Generar Remito y Despachar";
            GenerarRemitoYDespacharButton.UseVisualStyleBackColor = true;
            GenerarRemitoYDespacharButton.Click += GenerarRemitoYDespacharButton_Click;
            // 
            // VolverAlMenuButton
            // 
            VolverAlMenuButton.Location = new Point(17, 600);
            VolverAlMenuButton.Margin = new Padding(4, 5, 4, 5);
            VolverAlMenuButton.Name = "VolverAlMenuButton";
            VolverAlMenuButton.Size = new Size(206, 38);
            VolverAlMenuButton.TabIndex = 18;
            VolverAlMenuButton.Text = "Volver al Menú Principal";
            VolverAlMenuButton.UseVisualStyleBackColor = true;
            VolverAlMenuButton.Click += VolverAlMenuButton_Click;
            // 
            // OrdenesPreparacionListView
            // 
            OrdenesPreparacionListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, DocumentoCliente, NombreCliente, DNITransportista, Prioridad, Estado });
            OrdenesPreparacionListView.Enabled = false;
            OrdenesPreparacionListView.FullRowSelect = true;
            OrdenesPreparacionListView.Location = new Point(17, 143);
            OrdenesPreparacionListView.Name = "OrdenesPreparacionListView";
            OrdenesPreparacionListView.Size = new Size(914, 311);
            OrdenesPreparacionListView.TabIndex = 19;
            OrdenesPreparacionListView.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionListView.View = View.Details;
            // 
            // IdOrdenPreparacion
            // 
            IdOrdenPreparacion.Text = "Id Orden Preparacion";
            IdOrdenPreparacion.Width = 150;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.Text = "CUIT/CUIL Cliente";
            DocumentoCliente.Width = 150;
            // 
            // NombreCliente
            // 
            NombreCliente.Text = "Nombre Cliente";
            NombreCliente.Width = 150;
            // 
            // DNITransportista
            // 
            DNITransportista.Text = "DNI Transportista";
            DNITransportista.Width = 150;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 150;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 150;
            // 
            // DespachoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 652);
            Controls.Add(OrdenesPreparacionListView);
            Controls.Add(VolverAlMenuButton);
            Controls.Add(GenerarRemitoYDespacharButton);
            Controls.Add(OrdenesDePreparacionLabel);
            Controls.Add(SeleccionarOrdenButton);
            Controls.Add(OrdenDeEntregaComboBox);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "DespachoForm";
            Text = "Despacho";
            Load += DespachoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox OrdenDeEntregaComboBox;
        private Button SeleccionarOrdenButton;
        private Label OrdenesDePreparacionLabel;
        private Button GenerarRemitoYDespacharButton;
        private Button VolverAlMenuButton;
        private ListView OrdenesPreparacionListView;
        private ColumnHeader IdOrdenPreparacion;
        private ColumnHeader DocumentoCliente;
        private ColumnHeader NombreCliente;
        private ColumnHeader DNITransportista;
        private ColumnHeader Prioridad;
        private ColumnHeader Estado;
    }
}