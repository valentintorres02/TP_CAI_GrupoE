using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI.Forms.InicioDeSesion.Model;
using TP_CAI.Archivos.Validaciones;

namespace TP_CAI.Forms.InicioDeSesion.Forms
{
    public partial class InicioDeSesionForm : Form
    {
        InicioDeSesionModel model;
        public UsuarioEntidad usuario { get; private set; }

        public InicioDeSesionForm()
        {
            InitializeComponent();

            this.Load += InicioDeSesionForm_Load;

            // Asignar el manejador de eventos al botón IngresarBoton
            IngresarBoton.Click += IngresarBoton_Click;
        }

        private void InicioDeSesionForm_Load(object sender, EventArgs e)
        {
            model = new();

            // Centrar los controles
            IngresarBoton.Left = (this.ClientSize.Width - IngresarBoton.Width) / 2;
            NombreUsuarioInput.Left = (this.ClientSize.Width - NombreUsuarioInput.Width) / 2;
            ContraseniaInput.Left = (this.ClientSize.Width - ContraseniaInput.Width) / 2;
        }

        private void IngresarBoton_Click(object sender, EventArgs e)
        {
            string nombreUsuario = NombreUsuarioInput.Text;
            string contrasenia = ContraseniaInput.Text;

            Validacion<UsuarioEntidad> validacion = model.ValidarUsuarioIngresado(nombreUsuario, contrasenia);

            if (validacion.Estado == ValidacionEstados.Ok)
            {
                usuario = validacion.Data;
                MessageBox.Show("Login satisfactorio, bienvenido!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(validacion.Mensaje);
            }
        }
    }
}
