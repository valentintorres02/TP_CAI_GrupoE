namespace TP_CAI.Archivos.OrdenDeSeleccion.Forms
{
    partial class OrdenDeSeleccionForm
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
            GenerarOrdenButton = new Button();
            OrdenesPreparacionGridView = new DataGridView();
            VolverAlMenuButton = new Button();
            LimpiarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)OrdenesPreparacionGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 21);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar órdenes de preparación";
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(93, 223);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(499, 25);
            GenerarOrdenButton.TabIndex = 2;
            GenerarOrdenButton.Text = "Generar orden de selección";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click;
            // 
            // OrdenesPreparacionGridView
            // 
            OrdenesPreparacionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdenesPreparacionGridView.Location = new Point(12, 33);
            OrdenesPreparacionGridView.Name = "OrdenesPreparacionGridView";
            OrdenesPreparacionGridView.Size = new Size(580, 184);
            OrdenesPreparacionGridView.TabIndex = 3;
            // 
            // VolverAlMenuButton
            // 
            VolverAlMenuButton.Location = new Point(12, 275);
            VolverAlMenuButton.Name = "VolverAlMenuButton";
            VolverAlMenuButton.Size = new Size(144, 23);
            VolverAlMenuButton.TabIndex = 4;
            VolverAlMenuButton.Text = "Volver al Menú Principal";
            VolverAlMenuButton.UseVisualStyleBackColor = true;
            VolverAlMenuButton.Click += VolverAlMenuButton_Click;
            // 
            // LimpiarButton
            // 
            LimpiarButton.Location = new Point(12, 223);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(75, 23);
            LimpiarButton.TabIndex = 5;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 308);
            Controls.Add(LimpiarButton);
            Controls.Add(VolverAlMenuButton);
            Controls.Add(OrdenesPreparacionGridView);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(label1);
            Name = "OrdenDeSeleccionForm";
            Text = "Crear Orden de Selección";
            Load += OrdenDeSeleccionForm_Load;
            ((System.ComponentModel.ISupportInitialize)OrdenesPreparacionGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GenerarOrdenButton;
        private DataGridView OrdenesPreparacionGridView;
        private Button VolverAlMenuButton;
        private Button LimpiarButton;
    }
}