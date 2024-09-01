using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI.Archivos.Despacho.Forms;
using TP_CAI.Archivos.Empaquetado.Forms;
using TP_CAI.Archivos.GeneracionOrdenesSeleccion.Forms;
using TP_CAI.Archivos.RecepcionOrdenesPreparacion.Forms;
using TP_CAI.Archivos.Usuario.Entidad;
using TP_CAI.Forms.PantallaPrincipal.Model;

namespace TP_CAI.Archivos.PantallaPrincipal.Forms
{

    public partial class PantallaPrincipalForm : Form
    {
        PantallaPrincipalModel model;
        private UsuarioEntidad usuarioLogeado;

        public PantallaPrincipalForm(UsuarioEntidad usuario)
        {
            InitializeComponent();
            usuarioLogeado = usuario;
        }

        private void PantallaPrincipalForm_Load(object sender, EventArgs e)
        {
            model = new();
            NombreUsuario.Text = usuarioLogeado.NombreUsuario;
            RolUsuario.Text = usuarioLogeado.Rol.ToString();
        }

        private void RecepcionOrdenesPreparacionButton_Click(object sender, EventArgs e)
        {
            RecepcionOrdenesPreparacionForm recepcionOrdenesPreparacionForm = new();
            this.Hide();
            recepcionOrdenesPreparacionForm.Show();
        }

        private void GeneracionOrdenesSeleccionButton_Click(object sender, EventArgs e)
        {
            GeneracionOrdenesSeleccionForm generacionOrdenesSeleccionForm = new();
            this.Hide();
            generacionOrdenesSeleccionForm.Show();
        }

        private void EmpaquetadoButton_Click(object sender, EventArgs e)
        {
            EmpaquetadoForm empaquetadoForm= new();
            this.Hide();
            empaquetadoForm.Show();
        }

        private void DespachoButton_Click(object sender, EventArgs e)
        {
            DespachoForm despachoForm= new();
            this.Hide();
            despachoForm.Show();
        }
    }
}
