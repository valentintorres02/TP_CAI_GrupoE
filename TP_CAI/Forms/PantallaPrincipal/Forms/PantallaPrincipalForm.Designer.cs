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
            button1 = new Button();
            SuspendLayout();
            // 
            // RolUsuario
            // 
            RolUsuario.AutoSize = true;
            RolUsuario.Location = new Point(134, 24);
            RolUsuario.Name = "RolUsuario";
            RolUsuario.Size = new Size(0, 15);
            RolUsuario.TabIndex = 3;
            // 
            // NombreUsuario
            // 
            NombreUsuario.AutoSize = true;
            NombreUsuario.Location = new Point(134, 9);
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(0, 15);
            NombreUsuario.TabIndex = 2;
            // 
            // RecepcionOrdenesPreparacionButton
            // 
            RecepcionOrdenesPreparacionButton.Location = new Point(12, 12);
            RecepcionOrdenesPreparacionButton.Name = "RecepcionOrdenesPreparacionButton";
            RecepcionOrdenesPreparacionButton.Size = new Size(226, 45);
            RecepcionOrdenesPreparacionButton.TabIndex = 4;
            RecepcionOrdenesPreparacionButton.Text = "Recepción de órdenes de preparación por parte de los clientes";
            RecepcionOrdenesPreparacionButton.UseVisualStyleBackColor = true;
            RecepcionOrdenesPreparacionButton.Click += RecepcionOrdenesPreparacionButton_Click;
            // 
            // GeneracionOrdenesSeleccionButton
            // 
            GeneracionOrdenesSeleccionButton.Location = new Point(12, 63);
            GeneracionOrdenesSeleccionButton.Name = "GeneracionOrdenesSeleccionButton";
            GeneracionOrdenesSeleccionButton.Size = new Size(226, 45);
            GeneracionOrdenesSeleccionButton.TabIndex = 5;
            GeneracionOrdenesSeleccionButton.Text = "Generación de órdenes de selección";
            GeneracionOrdenesSeleccionButton.UseVisualStyleBackColor = true;
            GeneracionOrdenesSeleccionButton.Click += GeneracionOrdenesSeleccionButton_Click;
            // 
            // DespachoButton
            // 
            DespachoButton.Location = new Point(12, 216);
            DespachoButton.Name = "DespachoButton";
            DespachoButton.Size = new Size(226, 45);
            DespachoButton.TabIndex = 7;
            DespachoButton.Text = "Despacho";
            DespachoButton.UseVisualStyleBackColor = true;
            DespachoButton.Click += DespachoButton_Click;
            // 
            // EmpaquetadoButton
            // 
            EmpaquetadoButton.Location = new Point(12, 114);
            EmpaquetadoButton.Name = "EmpaquetadoButton";
            EmpaquetadoButton.Size = new Size(226, 45);
            EmpaquetadoButton.TabIndex = 6;
            EmpaquetadoButton.Text = "Empaquetado";
            EmpaquetadoButton.UseVisualStyleBackColor = true;
            EmpaquetadoButton.Click += EmpaquetadoButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 165);
            button1.Name = "button1";
            button1.Size = new Size(226, 45);
            button1.TabIndex = 8;
            button1.Text = "Empaquetado";
            button1.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 331);
            Controls.Add(button1);
            Controls.Add(DespachoButton);
            Controls.Add(EmpaquetadoButton);
            Controls.Add(GeneracionOrdenesSeleccionButton);
            Controls.Add(RecepcionOrdenesPreparacionButton);
            Controls.Add(RolUsuario);
            Controls.Add(NombreUsuario);
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
        private Button button1;
    }
}