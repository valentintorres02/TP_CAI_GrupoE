using System;
using System.Windows.Forms;
using TP_CAI.Archivos.Despacho.Forms;
using TP_CAI.Archivos.Empaquetado.Forms;
using TP_CAI.Archivos.GeneracionOrdenesSeleccion.Forms;
using TP_CAI.Archivos.RecepcionOrdenesPreparacion.Forms;
using TP_CAI.Archivos.Usuario.Entidad;
using TP_CAI.Forms.PantallaPrincipal.Model;
using TP_CAI.Archivos.Forms.BaseForm;

namespace TP_CAI.Archivos.PantallaPrincipal.Forms
{
    public partial class PantallaPrincipalForm : BaseForm
    {
        PantallaPrincipalModel model;

        public PantallaPrincipalForm(UsuarioEntidad usuario) : base(usuario)
        {
            InitializeComponent();
        }

        private void PantallaPrincipalForm_Load(object sender, EventArgs e)
        {
            model = new PantallaPrincipalModel();
            NombreUsuario.Text = usuarioLogeado.NombreUsuario;
            RolUsuario.Text = usuarioLogeado.Rol.ToString();
        }

        private void RecepcionOrdenesPreparacionButton_Click(object sender, EventArgs e)
        {
            RecepcionOrdenesPreparacionForm recepcionOrdenesPreparacionForm = new RecepcionOrdenesPreparacionForm(usuarioLogeado);
            this.Hide();
            recepcionOrdenesPreparacionForm.Show();
        }

        private void GeneracionOrdenesSeleccionButton_Click(object sender, EventArgs e)
        {
            GeneracionOrdenesSeleccionForm generacionOrdenesSeleccionForm = new GeneracionOrdenesSeleccionForm(usuarioLogeado);
            this.Hide();
            generacionOrdenesSeleccionForm.Show();
        }

        private void EmpaquetadoButton_Click(object sender, EventArgs e)
        {
            EmpaquetadoForm empaquetadoForm = new EmpaquetadoForm(usuarioLogeado);
            this.Hide();
            empaquetadoForm.Show();
        }

        private void DespachoButton_Click(object sender, EventArgs e)
        {
            DespachoForm despachoForm = new DespachoForm(usuarioLogeado);
            this.Hide();
            despachoForm.Show();
        }
    }
}
