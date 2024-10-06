namespace TP_CAI.Archivos.Usuario.Forms
{
    partial class InicioDeSesionForm
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
            NombreUsuarioInput = new TextBox();
            ContraseniaInput = new TextBox();
            IngresarBoton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // NombreUsuarioInput
            // 
            NombreUsuarioInput.Location = new Point(34, 63);
            NombreUsuarioInput.Name = "NombreUsuarioInput";
            NombreUsuarioInput.PlaceholderText = "Nombre de Usuario";
            NombreUsuarioInput.Size = new Size(198, 23);
            NombreUsuarioInput.TabIndex = 0;
            // 
            // ContraseniaInput
            // 
            ContraseniaInput.Location = new Point(35, 108);
            ContraseniaInput.Name = "ContraseniaInput";
            ContraseniaInput.PasswordChar = '*';
            ContraseniaInput.PlaceholderText = "Contraseña";
            ContraseniaInput.Size = new Size(198, 23);
            ContraseniaInput.TabIndex = 1;
            // 
            // IngresarBoton
            // 
            IngresarBoton.Location = new Point(35, 159);
            IngresarBoton.Name = "IngresarBoton";
            IngresarBoton.Size = new Size(199, 23);
            IngresarBoton.TabIndex = 2;
            IngresarBoton.Text = "Ingresar";
            IngresarBoton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Inicio de Sesión";
            // 
            // InicioDeSesionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 219);
            Controls.Add(label1);
            Controls.Add(IngresarBoton);
            Controls.Add(ContraseniaInput);
            Controls.Add(NombreUsuarioInput);
            Name = "InicioDeSesionForm";
            Text = "InicioDeSesionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NombreUsuarioInput;
        private TextBox ContraseniaInput;
        private Button IngresarBoton;
        private Label label1;
    }
}