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
using TP_CAI.Forms.Despacho.Model;
using TP_CAI.Forms.OrdenDeEntrega.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;
using static TP_CAI.Forms.Despacho.Model.DespachoModel;

namespace TP_CAI.Archivos.Despacho.Forms
{
    public partial class DespachoForm : Form
    {
        private DespachoModel _despachoModel;

        public DespachoForm()
        {
            InitializeComponent();
            _despachoModel = new DespachoModel();
        }

        private void GenerarRemitoYDespacharButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se generó correctamente el remito N°1405 y se registró correctamente el despacho de las órdenes de preparación.");
        }

        private void DespachoForm_Load(object sender, EventArgs e)
        {
            // Registrar el evento SelectedIndexChanged para el ComboBox
            OrdenDeEntregaComboBox.SelectedIndexChanged += OrdenDeEntregaComboBox_SelectedIndexChanged;
        }

        // Evento que se dispara cuando se selecciona un elemento en el ComboBox
        private void OrdenDeEntregaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un elemento (índice >= 0)
            if (OrdenDeEntregaComboBox.SelectedIndex >= 0)
            {
                SeleccionarOrdenButton.Enabled = true; // Habilitar el botón
            }
            else
            {
                SeleccionarOrdenButton.Enabled = false; // Deshabilitar si no hay selección
            }
        }

        private void SeleccionarOrdenButton_Click(object sender, EventArgs e)
        {
            OrdenesPreparacionListView.Enabled = true;
            GenerarRemitoYDespacharButton.Enabled = true;
            OrdenesDePreparacionLabel.Enabled = true;

            List<OrdenPreparacion> ordenes = _despachoModel.ObtenerOrdenesPreparacion();

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.Id.ToString(),                      // Convertir ID (int) a string
                        orden.DocumentoCliente ?? string.Empty,   // Documento del cliente, aseguramos que no sea null
                        orden.NombreCliente ?? string.Empty,      // Nombre del cliente, aseguramos que no sea null
                        orden.DNITransportista.ToString(),        // Convertir DNI (int) a string
                        orden.Prioridad.ToString(),               // Convertir PrioridadEnum a string
                        orden.Estado.ToString()                   // Convertir EstadoOrdenPreparacionEnum a string
                    });

                // Agregar el item al ListView
                OrdenesPreparacionListView.Items.Add(item);
            }
        }

        private void VolverAlMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tienes un Despacho en proceso. Si sales se perderá el progreso y la órden no será creada, ¿deseas salir?",
                "Advertencia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // Si el usuario selecciona "Sí"
            if (result == DialogResult.Yes)
            {
                // Crear una nueva instancia del formulario de menú principal
                PantallaPrincipalForm pantallaPrincipalForm = new PantallaPrincipalForm();

                // Mostrar el formulario de menú principal
                pantallaPrincipalForm.Show();

                // Cerrar el formulario actual
                this.Close();
            }
        }
    }
}
