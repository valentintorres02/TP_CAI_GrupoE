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
            FiltrosGroup = new GroupBox();
            PrioridadLbl = new Label();
            PrioridadCombobox = new ComboBox();
            Clientelbl = new Label();
            ClienteCombobox = new ComboBox();
            LimpiarFiltroButton = new Button();
            FcehaEntregalbl = new Label();
            BuscarButton = new Button();
            FechaEntregaDatePicker = new DateTimePicker();
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
            FiltrosGroup.SuspendLayout();
            OrdenesGroup.SuspendLayout();
            SuspendLayout();
            // 
            // FiltrosGroup
            // 
            FiltrosGroup.Controls.Add(PrioridadLbl);
            FiltrosGroup.Controls.Add(PrioridadCombobox);
            FiltrosGroup.Controls.Add(Clientelbl);
            FiltrosGroup.Controls.Add(ClienteCombobox);
            FiltrosGroup.Controls.Add(LimpiarFiltroButton);
            FiltrosGroup.Controls.Add(FcehaEntregalbl);
            FiltrosGroup.Controls.Add(BuscarButton);
            FiltrosGroup.Controls.Add(FechaEntregaDatePicker);
            FiltrosGroup.Location = new Point(10, 40);
            FiltrosGroup.Name = "FiltrosGroup";
            FiltrosGroup.Size = new Size(1295, 65);
            FiltrosGroup.TabIndex = 26;
            FiltrosGroup.TabStop = false;
            FiltrosGroup.Text = "Filtros";
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
            ClienteCombobox.Size = new Size(313, 23);
            ClienteCombobox.TabIndex = 9;
            // 
            // LimpiarFiltroButton
            // 
            LimpiarFiltroButton.Location = new Point(1059, 18);
            LimpiarFiltroButton.Name = "LimpiarFiltroButton";
            LimpiarFiltroButton.Size = new Size(230, 41);
            LimpiarFiltroButton.TabIndex = 12;
            LimpiarFiltroButton.Text = "Limpiar";
            LimpiarFiltroButton.UseVisualStyleBackColor = true;
            LimpiarFiltroButton.Click += LimpiarFiltroButton_Click_1;
            // 
            // FcehaEntregalbl
            // 
            FcehaEntregalbl.AutoSize = true;
            FcehaEntregalbl.Location = new Point(594, 18);
            FcehaEntregalbl.Name = "FcehaEntregalbl";
            FcehaEntregalbl.Size = new Size(97, 15);
            FcehaEntregalbl.TabIndex = 16;
            FcehaEntregalbl.Text = "Fecha de Entrega";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(861, 19);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(192, 40);
            BuscarButton.TabIndex = 7;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // FechaEntregaDatePicker
            // 
            FechaEntregaDatePicker.Format = DateTimePickerFormat.Short;
            FechaEntregaDatePicker.Location = new Point(594, 36);
            FechaEntregaDatePicker.Name = "FechaEntregaDatePicker";
            FechaEntregaDatePicker.ShowCheckBox = true;
            FechaEntregaDatePicker.Size = new Size(261, 23);
            FechaEntregaDatePicker.TabIndex = 11;
            FechaEntregaDatePicker.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.Width = 130;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.Text = "CUIT/CUIL Cliente";
            DocumentoCliente.Width = 240;
            // 
            // Prioridad
            // 
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
            OrdenesPreparacionPendientesListView.Size = new Size(1283, 581);
            OrdenesPreparacionPendientesListView.TabIndex = 0;
            OrdenesPreparacionPendientesListView.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionPendientesListView.View = View.Details;
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 280;
            // 
            // Estado
            // 
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
            OrdenesGroup.Size = new Size(1295, 609);
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
            VolverButton.Size = new Size(1287, 62);
            VolverButton.TabIndex = 27;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click_1;
            // 
            // ConsultaOrdenesDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 800);
            Controls.Add(VolverButton);
            Controls.Add(FiltrosGroup);
            Controls.Add(OrdenesGroup);
            Controls.Add(label1);
            Name = "ConsultaOrdenesDePreparacionForm";
            Text = "ConsultaOrdenesDePreparacionForm";
            FormClosing += ConsultaOrdenesDePreparacionForm_FormClosing;
            Load += ConsultaOrdenesDePreparacionForm_Load_1;
            FiltrosGroup.ResumeLayout(false);
            FiltrosGroup.PerformLayout();
            OrdenesGroup.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox FiltrosGroup;
        private Label PrioridadLbl;
        private ComboBox PrioridadCombobox;
        private Label Clientelbl;
        private ComboBox ClienteCombobox;
        private Button LimpiarFiltroButton;
        private Label FcehaEntregalbl;
        private Button BuscarButton;
        private DateTimePicker FechaEntregaDatePicker;
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
    }
}