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
			GenerarOrdenButton = new Button();
			OrdenesGroupBox = new GroupBox();
			listView1 = new ListView();
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
			// GenerarOrdenButton
			// 
			GenerarOrdenButton.Location = new Point(12, 373);
			GenerarOrdenButton.Name = "GenerarOrdenButton";
			GenerarOrdenButton.Size = new Size(447, 60);
			GenerarOrdenButton.TabIndex = 12;
			GenerarOrdenButton.Text = "Crear orden de entrega";
			GenerarOrdenButton.UseVisualStyleBackColor = true;
			GenerarOrdenButton.Click += GenerarOrdenButton_Click;
			// 
			// OrdenesGroupBox
			// 
			OrdenesGroupBox.Controls.Add(listView1);
			OrdenesGroupBox.Enabled = false;
			OrdenesGroupBox.Location = new Point(12, 12);
			OrdenesGroupBox.Name = "OrdenesGroupBox";
			OrdenesGroupBox.Size = new Size(623, 355);
			OrdenesGroupBox.TabIndex = 19;
			OrdenesGroupBox.TabStop = false;
			OrdenesGroupBox.Text = "Ordenes de Preparación";
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { IdOrden, FechaEntrega });
			listView1.Location = new Point(6, 22);
			listView1.Name = "listView1";
			listView1.Size = new Size(610, 327);
			listView1.TabIndex = 21;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
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
			Controls.Add(GenerarOrdenButton);
			MaximizeBox = false;
			Name = "OrdenDeEntregaForm";
			Text = "Crear Orden de Entrega";
			Load += OrdenDeEntregaForm_Load;
			OrdenesGroupBox.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Button VolverAlMenuButton;
        private Button GenerarOrdenButton;
        private GroupBox OrdenesGroupBox;
		private ListView listView1;
		private ColumnHeader IdOrden;
		private ColumnHeader FechaEntrega;
	}
}