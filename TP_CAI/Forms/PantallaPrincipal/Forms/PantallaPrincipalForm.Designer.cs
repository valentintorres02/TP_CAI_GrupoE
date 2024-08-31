namespace TP_CAI.Forms.PantallaPrincipal.Forms
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
            NombreUsuarioLabel = new Label();
            RolLabel = new Label();
            RolUsuario = new Label();
            NombreUsuario = new Label();
            SuspendLayout();
            // 
            // NombreUsuarioLabel
            // 
            NombreUsuarioLabel.AutoSize = true;
            NombreUsuarioLabel.Location = new Point(74, 50);
            NombreUsuarioLabel.Name = "NombreUsuarioLabel";
            NombreUsuarioLabel.Size = new Size(116, 15);
            NombreUsuarioLabel.TabIndex = 0;
            NombreUsuarioLabel.Text = "Nombre de Usuario: ";
            // 
            // RolLabel
            // 
            RolLabel.AutoSize = true;
            RolLabel.Location = new Point(74, 78);
            RolLabel.Name = "RolLabel";
            RolLabel.Size = new Size(30, 15);
            RolLabel.TabIndex = 1;
            RolLabel.Text = "Rol: ";
            // 
            // RolUsuario
            // 
            RolUsuario.AutoSize = true;
            RolUsuario.Location = new Point(196, 78);
            RolUsuario.Name = "RolUsuario";
            RolUsuario.Size = new Size(0, 15);
            RolUsuario.TabIndex = 3;
            // 
            // NombreUsuario
            // 
            NombreUsuario.AutoSize = true;
            NombreUsuario.Location = new Point(196, 50);
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(0, 15);
            NombreUsuario.TabIndex = 2;
            // 
            // PantallaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RolUsuario);
            Controls.Add(NombreUsuario);
            Controls.Add(RolLabel);
            Controls.Add(NombreUsuarioLabel);
            Name = "PantallaPrincipalForm";
            Text = "PantallaPrincipalForm";
            Load += PantallaPrincipalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreUsuarioLabel;
        private Label RolLabel;
        private Label RolUsuario;
        private Label NombreUsuario;
    }
}