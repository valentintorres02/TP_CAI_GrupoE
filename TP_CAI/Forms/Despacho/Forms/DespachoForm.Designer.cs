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
            OrdenesPreparacionGridView = new DataGridView();
            SeleccionarOrdenButton = new Button();
            OrdenesDePreparacionLabel = new Label();
            GenerarRemitoYDespacharButton = new Button();
            VolverAlMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)OrdenesPreparacionGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar orden de entrega a despachar";
            // 
            // OrdenDeEntregaComboBox
            // 
            OrdenDeEntregaComboBox.FormattingEnabled = true;
            OrdenDeEntregaComboBox.Items.AddRange(new object[] { "ID Orden de Entrega: 014", "ID Orden de Entrega: 017", "ID Orden de Entrega: 019", "ID Orden de Entrega: 012" });
            OrdenDeEntregaComboBox.Location = new Point(12, 27);
            OrdenDeEntregaComboBox.Name = "OrdenDeEntregaComboBox";
            OrdenDeEntregaComboBox.Size = new Size(447, 23);
            OrdenDeEntregaComboBox.TabIndex = 1;
            // 
            // OrdenesPreparacionGridView
            // 
            OrdenesPreparacionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdenesPreparacionGridView.Enabled = false;
            OrdenesPreparacionGridView.Location = new Point(12, 87);
            OrdenesPreparacionGridView.Name = "OrdenesPreparacionGridView";
            OrdenesPreparacionGridView.Size = new Size(640, 184);
            OrdenesPreparacionGridView.TabIndex = 14;
            // 
            // SeleccionarOrdenButton
            // 
            SeleccionarOrdenButton.Enabled = false;
            SeleccionarOrdenButton.Location = new Point(465, 27);
            SeleccionarOrdenButton.Name = "SeleccionarOrdenButton";
            SeleccionarOrdenButton.Size = new Size(187, 23);
            SeleccionarOrdenButton.TabIndex = 15;
            SeleccionarOrdenButton.Text = "Seleccionar";
            SeleccionarOrdenButton.UseVisualStyleBackColor = true;
            SeleccionarOrdenButton.Click += SeleccionarOrdenButton_Click;
            // 
            // OrdenesDePreparacionLabel
            // 
            OrdenesDePreparacionLabel.AutoSize = true;
            OrdenesDePreparacionLabel.Enabled = false;
            OrdenesDePreparacionLabel.Location = new Point(12, 69);
            OrdenesDePreparacionLabel.Name = "OrdenesDePreparacionLabel";
            OrdenesDePreparacionLabel.Size = new Size(200, 15);
            OrdenesDePreparacionLabel.TabIndex = 16;
            OrdenesDePreparacionLabel.Text = "Órdenes de Preparación a Despachar";
            // 
            // GenerarRemitoYDespacharButton
            // 
            GenerarRemitoYDespacharButton.Enabled = false;
            GenerarRemitoYDespacharButton.Location = new Point(12, 277);
            GenerarRemitoYDespacharButton.Name = "GenerarRemitoYDespacharButton";
            GenerarRemitoYDespacharButton.Size = new Size(640, 39);
            GenerarRemitoYDespacharButton.TabIndex = 17;
            GenerarRemitoYDespacharButton.Text = "Generar Remito y Despachar";
            GenerarRemitoYDespacharButton.UseVisualStyleBackColor = true;
            GenerarRemitoYDespacharButton.Click += GenerarRemitoYDespacharButton_Click;
            // 
            // VolverAlMenuButton
            // 
            VolverAlMenuButton.Location = new Point(12, 360);
            VolverAlMenuButton.Name = "VolverAlMenuButton";
            VolverAlMenuButton.Size = new Size(144, 23);
            VolverAlMenuButton.TabIndex = 18;
            VolverAlMenuButton.Text = "Volver al menú principal";
            VolverAlMenuButton.UseVisualStyleBackColor = true;
            // 
            // DespachoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 391);
            Controls.Add(VolverAlMenuButton);
            Controls.Add(GenerarRemitoYDespacharButton);
            Controls.Add(OrdenesDePreparacionLabel);
            Controls.Add(SeleccionarOrdenButton);
            Controls.Add(OrdenesPreparacionGridView);
            Controls.Add(OrdenDeEntregaComboBox);
            Controls.Add(label1);
            Name = "DespachoForm";
            Text = "Despacho";
            Load += DespachoForm_Load;
            ((System.ComponentModel.ISupportInitialize)OrdenesPreparacionGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox OrdenDeEntregaComboBox;
        private DataGridView OrdenesPreparacionGridView;
        private Button SeleccionarOrdenButton;
        private Label OrdenesDePreparacionLabel;
        private Button GenerarRemitoYDespacharButton;
        private Button VolverAlMenuButton;
    }
}