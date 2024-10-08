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
            button1 = new Button();
            SuspendLayout();
            // 
            // RolUsuario
            // 
            RolUsuario.AutoSize = true;
            RolUsuario.Location = new Point(191, 40);
            RolUsuario.Margin = new Padding(4, 0, 4, 0);
            RolUsuario.Name = "RolUsuario";
            RolUsuario.Size = new Size(0, 25);
            RolUsuario.TabIndex = 3;
            // 
            // NombreUsuario
            // 
            NombreUsuario.AutoSize = true;
            NombreUsuario.Location = new Point(191, 15);
            NombreUsuario.Margin = new Padding(4, 0, 4, 0);
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(0, 25);
            NombreUsuario.TabIndex = 2;
            // 
            // RecepcionOrdenesPreparacionButton
            // 
            RecepcionOrdenesPreparacionButton.Location = new Point(17, 20);
            RecepcionOrdenesPreparacionButton.Margin = new Padding(4, 5, 4, 5);
            RecepcionOrdenesPreparacionButton.Name = "RecepcionOrdenesPreparacionButton";
            RecepcionOrdenesPreparacionButton.Size = new Size(323, 75);
            RecepcionOrdenesPreparacionButton.TabIndex = 4;
            RecepcionOrdenesPreparacionButton.Text = "Crear Orden de Preparación";
            RecepcionOrdenesPreparacionButton.UseVisualStyleBackColor = true;
            RecepcionOrdenesPreparacionButton.Click += RecepcionOrdenesPreparacionButton_Click;
            // 
            // GeneracionOrdenesSeleccionButton
            // 
            GeneracionOrdenesSeleccionButton.Location = new Point(17, 105);
            GeneracionOrdenesSeleccionButton.Margin = new Padding(4, 5, 4, 5);
            GeneracionOrdenesSeleccionButton.Name = "GeneracionOrdenesSeleccionButton";
            GeneracionOrdenesSeleccionButton.Size = new Size(323, 75);
            GeneracionOrdenesSeleccionButton.TabIndex = 5;
            GeneracionOrdenesSeleccionButton.Text = "Crear Orden de Selección";
            GeneracionOrdenesSeleccionButton.UseVisualStyleBackColor = true;
            GeneracionOrdenesSeleccionButton.Click += GeneracionOrdenesSeleccionButton_Click;
            // 
            // DespachoButton
            // 
            DespachoButton.Location = new Point(17, 445);
            DespachoButton.Margin = new Padding(4, 5, 4, 5);
            DespachoButton.Name = "DespachoButton";
            DespachoButton.Size = new Size(323, 75);
            DespachoButton.TabIndex = 7;
            DespachoButton.Text = "Despacho";
            DespachoButton.UseVisualStyleBackColor = true;
            DespachoButton.Click += DespachoButton_Click;
            // 
            // EmpaquetadoButton
            // 
            EmpaquetadoButton.Location = new Point(17, 275);
            EmpaquetadoButton.Margin = new Padding(4, 5, 4, 5);
            EmpaquetadoButton.Name = "EmpaquetadoButton";
            EmpaquetadoButton.Size = new Size(323, 75);
            EmpaquetadoButton.TabIndex = 6;
            EmpaquetadoButton.Text = "Empaquetado";
            EmpaquetadoButton.UseVisualStyleBackColor = true;
            EmpaquetadoButton.Click += EmpaquetadoButton_Click;
            // 
            // CrearOrdenDeEntrega
            // 
            CrearOrdenDeEntrega.Location = new Point(17, 360);
            CrearOrdenDeEntrega.Margin = new Padding(4, 5, 4, 5);
            CrearOrdenDeEntrega.Name = "CrearOrdenDeEntrega";
            CrearOrdenDeEntrega.Size = new Size(323, 75);
            CrearOrdenDeEntrega.TabIndex = 8;
            CrearOrdenDeEntrega.Text = "Crear Orden de Entrega";
            CrearOrdenDeEntrega.UseVisualStyleBackColor = true;
            CrearOrdenDeEntrega.Click += CrearOrdenDeEntrega_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 190);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(323, 75);
            button1.TabIndex = 9;
            button1.Text = "Gestion Orden de Seleccion";
            button1.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 544);
            Controls.Add(button1);
            Controls.Add(CrearOrdenDeEntrega);
            Controls.Add(DespachoButton);
            Controls.Add(EmpaquetadoButton);
            Controls.Add(GeneracionOrdenesSeleccionButton);
            Controls.Add(RecepcionOrdenesPreparacionButton);
            Controls.Add(RolUsuario);
            Controls.Add(NombreUsuario);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PantallaPrincipalForm";
            Text = "PantallaPrincipalForm";
            Load += PantallaPrincipalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label RolUsuario;
        private Label NombreUsuario;
        private Button RecepcionOrdenesPreparacionButton;
        private Button GeneracionOrdenesSeleccionButton;
        private Button DespachoButton;
        private Button EmpaquetadoButton;
        private Button CrearOrdenDeEntrega;
        private Button button1;
    }
}