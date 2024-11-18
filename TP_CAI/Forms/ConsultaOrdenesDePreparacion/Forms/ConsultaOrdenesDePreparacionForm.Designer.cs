namespace TP_CAI.Forms.ConsultaOrdenesDePreparacion.Forms
{
    partial class ConsultaOrdenesDePreparacionForm
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
            FechaEntrega = new ColumnHeader();
            DocumentoCliente = new ColumnHeader();
            Prioridad = new ColumnHeader();
            IdOrden = new ColumnHeader();
            OrdenesPreparacionPendientesListView = new ListView();
            Deposito = new ColumnHeader();
            Estado = new ColumnHeader();
            FechaEmision = new ColumnHeader();
            DNITransportista = new ColumnHeader();
            OrdenesGroup = new GroupBox();
            label1 = new Label();
            VolverButton = new Button();
            FiltrosGroup = new GroupBox();
            label2 = new Label();
            FechaEntregaHastaDatePicker = new DateTimePicker();
            PrioridadLbl = new Label();
            PrioridadCombobox = new ComboBox();
            Clientelbl = new Label();
            ClienteCombobox = new ComboBox();
            LimpiarFiltroButton = new Button();
            FcehaEntregalbl = new Label();
            BuscarButton = new Button();
            FechaEntregaDesdeDatePicker = new DateTimePicker();
            OrdenesGroup.SuspendLayout();
            FiltrosGroup.SuspendLayout();
            SuspendLayout();
            // 
            // FechaEntrega
            // 
            FechaEntrega.DisplayIndex = 4;
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.Width = 130;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.DisplayIndex = 3;
            DocumentoCliente.Text = "CUIT/CUIL Cliente";
            DocumentoCliente.Width = 240;
            // 
            // Prioridad
            // 
            Prioridad.DisplayIndex = 2;
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 100;
            // 
            // IdOrden
            // 
            IdOrden.Text = "ID";
            IdOrden.Width = 90;
            // 
            // OrdenesPreparacionPendientesListView
            // 
            OrdenesPreparacionPendientesListView.Columns.AddRange(new ColumnHeader[] { IdOrden, Prioridad, DocumentoCliente, FechaEntrega, Deposito, Estado, FechaEmision, DNITransportista });
            OrdenesPreparacionPendientesListView.Location = new Point(6, 22);
            OrdenesPreparacionPendientesListView.Name = "OrdenesPreparacionPendientesListView";
            OrdenesPreparacionPendientesListView.Size = new Size(1367, 581);
            OrdenesPreparacionPendientesListView.TabIndex = 0;
            OrdenesPreparacionPendientesListView.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionPendientesListView.View = View.Details;
            // 
            // Deposito
            // 
            Deposito.DisplayIndex = 5;
            Deposito.Text = "Deposito";
            Deposito.Width = 280;
            // 
            // Estado
            // 
            Estado.DisplayIndex = 1;
            Estado.Text = "Estado";
            Estado.Width = 200;
            // 
            // FechaEmision
            // 
            FechaEmision.Text = "Fecha de Emision";
            FechaEmision.Width = 130;
            // 
            // DNITransportista
            // 
            DNITransportista.Text = "DNITransportista";
            DNITransportista.Width = 105;
            // 
            // OrdenesGroup
            // 
            OrdenesGroup.Controls.Add(OrdenesPreparacionPendientesListView);
            OrdenesGroup.Location = new Point(10, 111);
            OrdenesGroup.Name = "OrdenesGroup";
            OrdenesGroup.Size = new Size(1379, 609);
            OrdenesGroup.TabIndex = 24;
            OrdenesGroup.TabStop = false;
            OrdenesGroup.Text = "Órdenes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 21);
            label1.TabIndex = 22;
            label1.Text = "Consultar órdenes de preparación";
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(12, 726);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(1377, 62);
            VolverButton.TabIndex = 27;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click_1;
            // 
            // FiltrosGroup
            // 
            FiltrosGroup.Controls.Add(label2);
            FiltrosGroup.Controls.Add(FechaEntregaHastaDatePicker);
            FiltrosGroup.Controls.Add(PrioridadLbl);
            FiltrosGroup.Controls.Add(PrioridadCombobox);
            FiltrosGroup.Controls.Add(Clientelbl);
            FiltrosGroup.Controls.Add(ClienteCombobox);
            FiltrosGroup.Controls.Add(LimpiarFiltroButton);
            FiltrosGroup.Controls.Add(FcehaEntregalbl);
            FiltrosGroup.Controls.Add(BuscarButton);
            FiltrosGroup.Controls.Add(FechaEntregaDesdeDatePicker);
            FiltrosGroup.Location = new Point(10, 33);
            FiltrosGroup.Name = "FiltrosGroup";
            FiltrosGroup.Size = new Size(1379, 65);
            FiltrosGroup.TabIndex = 28;
            FiltrosGroup.TabStop = false;
            FiltrosGroup.Text = "Filtros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(821, 18);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 18;
            label2.Text = "Fecha de Entrega (hasta)";
            // 
            // FechaEntregaHastaDatePicker
            // 
            FechaEntregaHastaDatePicker.Format = DateTimePickerFormat.Short;
            FechaEntregaHastaDatePicker.Location = new Point(821, 36);
            FechaEntregaHastaDatePicker.Name = "FechaEntregaHastaDatePicker";
            FechaEntregaHastaDatePicker.ShowCheckBox = true;
            FechaEntregaHastaDatePicker.Size = new Size(261, 23);
            FechaEntregaHastaDatePicker.TabIndex = 17;
            FechaEntregaHastaDatePicker.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // PrioridadLbl
            // 
            PrioridadLbl.AutoSize = true;
            PrioridadLbl.Location = new Point(6, 19);
            PrioridadLbl.Name = "PrioridadLbl";
            PrioridadLbl.Size = new Size(55, 15);
            PrioridadLbl.TabIndex = 13;
            PrioridadLbl.Text = "Prioridad";
            // 
            // PrioridadCombobox
            // 
            PrioridadCombobox.FormattingEnabled = true;
            PrioridadCombobox.Location = new Point(4, 36);
            PrioridadCombobox.Name = "PrioridadCombobox";
            PrioridadCombobox.Size = new Size(267, 23);
            PrioridadCombobox.TabIndex = 8;
            // 
            // Clientelbl
            // 
            Clientelbl.AutoSize = true;
            Clientelbl.Location = new Point(275, 19);
            Clientelbl.Name = "Clientelbl";
            Clientelbl.Size = new Size(44, 15);
            Clientelbl.TabIndex = 14;
            Clientelbl.Text = "Cliente";
            // 
            // ClienteCombobox
            // 
            ClienteCombobox.FormattingEnabled = true;
            ClienteCombobox.Location = new Point(275, 36);
            ClienteCombobox.Name = "ClienteCombobox";
            ClienteCombobox.Size = new Size(273, 23);
            ClienteCombobox.TabIndex = 9;
            // 
            // LimpiarFiltroButton
            // 
            LimpiarFiltroButton.Location = new Point(1254, 18);
            LimpiarFiltroButton.Name = "LimpiarFiltroButton";
            LimpiarFiltroButton.Size = new Size(119, 41);
            LimpiarFiltroButton.TabIndex = 12;
            LimpiarFiltroButton.Text = "Limpiar";
            LimpiarFiltroButton.UseVisualStyleBackColor = true;
            LimpiarFiltroButton.Click += LimpiarFiltroButton_Click;
            // 
            // FcehaEntregalbl
            // 
            FcehaEntregalbl.AutoSize = true;
            FcehaEntregalbl.Location = new Point(554, 18);
            FcehaEntregalbl.Name = "FcehaEntregalbl";
            FcehaEntregalbl.Size = new Size(139, 15);
            FcehaEntregalbl.TabIndex = 16;
            FcehaEntregalbl.Text = "Fecha de Entrega (desde)";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(1088, 19);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(162, 40);
            BuscarButton.TabIndex = 7;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click_1;
            // 
            // FechaEntregaDesdeDatePicker
            // 
            FechaEntregaDesdeDatePicker.Format = DateTimePickerFormat.Short;
            FechaEntregaDesdeDatePicker.Location = new Point(554, 36);
            FechaEntregaDesdeDatePicker.Name = "FechaEntregaDesdeDatePicker";
            FechaEntregaDesdeDatePicker.ShowCheckBox = true;
            FechaEntregaDesdeDatePicker.Size = new Size(261, 23);
            FechaEntregaDesdeDatePicker.TabIndex = 11;
            FechaEntregaDesdeDatePicker.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // ConsultaOrdenesDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 800);
            Controls.Add(FiltrosGroup);
            Controls.Add(VolverButton);
            Controls.Add(OrdenesGroup);
            Controls.Add(label1);
            Name = "ConsultaOrdenesDePreparacionForm";
            Text = "ConsultaOrdenesDePreparacionForm";
            FormClosing += ConsultaOrdenesDePreparacionForm_FormClosing;
            Load += ConsultaOrdenesDePreparacionForm_Load_1;
            OrdenesGroup.ResumeLayout(false);
            FiltrosGroup.ResumeLayout(false);
            FiltrosGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColumnHeader FechaEntrega;
        private ColumnHeader DocumentoCliente;
        private ColumnHeader Prioridad;
        private ColumnHeader IdOrden;
        private ListView OrdenesPreparacionPendientesListView;
        private ColumnHeader Deposito;
        private ColumnHeader Estado;
        private ColumnHeader FechaEmision;
        private ColumnHeader DNITransportista;
        private GroupBox OrdenesGroup;
        private Label label1;
        private Button VolverButton;
        private GroupBox FiltrosGroup;
        private Label label2;
        private DateTimePicker FechaEntregaHastaDatePicker;
        private Label PrioridadLbl;
        private ComboBox PrioridadCombobox;
        private Label Clientelbl;
        private ComboBox ClienteCombobox;
        private Button LimpiarFiltroButton;
        private Label FcehaEntregalbl;
        private Button BuscarButton;
        private DateTimePicker FechaEntregaDesdeDatePicker;
    }
}