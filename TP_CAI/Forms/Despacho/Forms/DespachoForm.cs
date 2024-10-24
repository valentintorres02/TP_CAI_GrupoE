﻿using System;
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
using static TP_CAI.Forms.Despacho.Model.DespachoModel;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;
using OrdenPreparacion = TP_CAI.Forms.Despacho.Model.DespachoModel.OrdenPreparacion;

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

            List<OrdenPreparacion> ordenesPreparacion = _despachoModel.ObtenerOrdenesPorTransportista(documentoTransportista);

            OrdenesADespacharListView.Items.Clear();
            foreach (var orden in ordenesPreparacion)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.Id.ToString(),
                        orden.Estado.ToString(),
                        orden.IdOrdenEntrega.ToString(),
                        orden.FechaEntrega.ToString("dd/MM/yyyy"),
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
            string documentoTransportista = ObtenerDocumentoTransportista();
            _despachoModel.MarcarComoListasParaDespacho(documentoTransportista);
            ActualizarTabla();
            MessageBox.Show("Ordenes marcadas como listas para despacho correctamente");
        }


        private bool OrdenEnProceso()
        {
            bool ordenEnProceso = false;

            if (OrdenesADespacharListView.Items.Count > 0)
            {
                ordenEnProceso = true;
            }

            return ordenEnProceso;
        }

        private void VolverAlMenu()
        {
            // Crear una nueva instancia del formulario de menú principal
            PantallaPrincipalForm pantallaPrincipalForm = new PantallaPrincipalForm();

            // Mostrar el formulario de menú principal
            pantallaPrincipalForm.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            bool ordenEnProceso = OrdenEnProceso();

            if (!ordenEnProceso)
            {
                VolverAlMenu();
                return;
            }

            DialogResult result = MessageBox.Show(
              "Se dispone a cerrar el formulario. ¿Está seguro?",
              "Advertencia",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);

            // Si el usuario selecciona "Sí"
            if (result == DialogResult.Yes)
            {
                VolverAlMenu();
            }
        }
    }
}
