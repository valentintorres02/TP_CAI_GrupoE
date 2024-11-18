namespace TP_CAI.Forms.ConsultaStock.Forms
{
    partial class ConsultaStockForm
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
            label2 = new Label();
            ContinuarButton = new Button();
            label1 = new Label();
            ClienteCombobox = new ComboBox();
            ProductosGroup = new GroupBox();
            label4 = new Label();
            ProductosDisponiblesListView = new ListView();
            IdProducto = new ColumnHeader();
            DescripcionProducto = new ColumnHeader();
            CantProducto = new ColumnHeader();
            Deposito = new ColumnHeader();
            Ubicacion = new ColumnHeader();
            VolverButton = new Button();
            ProductosGroup.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-115, 205);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 7;
            label2.Text = "Cliente";
            // 
            // ContinuarButton
            // 
            ContinuarButton.Location = new Point(622, 9);
            ContinuarButton.Name = "ContinuarButton";
            ContinuarButton.Size = new Size(420, 41);
            ContinuarButton.TabIndex = 12;
            ContinuarButton.Text = "Continuar";
            ContinuarButton.UseVisualStyleBackColor = true;
            ContinuarButton.Click += ContinuarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 9;
            label1.Text = "Cliente";
            // 
            // ClienteCombobox
            // 
            ClienteCombobox.FormattingEnabled = true;
            ClienteCombobox.Items.AddRange(new object[] { "GrupoE S.R.L. CUIT 20-44444444-4. ", "C.A.I S.A. CUIT 20-55555555-5" });
            ClienteCombobox.Location = new Point(12, 27);
            ClienteCombobox.Name = "ClienteCombobox";
            ClienteCombobox.Size = new Size(604, 23);
            ClienteCombobox.TabIndex = 8;
            // 
            // ProductosGroup
            // 
            ProductosGroup.Controls.Add(label4);
            ProductosGroup.Controls.Add(ProductosDisponiblesListView);
            ProductosGroup.Enabled = false;
            ProductosGroup.Location = new Point(14, 56);
            ProductosGroup.Name = "ProductosGroup";
            ProductosGroup.Size = new Size(1030, 510);
            ProductosGroup.TabIndex = 13;
            ProductosGroup.TabStop = false;
            ProductosGroup.Text = "Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(279, 15);
            label4.TabIndex = 1;
            label4.Text = "Productos Disponibles en el Depósito Seleccionado:";
            // 
            // ProductosDisponiblesListView
            // 
            ProductosDisponiblesListView.Columns.AddRange(new ColumnHeader[] { IdProducto, DescripcionProducto, CantProducto, Deposito, Ubicacion });
            ProductosDisponiblesListView.Location = new Point(6, 37);
            ProductosDisponiblesListView.Name = "ProductosDisponiblesListView";
            ProductosDisponiblesListView.Size = new Size(1018, 467);
            ProductosDisponiblesListView.TabIndex = 0;
            ProductosDisponiblesListView.UseCompatibleStateImageBehavior = false;
            ProductosDisponiblesListView.View = View.Details;
            // 
            // IdProducto
            // 
            IdProducto.Text = "ID";
            IdProducto.Width = 150;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.Text = "Descripcion Producto";
            DescripcionProducto.Width = 350;
            // 
            // CantProducto
            // 
            CantProducto.Text = "Cantidad";
            CantProducto.Width = 150;
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 210;
            // 
            // Ubicacion
            // 
            Ubicacion.Text = "Ubicacion";
            Ubicacion.Width = 150;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(588, 572);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(454, 47);
            VolverButton.TabIndex = 14;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // ConsultaStockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 628);
            Controls.Add(VolverButton);
            Controls.Add(ProductosGroup);
            Controls.Add(ContinuarButton);
            Controls.Add(label1);
            Controls.Add(ClienteCombobox);
            Controls.Add(label2);
            Name = "ConsultaStockForm";
            Text = "Consulta de Stock";
            FormClosing += ConsultaStockForm_FormClosing;
            Load += ConsultaStockForm_Load;
            ProductosGroup.ResumeLayout(false);
            ProductosGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button ContinuarButton;
        private Label label1;
        private ComboBox ClienteCombobox;
        private GroupBox ProductosGroup;
        private Label label4;
        private ListView ProductosDisponiblesListView;
        private ColumnHeader IdProducto;
        private ColumnHeader DescripcionProducto;
        private ColumnHeader CantProducto;
        private Button VolverButton;
        private ColumnHeader Ubicacion;
        private ColumnHeader Deposito;
    }
}