namespace TP_CAI.Forms.OrdenDeEntrega.Forms
{
    partial class OrdenDeEntregaForm
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
            CrearOrdenEntregaButton = new Button();
            OrdenesGroupBox = new GroupBox();
            OrdenesPreparacionListView = new ListView();
            IdOrden = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            OrdenesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // VolverAlMenuButton
            // 
            VolverAlMenuButton.Location = new Point(465, 373);
            VolverAlMenuButton.Name = "VolverAlMenuButton";
            VolverAlMenuButton.Size = new Size(170, 60);
            VolverAlMenuButton.TabIndex = 14;
            VolverAlMenuButton.Text = "Volver al Menú Principal";
            VolverAlMenuButton.UseVisualStyleBackColor = true;
            VolverAlMenuButton.Click += VolverAlMenuButton_Click;
            // 
            // CrearOrdenEntregaButton
            // 
            CrearOrdenEntregaButton.Location = new Point(12, 373);
            CrearOrdenEntregaButton.Name = "CrearOrdenEntregaButton";
            CrearOrdenEntregaButton.Size = new Size(447, 60);
            CrearOrdenEntregaButton.TabIndex = 12;
            CrearOrdenEntregaButton.Text = "Crear orden de entrega";
            CrearOrdenEntregaButton.UseVisualStyleBackColor = true;
            CrearOrdenEntregaButton.Click += GenerarOrdenButton_Click;
            // 
            // OrdenesGroupBox
            // 
            OrdenesGroupBox.Controls.Add(OrdenesPreparacionListView);
            OrdenesGroupBox.Location = new Point(12, 12);
            OrdenesGroupBox.Name = "OrdenesGroupBox";
            OrdenesGroupBox.Size = new Size(623, 355);
            OrdenesGroupBox.TabIndex = 19;
            OrdenesGroupBox.TabStop = false;
            OrdenesGroupBox.Text = "Ordenes de Preparación";
            // 
            // OrdenesPreparacionListView
            // 
            OrdenesPreparacionListView.Columns.AddRange(new ColumnHeader[] { IdOrden, FechaEntrega });
            OrdenesPreparacionListView.Location = new Point(6, 22);
            OrdenesPreparacionListView.Name = "OrdenesPreparacionListView";
            OrdenesPreparacionListView.Size = new Size(610, 327);
            OrdenesPreparacionListView.TabIndex = 21;
            OrdenesPreparacionListView.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionListView.View = View.Details;
            // 
            // IdOrden
            // 
            IdOrden.Text = "ID Orden";
            IdOrden.Width = 150;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de entrega";
            FechaEntrega.Width = 500;
            // 
            // OrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 445);
            Controls.Add(OrdenesGroupBox);
            Controls.Add(VolverAlMenuButton);
            Controls.Add(CrearOrdenEntregaButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OrdenDeEntregaForm";
            Text = "Crear Orden de Entrega";
            FormClosing += OrdenDeEntregaForm_FormClosing;
            Load += OrdenDeEntregaForm_Load;
            OrdenesGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button VolverAlMenuButton;
        private Button CrearOrdenEntregaButton;
        private GroupBox OrdenesGroupBox;
		private ListView OrdenesPreparacionListView;
		private ColumnHeader IdOrden;
		private ColumnHeader FechaEntrega;
	}
}