using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI.Archivos.Forms.BaseForm;
using TP_CAI.Archivos.Usuario.Entidad;

namespace TP_CAI.Archivos.GeneracionOrdenesSeleccion.Forms
{
    public partial class GeneracionOrdenesSeleccionForm : BaseForm
    {
        public GeneracionOrdenesSeleccionForm(UsuarioEntidad usuario) : base(usuario)
        {
            InitializeComponent();
        }
    }
}
