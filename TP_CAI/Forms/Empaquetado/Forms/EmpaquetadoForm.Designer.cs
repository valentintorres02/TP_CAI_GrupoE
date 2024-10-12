﻿namespace TP_CAI.Archivos.Empaquetado.Forms
{
    partial class EmpaquetadoForm
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
            label1 = new Label();
            OrdenesPreparacionListView = new ListView();
            IdOrden = new ColumnHeader();
            DocumentoCliente = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Estado = new ColumnHeader();
            SuspendLayout();
            // 
            // LimpiarButton
            // 
            LimpiarButton.Location = new Point(17, 367);
            LimpiarButton.Margin = new Padding(4, 5, 4, 5);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(107, 38);
            LimpiarButton.TabIndex = 10;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // VolverAlMenuButton
            // 
            VolverAlMenuButton.Location = new Point(17, 453);
            VolverAlMenuButton.Margin = new Padding(4, 5, 4, 5);
            VolverAlMenuButton.Name = "VolverAlMenuButton";
            VolverAlMenuButton.Size = new Size(206, 38);
            VolverAlMenuButton.TabIndex = 9;
            VolverAlMenuButton.Text = "Volver al Menú Principal";
            VolverAlMenuButton.UseVisualStyleBackColor = true;
            VolverAlMenuButton.Click += VolverAlMenuButton_Click;
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(133, 367);
            GenerarOrdenButton.Margin = new Padding(4, 5, 4, 5);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(713, 42);
            GenerarOrdenButton.TabIndex = 7;
            GenerarOrdenButton.Text = "Empaquetar";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(17, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 32);
            label1.TabIndex = 6;
            label1.Text = "Seleccionar órdenes de preparación";
            // 
            // OrdenesPreparacionListView
            // 
            OrdenesPreparacionListView.CheckBoxes = true;
            OrdenesPreparacionListView.Columns.AddRange(new ColumnHeader[] { IdOrden, DocumentoCliente, Prioridad, Estado });
            OrdenesPreparacionListView.FullRowSelect = true;
            OrdenesPreparacionListView.Location = new Point(17, 45);
            OrdenesPreparacionListView.MultiSelect = false;
            OrdenesPreparacionListView.Name = "OrdenesPreparacionListView";
            OrdenesPreparacionListView.Size = new Size(829, 314);
            OrdenesPreparacionListView.TabIndex = 11;
            OrdenesPreparacionListView.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionListView.View = View.Details;
            // 
            // IdOrden
            // 
            IdOrden.Text = "Id Orden";
            IdOrden.Width = 150;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.Text = "CUIT/CUIL Cliente";
            DocumentoCliente.Width = 200;
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
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 505);
            Controls.Add(OrdenesPreparacionListView);
            Controls.Add(LimpiarButton);
            Controls.Add(VolverAlMenuButton);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "EmpaquetadoForm";
            Text = "Empaquetar";
            Load += EmpaquetadoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LimpiarButton;
        private Button VolverAlMenuButton;
        private Button GenerarOrdenButton;
        private Label label1;
        private ListView OrdenesPreparacionListView;
        private ColumnHeader IdOrden;
        private ColumnHeader DocumentoCliente;
        private ColumnHeader Prioridad;
        private ColumnHeader Estado;
    }
}