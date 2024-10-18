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
using TP_CAI.Forms.OrdenDePreparacion.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;
using static TP_CAI.Forms.Despacho.Model.DespachoModel;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;

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
            CargarTransportistasCombobox();
        }

        private void CargarTransportistasCombobox()
        {
            List<Transportista> transportistas = _despachoModel.Transportistas;

            TransportistasCombobox.DataSource = transportistas;
            TransportistasCombobox.DisplayMember = "DisplayText"; // Texto visible
            TransportistasCombobox.ValueMember = "Documento";       // Valor asociado

            TransportistasCombobox.SelectedIndex = -1; // arranca sin ningun valor
        }

        private string ObtenerDocumentoTransportista()
        {
            string documentoTransportista = "";


            if (TransportistasCombobox.SelectedValue != null)
            {
                documentoTransportista = TransportistasCombobox.SelectedValue.ToString();
            }

            string errorDocumentoTransportistaSeleccionado = _despachoModel.ValidarTransportista(documentoTransportista);

            if (errorDocumentoTransportistaSeleccionado != null)
            {
                MessageBox.Show(errorDocumentoTransportistaSeleccionado);
                return null;
            }

            return documentoTransportista;
        }

        private void ActualizarTabla()
        {
            string documentoTransportista = ObtenerDocumentoTransportista();

            List<OrdenEntrega> ordenesEntrega = _despachoModel.ObtenerOrdenesPorTransportista(documentoTransportista);

            OrdenesADespacharListView.Items.Clear();
            foreach (var orden in ordenesEntrega)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.Id.ToString(),
                    });

                // Agregar el item al ListView
                OrdenesADespacharListView.Items.Add(item);
            }
        }

        private void SeleccionarTransportistaButton_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void MarcarComoDespachadasButton_Click(object sender, EventArgs e)
        {
            OrdenesADespacharListView.Items.Clear();
            TransportistasCombobox.SelectedIndex = -1;
            MessageBox.Show("Ordenes despachadas correctamente");
        }

        private void MarcarComoListasButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ordenes marcadas como listas para despacho correctamente");
        }

        private void VolverButton_Click(object sender, EventArgs e)
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
