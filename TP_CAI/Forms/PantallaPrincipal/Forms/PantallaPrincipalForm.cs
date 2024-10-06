using System;
using System.Windows.Forms;
using TP_CAI.Archivos.Despacho.Forms;
using TP_CAI.Archivos.Empaquetado.Forms;
using TP_CAI.Archivos.OrdenDeSeleccion.Forms;
using TP_CAI.Archivos.OrdenDePreparacion.Forms;
using TP_CAI.Forms.PantallaPrincipal.Model;

namespace TP_CAI.Archivos.PantallaPrincipal.Forms
{
    public partial class PantallaPrincipalForm : Form
    {
        PantallaPrincipalModel model;

        public PantallaPrincipalForm()
        {
            InitializeComponent();
        }

        private void PantallaPrincipalForm_Load(object sender, EventArgs e)
        {
            model = new PantallaPrincipalModel();
        }

        private void RecepcionOrdenesPreparacionButton_Click(object sender, EventArgs e)
        {
            OrdenDePreparacion.Forms.OrdenDePreparacionForm recepcionOrdenesPreparacionForm = new OrdenDePreparacionForm();
            this.Hide();
            recepcionOrdenesPreparacionForm.Show();
        }

        private void GeneracionOrdenesSeleccionButton_Click(object sender, EventArgs e)
        {
            OrdenDeSeleccion.Forms.OrdenDeSeleccionForm generacionOrdenesSeleccionForm = new OrdenDeSeleccionForm();
            this.Hide();
            generacionOrdenesSeleccionForm.Show();
        }

        private void EmpaquetadoButton_Click(object sender, EventArgs e)
        {
            EmpaquetadoForm empaquetadoForm = new EmpaquetadoForm();
            this.Hide();
            empaquetadoForm.Show();
        }

        private void DespachoButton_Click(object sender, EventArgs e)
        {
            DespachoForm despachoForm = new DespachoForm();
            this.Hide();
            despachoForm.Show();
        }
    }
}
