﻿namespace TP_CAI.Forms.GestionOrdenSeleccion.Forms
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
			LimpiarButton = new Button();
			VolverAlMenuButton = new Button();
			OrdenesPreparacionGridView = new DataGridView();
			GenerarOrdenButton = new Button();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)OrdenesPreparacionGridView).BeginInit();
			SuspendLayout();
			// 
			// LimpiarButton
			// 
			LimpiarButton.Location = new Point(12, 223);
			LimpiarButton.Name = "LimpiarButton";
			LimpiarButton.Size = new Size(75, 23);
			LimpiarButton.TabIndex = 15;
			LimpiarButton.Text = "Limpiar";
			LimpiarButton.UseVisualStyleBackColor = true;
			// 
			// VolverAlMenuButton
			// 
			VolverAlMenuButton.Location = new Point(12, 275);
			VolverAlMenuButton.Name = "VolverAlMenuButton";
			VolverAlMenuButton.Size = new Size(144, 23);
			VolverAlMenuButton.TabIndex = 14;
			VolverAlMenuButton.Text = "Volver al Menú Principal";
			VolverAlMenuButton.UseVisualStyleBackColor = true;
			VolverAlMenuButton.Click += VolverAlMenuButton_Click_1;
			// 
			// OrdenesPreparacionGridView
			// 
			OrdenesPreparacionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			OrdenesPreparacionGridView.Location = new Point(12, 33);
			OrdenesPreparacionGridView.Name = "OrdenesPreparacionGridView";
			OrdenesPreparacionGridView.RowHeadersWidth = 62;
			OrdenesPreparacionGridView.Size = new Size(580, 184);
			OrdenesPreparacionGridView.TabIndex = 13;
			// 
			// GenerarOrdenButton
			// 
			GenerarOrdenButton.Location = new Point(93, 223);
			GenerarOrdenButton.Name = "GenerarOrdenButton";
			GenerarOrdenButton.Size = new Size(499, 25);
			GenerarOrdenButton.TabIndex = 12;
			GenerarOrdenButton.Text = "Seleccionar";
			GenerarOrdenButton.UseVisualStyleBackColor = true;
			GenerarOrdenButton.Click += GenerarOrdenButton_Click_1;
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
			// GestionOrdenSeleccionForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(604, 314);
			Controls.Add(LimpiarButton);
			Controls.Add(VolverAlMenuButton);
			Controls.Add(OrdenesPreparacionGridView);
			Controls.Add(GenerarOrdenButton);
			Controls.Add(label1);
			MaximizeBox = false;
			Name = "GestionOrdenSeleccionForm";
			Text = "GestionOrdenSeleccionForm";
			Load += GestionOrdenSeleccionForm_Load;
			((System.ComponentModel.ISupportInitialize)OrdenesPreparacionGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button LimpiarButton;
        private Button VolverAlMenuButton;
        private DataGridView OrdenesPreparacionGridView;
        private Button GenerarOrdenButton;
        private Label label1;
    }
}