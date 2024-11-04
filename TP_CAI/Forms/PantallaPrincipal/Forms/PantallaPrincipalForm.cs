using System;
using System.Windows.Forms;
using TP_CAI.Archivos.Despacho.Forms;
using TP_CAI.Archivos.Empaquetado.Forms;
using TP_CAI.Archivos.OrdenDeSeleccion.Forms;
using TP_CAI.Archivos.OrdenDePreparacion.Forms;
using TP_CAI.Forms.OrdenDeEntrega.Forms;
using TP_CAI.Forms.PantallaPrincipal.Model;
using TP_CAI.Forms.GestionOrdenSeleccion.Forms;

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
            OrdenDePreparacionForm ordenDePreparacionForm = new OrdenDePreparacionForm();
            this.Hide();
            ordenDePreparacionForm.Show();
        }

        private void GeneracionOrdenesSeleccionButton_Click(object sender, EventArgs e)
        {
            OrdenDeSeleccionForm ordenDeSeleccionForm = new OrdenDeSeleccionForm();
            this.Hide();
            ordenDeSeleccionForm.Show();
        }

        private void GestionOrdenSeleccionButton_Click(object sender, EventArgs e)
        {
            GestionOrdenSeleccionForm gestionOrdenSeleccionForm = new GestionOrdenSeleccionForm();
            this.Hide();
            gestionOrdenSeleccionForm.Show();
        }

        private void EmpaquetadoButton_Click(object sender, EventArgs e)
        {
            EmpaquetadoForm empaquetadoForm = new EmpaquetadoForm();
            this.Hide();
            empaquetadoForm.Show();
        }
        private void CrearOrdenDeEntrega_Click(object sender, EventArgs e)
        {
            OrdenDeEntregaForm ordenDeEntregaForm = new OrdenDeEntregaForm();
            this.Hide();
            ordenDeEntregaForm.Show();
        }

        private void DespachoButton_Click(object sender, EventArgs e)
        {
            DespachoForm despachoForm = new DespachoForm();
            this.Hide();
            despachoForm.Show();
        }

        private void PantallaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
