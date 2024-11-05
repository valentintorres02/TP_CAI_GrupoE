using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI.Archivos.PantallaPrincipal.Forms;
using TP_CAI.Forms.Empaquetado.Model;
using TP_CAI.Forms.OrdenDeEntrega.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;
using static TP_CAI.Forms.OrdenDeEntrega.Model.OrdenDeEntregaModel;

namespace TP_CAI.Forms.OrdenDeEntrega.Forms
{
    public partial class OrdenDeEntregaForm : Form
    {
        private OrdenDeEntregaModel _ordenDeEntregaModel;

        public OrdenDeEntregaForm()
        {
            InitializeComponent();
            _ordenDeEntregaModel = new OrdenDeEntregaModel();
        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            string errorOrdenEntrega = _ordenDeEntregaModel.ValidarOrdenEntrega();

            if (errorOrdenEntrega != null)
            {
                MessageBox.Show(errorOrdenEntrega);
                return;
            }

            OrdenEntrega ordenEntrega = _ordenDeEntregaModel.CrearOrdenEntrega();
            MessageBox.Show("Se registró correctamente la orden de entrega ID " + ordenEntrega.Id);
            ActualizarTabla();
        }

        private void OrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            List<OrdenPreparacion> ordenesPreparacion = _ordenDeEntregaModel.OrdenesDePreparacion;

            OrdenesPreparacionListView.Items.Clear();

            if (ordenesPreparacion.Count == 0)
            {
                MessageBox.Show("No hay ordenes de preparacion preparadas para agregar a la orden de entrega");
            }

            foreach (var orden in ordenesPreparacion)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.Id.ToString(),
                        orden.FechaEntrega.ToString(),
                    });

                // Agregar el item al ListView
                OrdenesPreparacionListView.Items.Add(item);
            }
        }

        private void VolverAlMenu()
        {
            // Solo oculta el formulario actual
            this.Hide();

            // Mostrar el formulario de menú principal
            // Verifica si el formulario principal ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is PantallaPrincipalForm)
                {
                    form.Show(); // Muestra el formulario si está oculto
                    return;
                }
            }

            // Si no está abierto, crea una nueva instancia (solo si es necesario)
            PantallaPrincipalForm pantallaPrincipalForm = new PantallaPrincipalForm();
            pantallaPrincipalForm.Show();
        }

        private void VolverAlMenuButton_Click(object sender, EventArgs e)
        {
            VolverAlMenu();
        }

        private void OrdenDeEntregaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VolverAlMenu();
        }
    }
}
