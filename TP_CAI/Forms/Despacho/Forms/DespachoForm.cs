using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CAI.Archivos.Despacho.Forms
{
    public partial class DespachoForm : Form
    {
        public DespachoForm()
        {
            InitializeComponent();
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
            OrdenesPreparacionGridView.Enabled = true;
            GenerarRemitoYDespacharButton.Enabled = true;
            OrdenesDePreparacionLabel.Enabled = true;

            OrdenesPreparacionGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            // Agregar otras columnas
            OrdenesPreparacionGridView.Columns.Add("Columna1", "ID Orden");
            OrdenesPreparacionGridView.Columns.Add("Columna2", "CUIT/CUIL Cliente");
            OrdenesPreparacionGridView.Columns.Add("Columna2", "Nombre Cliente");
            OrdenesPreparacionGridView.Columns.Add("Columna2", "DNI Transportista");
            OrdenesPreparacionGridView.Columns.Add("Columna3", "Prioridad");
            OrdenesPreparacionGridView.Columns.Add("Columna4", "Estado");

            // Agregar algunas filas como ejemplo
            OrdenesPreparacionGridView.Rows.Add("019", "20-44444444-4", "GrupoE S.R.L", "35012345", "Media", "Preparada");
            OrdenesPreparacionGridView.Rows.Add("025", "20-44444444-4", "C.A.I S.A", "35012345", "Media", "Preparada");
            OrdenesPreparacionGridView.Rows.Add("034", "20-44444444-4", "Grupo-Z S.A", "35012345", "Media", "Preparada");
            OrdenesPreparacionGridView.Rows.Add("055", "20-44444444-4", "Molinos S.R.L", "35012345", "Media", "Preparada");
        }
    }
}
