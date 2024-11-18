namespace TP_CAI.Archivos.PantallaPrincipal.Forms
{
    partial class PantallaPrincipalForm
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
            RolUsuario = new Label();
            NombreUsuario = new Label();
            RecepcionOrdenesPreparacionButton = new Button();
            GeneracionOrdenesSeleccionButton = new Button();
            DespachoButton = new Button();
            EmpaquetadoButton = new Button();
            CrearOrdenDeEntrega = new Button();
            GestionOrdenSeleccionButton = new Button();
            groupBox1 = new GroupBox();
            ConsultaOrdenesDePreparacionButton = new Button();
            ConsultaDeStockButton = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // RolUsuario
            // 
            RolUsuario.AutoSize = true;
            RolUsuario.Location = new Point(125, 19);
            RolUsuario.Name = "RolUsuario";
            RolUsuario.Size = new Size(0, 15);
            RolUsuario.TabIndex = 3;
            // 
            // NombreUsuario
            // 
            NombreUsuario.AutoSize = true;
            NombreUsuario.Location = new Point(125, 4);
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(0, 15);
            NombreUsuario.TabIndex = 2;
            // 
            // RecepcionOrdenesPreparacionButton
            // 
            RecepcionOrdenesPreparacionButton.Location = new Point(0, 22);
            RecepcionOrdenesPreparacionButton.Name = "RecepcionOrdenesPreparacionButton";
            RecepcionOrdenesPreparacionButton.Size = new Size(226, 70);
            RecepcionOrdenesPreparacionButton.TabIndex = 4;
            RecepcionOrdenesPreparacionButton.Text = "Crear Orden de Preparación";
            RecepcionOrdenesPreparacionButton.UseVisualStyleBackColor = true;
            RecepcionOrdenesPreparacionButton.Click += RecepcionOrdenesPreparacionButton_Click;
            // 
            // GeneracionOrdenesSeleccionButton
            // 
            GeneracionOrdenesSeleccionButton.Location = new Point(281, 22);
            GeneracionOrdenesSeleccionButton.Name = "GeneracionOrdenesSeleccionButton";
            GeneracionOrdenesSeleccionButton.Size = new Size(226, 70);
            GeneracionOrdenesSeleccionButton.TabIndex = 5;
            GeneracionOrdenesSeleccionButton.Text = "Crear Orden de Selección";
            GeneracionOrdenesSeleccionButton.UseVisualStyleBackColor = true;
            GeneracionOrdenesSeleccionButton.Click += GeneracionOrdenesSeleccionButton_Click;
            // 
            // DespachoButton
            // 
            DespachoButton.Location = new Point(281, 222);
            DespachoButton.Name = "DespachoButton";
            DespachoButton.Size = new Size(226, 72);
            DespachoButton.TabIndex = 7;
            DespachoButton.Text = "Despacho";
            DespachoButton.UseVisualStyleBackColor = true;
            DespachoButton.Click += DespachoButton_Click;
            // 
            // EmpaquetadoButton
            // 
            EmpaquetadoButton.Location = new Point(281, 121);
            EmpaquetadoButton.Name = "EmpaquetadoButton";
            EmpaquetadoButton.Size = new Size(226, 69);
            EmpaquetadoButton.TabIndex = 6;
            EmpaquetadoButton.Text = "Empaquetado";
            EmpaquetadoButton.UseVisualStyleBackColor = true;
            EmpaquetadoButton.Click += EmpaquetadoButton_Click;
            // 
            // CrearOrdenDeEntrega
            // 
            CrearOrdenDeEntrega.Location = new Point(0, 222);
            CrearOrdenDeEntrega.Name = "CrearOrdenDeEntrega";
            CrearOrdenDeEntrega.Size = new Size(226, 72);
            CrearOrdenDeEntrega.TabIndex = 8;
            CrearOrdenDeEntrega.Text = "Crear Orden de Entrega";
            CrearOrdenDeEntrega.UseVisualStyleBackColor = true;
            CrearOrdenDeEntrega.Click += CrearOrdenDeEntrega_Click;
            // 
            // GestionOrdenSeleccionButton
            // 
            GestionOrdenSeleccionButton.Location = new Point(0, 121);
            GestionOrdenSeleccionButton.Name = "GestionOrdenSeleccionButton";
            GestionOrdenSeleccionButton.Size = new Size(226, 69);
            GestionOrdenSeleccionButton.TabIndex = 9;
            GestionOrdenSeleccionButton.Text = "Gestion Orden de Seleccion";
            GestionOrdenSeleccionButton.UseVisualStyleBackColor = true;
            GestionOrdenSeleccionButton.Click += GestionOrdenSeleccionButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ConsultaOrdenesDePreparacionButton);
            groupBox1.Controls.Add(ConsultaDeStockButton);
            groupBox1.Location = new Point(12, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(504, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultas";
            // 
            // ConsultaOrdenesDePreparacionButton
            // 
            ConsultaOrdenesDePreparacionButton.Location = new Point(272, 22);
            ConsultaOrdenesDePreparacionButton.Name = "ConsultaOrdenesDePreparacionButton";
            ConsultaOrdenesDePreparacionButton.Size = new Size(226, 72);
            ConsultaOrdenesDePreparacionButton.TabIndex = 12;
            ConsultaOrdenesDePreparacionButton.Text = "Consulta de Ordenes de Preparacion";
            ConsultaOrdenesDePreparacionButton.UseVisualStyleBackColor = true;
            ConsultaOrdenesDePreparacionButton.Click += ConsultaOrdenesDePreparacionButton_Click;
            // 
            // ConsultaDeStockButton
            // 
            ConsultaDeStockButton.Location = new Point(6, 22);
            ConsultaDeStockButton.Name = "ConsultaDeStockButton";
            ConsultaDeStockButton.Size = new Size(226, 72);
            ConsultaDeStockButton.TabIndex = 11;
            ConsultaDeStockButton.Text = "Consulta de Stock";
            ConsultaDeStockButton.UseVisualStyleBackColor = true;
            ConsultaDeStockButton.Click += ConsultaDeStockButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RecepcionOrdenesPreparacionButton);
            groupBox2.Controls.Add(NombreUsuario);
            groupBox2.Controls.Add(GestionOrdenSeleccionButton);
            groupBox2.Controls.Add(RolUsuario);
            groupBox2.Controls.Add(CrearOrdenDeEntrega);
            groupBox2.Controls.Add(GeneracionOrdenesSeleccionButton);
            groupBox2.Controls.Add(DespachoButton);
            groupBox2.Controls.Add(EmpaquetadoButton);
            groupBox2.Location = new Point(9, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 308);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operaciones";
            // 
            // PantallaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 437);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "PantallaPrincipalForm";
            Text = "Menú Principal";
            FormClosing += PantallaPrincipalForm_FormClosing;
            Load += PantallaPrincipalForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label RolUsuario;
        private Label NombreUsuario;
        private Button RecepcionOrdenesPreparacionButton;
        private Button GeneracionOrdenesSeleccionButton;
        private Button DespachoButton;
        private Button EmpaquetadoButton;
        private Button CrearOrdenDeEntrega;
        private Button GestionOrdenSeleccionButton;
        private GroupBox groupBox1;
        private Button ConsultaOrdenesDePreparacionButton;
        private Button ConsultaDeStockButton;
        private GroupBox groupBox2;
    }
}