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
			LimpiarButton = new Button();
			VolverAlMenuButton = new Button();
			OrdenesPreparacionGridView = new DataGridView();
			GenerarOrdenButton = new Button();
			SeleccionarTransporistaComboBox = new ComboBox();
			label2 = new Label();
			SeleccionarButton = new Button();
			OrdenesGroupBox = new GroupBox();
			((System.ComponentModel.ISupportInitialize)OrdenesPreparacionGridView).BeginInit();
			OrdenesGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// LimpiarButton
			// 
			LimpiarButton.Location = new Point(6, 212);
			LimpiarButton.Name = "LimpiarButton";
			LimpiarButton.Size = new Size(75, 23);
			LimpiarButton.TabIndex = 15;
			LimpiarButton.Text = "Limpiar";
			LimpiarButton.UseVisualStyleBackColor = true;
			LimpiarButton.Click += LimpiarButton_Click;
			// 
			// VolverAlMenuButton
			// 
			VolverAlMenuButton.Location = new Point(12, 329);
			VolverAlMenuButton.Name = "VolverAlMenuButton";
			VolverAlMenuButton.Size = new Size(144, 23);
			VolverAlMenuButton.TabIndex = 14;
			VolverAlMenuButton.Text = "Volver al Menú Principal";
			VolverAlMenuButton.UseVisualStyleBackColor = true;
			VolverAlMenuButton.Click += VolverAlMenuButton_Click;
			// 
			// OrdenesPreparacionGridView
			// 
			OrdenesPreparacionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			OrdenesPreparacionGridView.Enabled = false;
			OrdenesPreparacionGridView.Location = new Point(6, 22);
			OrdenesPreparacionGridView.Name = "OrdenesPreparacionGridView";
			OrdenesPreparacionGridView.Size = new Size(568, 184);
			OrdenesPreparacionGridView.TabIndex = 13;
			// 
			// GenerarOrdenButton
			// 
			GenerarOrdenButton.Location = new Point(87, 210);
			GenerarOrdenButton.Name = "GenerarOrdenButton";
			GenerarOrdenButton.Size = new Size(487, 25);
			GenerarOrdenButton.TabIndex = 12;
			GenerarOrdenButton.Text = "Crear orden de entrega";
			GenerarOrdenButton.UseVisualStyleBackColor = true;
			GenerarOrdenButton.Click += GenerarOrdenButton_Click;
			// 
			// SeleccionarTransporistaComboBox
			// 
			SeleccionarTransporistaComboBox.FormattingEnabled = true;
			SeleccionarTransporistaComboBox.Items.AddRange(new object[] { "DNI Transportista: 44444444", "DNI Transportista: 55555555", "DNI Transportista: 33333333" });
			SeleccionarTransporistaComboBox.Location = new Point(12, 28);
			SeleccionarTransporistaComboBox.Name = "SeleccionarTransporistaComboBox";
			SeleccionarTransporistaComboBox.Size = new Size(427, 23);
			SeleccionarTransporistaComboBox.TabIndex = 16;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 10);
			label2.Name = "label2";
			label2.Size = new Size(137, 15);
			label2.TabIndex = 17;
			label2.Text = "Seleccionar Transportista";
			// 
			// SeleccionarButton
			// 
			SeleccionarButton.Enabled = false;
			SeleccionarButton.Location = new Point(445, 28);
			SeleccionarButton.Name = "SeleccionarButton";
			SeleccionarButton.Size = new Size(147, 23);
			SeleccionarButton.TabIndex = 18;
			SeleccionarButton.Text = "Seleccionar";
			SeleccionarButton.UseVisualStyleBackColor = true;
			SeleccionarButton.Click += SeleccionarButton_Click;
			// 
			// OrdenesGroupBox
			// 
			OrdenesGroupBox.Controls.Add(OrdenesPreparacionGridView);
			OrdenesGroupBox.Controls.Add(LimpiarButton);
			OrdenesGroupBox.Controls.Add(GenerarOrdenButton);
			OrdenesGroupBox.Enabled = false;
			OrdenesGroupBox.Location = new Point(12, 57);
			OrdenesGroupBox.Name = "OrdenesGroupBox";
			OrdenesGroupBox.Size = new Size(580, 248);
			OrdenesGroupBox.TabIndex = 19;
			OrdenesGroupBox.TabStop = false;
			OrdenesGroupBox.Text = "Ordenes de Preparación";
			// 
			// OrdenDeEntregaForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(607, 364);
			Controls.Add(OrdenesGroupBox);
			Controls.Add(SeleccionarButton);
			Controls.Add(label2);
			Controls.Add(SeleccionarTransporistaComboBox);
			Controls.Add(VolverAlMenuButton);
			MaximizeBox = false;
			Name = "OrdenDeEntregaForm";
			Text = "Crear Orden de Entrega";
			Load += OrdenDeEntregaForm_Load;
			((System.ComponentModel.ISupportInitialize)OrdenesPreparacionGridView).EndInit();
			OrdenesGroupBox.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button LimpiarButton;
        private Button VolverAlMenuButton;
        private DataGridView OrdenesPreparacionGridView;
        private Button GenerarOrdenButton;
        private ComboBox SeleccionarTransporistaComboBox;
        private Label label2;
        private Button SeleccionarButton;
        private GroupBox OrdenesGroupBox;
    }
}