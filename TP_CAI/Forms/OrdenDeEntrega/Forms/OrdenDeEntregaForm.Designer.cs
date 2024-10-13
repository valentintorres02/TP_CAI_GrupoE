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
			GenerarOrdenButton = new Button();
			OrdenesGroupBox = new GroupBox();
			BuscarButtton = new Button();
			listView1 = new ListView();
			textBox1 = new TextBox();
			BuscarOrdenlbl = new Label();
			IdOrden = new ColumnHeader();
			FechaEntrega = new ColumnHeader();
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
			VolverAlMenuButton.Location = new Point(12, 311);
			VolverAlMenuButton.Name = "VolverAlMenuButton";
			VolverAlMenuButton.Size = new Size(144, 23);
			VolverAlMenuButton.TabIndex = 14;
			VolverAlMenuButton.Text = "Volver al Menú Principal";
			VolverAlMenuButton.UseVisualStyleBackColor = true;
			VolverAlMenuButton.Click += VolverAlMenuButton_Click;
			// 
			// GenerarOrdenButton
			// 
			GenerarOrdenButton.Location = new Point(87, 210);
			GenerarOrdenButton.Name = "GenerarOrdenButton";
			GenerarOrdenButton.Size = new Size(271, 25);
			GenerarOrdenButton.TabIndex = 12;
			GenerarOrdenButton.Text = "Crear orden de entrega";
			GenerarOrdenButton.UseVisualStyleBackColor = true;
			GenerarOrdenButton.Click += GenerarOrdenButton_Click;
			// 
			// OrdenesGroupBox
			// 
			OrdenesGroupBox.Controls.Add(listView1);
			OrdenesGroupBox.Controls.Add(LimpiarButton);
			OrdenesGroupBox.Controls.Add(GenerarOrdenButton);
			OrdenesGroupBox.Enabled = false;
			OrdenesGroupBox.Location = new Point(12, 57);
			OrdenesGroupBox.Name = "OrdenesGroupBox";
			OrdenesGroupBox.Size = new Size(358, 248);
			OrdenesGroupBox.TabIndex = 19;
			OrdenesGroupBox.TabStop = false;
			OrdenesGroupBox.Text = "Ordenes de Preparación";
			// 
			// BuscarButtton
			// 
			BuscarButtton.Location = new Point(295, 28);
			BuscarButtton.Name = "BuscarButtton";
			BuscarButtton.Size = new Size(75, 23);
			BuscarButtton.TabIndex = 20;
			BuscarButtton.Text = "Buscar";
			BuscarButtton.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { IdOrden, FechaEntrega });
			listView1.Location = new Point(6, 22);
			listView1.Name = "listView1";
			listView1.Size = new Size(352, 182);
			listView1.TabIndex = 21;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(18, 28);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(271, 23);
			textBox1.TabIndex = 22;
			// 
			// BuscarOrdenlbl
			// 
			BuscarOrdenlbl.AutoSize = true;
			BuscarOrdenlbl.Location = new Point(18, 9);
			BuscarOrdenlbl.Name = "BuscarOrdenlbl";
			BuscarOrdenlbl.Size = new Size(136, 15);
			BuscarOrdenlbl.TabIndex = 23;
			BuscarOrdenlbl.Text = "ID Orden de Preparacion";
			// 
			// IdOrden
			// 
			IdOrden.Text = "ID Orden";
			IdOrden.Width = 150;
			// 
			// FechaEntrega
			// 
			FechaEntrega.Text = "Fecha de entrega";
			FechaEntrega.Width = 200;
			// 
			// OrdenDeEntregaForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(378, 341);
			Controls.Add(BuscarOrdenlbl);
			Controls.Add(textBox1);
			Controls.Add(BuscarButtton);
			Controls.Add(OrdenesGroupBox);
			Controls.Add(VolverAlMenuButton);
			MaximizeBox = false;
			Name = "OrdenDeEntregaForm";
			Text = "Crear Orden de Entrega";
			Load += OrdenDeEntregaForm_Load;
			OrdenesGroupBox.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button LimpiarButton;
        private Button VolverAlMenuButton;
        private Button GenerarOrdenButton;
        private GroupBox OrdenesGroupBox;
		private TextBox textBox1;
		private ListView listView1;
		private Button BuscarButtton;
		private Label BuscarOrdenlbl;
		private ColumnHeader IdOrden;
		private ColumnHeader FechaEntrega;
	}
}