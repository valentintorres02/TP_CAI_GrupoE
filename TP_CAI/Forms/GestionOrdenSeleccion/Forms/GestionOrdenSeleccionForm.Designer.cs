namespace TP_CAI.Forms.GestionOrdenSeleccion.Forms
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
            GenerarOrdenButton = new Button();
            label1 = new Label();
            OrdenesSeleccionListView = new ListView();
            IdOrden = new ColumnHeader();
            DocumentoCliente = new ColumnHeader();
            Estado = new ColumnHeader();
            SuspendLayout();
            // 
            // LimpiarButton
            // 
            LimpiarButton.Location = new Point(17, 372);
            LimpiarButton.Margin = new Padding(4, 5, 4, 5);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(107, 38);
            LimpiarButton.TabIndex = 15;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // VolverAlMenuButton
            // 
            VolverAlMenuButton.Location = new Point(17, 458);
            VolverAlMenuButton.Margin = new Padding(4, 5, 4, 5);
            VolverAlMenuButton.Name = "VolverAlMenuButton";
            VolverAlMenuButton.Size = new Size(206, 38);
            VolverAlMenuButton.TabIndex = 14;
            VolverAlMenuButton.Text = "Volver al Menú Principal";
            VolverAlMenuButton.UseVisualStyleBackColor = true;
            VolverAlMenuButton.Click += VolverAlMenuButton_Click_1;
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(133, 372);
            GenerarOrdenButton.Margin = new Padding(4, 5, 4, 5);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(713, 42);
            GenerarOrdenButton.TabIndex = 12;
            GenerarOrdenButton.Text = "Seleccionar";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(367, 32);
            label1.TabIndex = 11;
            label1.Text = "Seleccionar órdenes de selección";
            // 
            // OrdenesSeleccionListView
            // 
            OrdenesSeleccionListView.CheckBoxes = true;
            OrdenesSeleccionListView.Columns.AddRange(new ColumnHeader[] { IdOrden, DocumentoCliente, Estado });
            OrdenesSeleccionListView.FullRowSelect = true;
            OrdenesSeleccionListView.Location = new Point(17, 50);
            OrdenesSeleccionListView.Name = "OrdenesSeleccionListView";
            OrdenesSeleccionListView.Size = new Size(829, 314);
            OrdenesSeleccionListView.TabIndex = 16;
            OrdenesSeleccionListView.UseCompatibleStateImageBehavior = false;
            OrdenesSeleccionListView.View = View.Details;
            // 
            // IdOrden
            // 
            IdOrden.Text = "ID Orden";
            IdOrden.Width = 200;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.Text = "CUIT/CUIL Cliente";
            DocumentoCliente.Width = 200;
            // 
            // Estado
            // 
            Estado.Text = "Estado de Orden";
            Estado.Width = 200;
            // 
            // GestionOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 523);
            Controls.Add(OrdenesSeleccionListView);
            Controls.Add(LimpiarButton);
            Controls.Add(VolverAlMenuButton);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "GestionOrdenSeleccionForm";
            Text = "GestionOrdenSeleccionForm";
            Load += GestionOrdenSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LimpiarButton;
        private Button VolverAlMenuButton;
        private Button GenerarOrdenButton;
        private Label label1;
        private ListView OrdenesSeleccionListView;
        private ColumnHeader IdOrden;
        private ColumnHeader DocumentoCliente;
        private ColumnHeader Estado;
    }
}