using System;
using System.Windows.Forms;
using TP_CAI.Archivos.Usuario.Entidad;

namespace TP_CAI.Archivos.Forms.BaseForm
{
    public class BaseForm : Form
    {
        protected UsuarioEntidad usuarioLogeado;

        public BaseForm(UsuarioEntidad usuario)
        {
            usuarioLogeado = usuario;
        }
    }
}
