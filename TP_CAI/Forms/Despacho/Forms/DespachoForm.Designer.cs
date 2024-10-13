namespace TP_CAI.Archivos.Despacho.Forms
{
    partial class DespachoForm
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
            button3 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            IdOrden = new ColumnHeader();
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 407);
            button3.Name = "button3";
            button3.Size = new Size(145, 23);
            button3.TabIndex = 11;
            button3.Text = "Volver al Menú Principal";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 330);
            button2.Name = "button2";
            button2.Size = new Size(213, 48);
            button2.TabIndex = 10;
            button2.Text = "Marcar como Despachadas y Generar Remito";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 214);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Órdenes a Despachar";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { IdOrden });
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(201, 186);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // IdOrden
            // 
            IdOrden.Text = "ID de Orden";
            IdOrden.Width = 190;
            // 
            // button1
            // 
            button1.Location = new Point(12, 56);
            button1.Name = "button1";
            button1.Size = new Size(213, 23);
            button1.TabIndex = 8;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 15);
            label1.TabIndex = 7;
            label1.Text = "Transportistas con Ordenes a Despachar:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 6;
            // 
            // DespachoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 444);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            MaximizeBox = false;
            Name = "DespachoForm";
            Text = "Despacho";
            Load += DespachoForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader IdOrden;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
    }
}