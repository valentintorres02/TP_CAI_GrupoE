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

namespace TP_CAI.Forms.PantallaPrincipal.Forms
{

    public partial class PantallaPrincipalForm : Form
    {
        private UsuarioEntidad usuarioLogeado;

        public PantallaPrincipalForm(UsuarioEntidad usuario)
        {
            InitializeComponent();
            usuarioLogeado = usuario;
        }

        private void PantallaPrincipalForm_Load(object sender, EventArgs e)
        {
            NombreUsuario.Text = usuarioLogeado.NombreUsuario;
            RolUsuario.Text = usuarioLogeado.Rol.ToString();
        }

    }
}
