using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI.Archivos.PantallaPrincipal.Forms;
using TP_CAI.Forms.Empaquetado.Model;
using TP_CAI.Forms.GestionOrdenSeleccion.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Archivos.Empaquetado.Forms
{
    public partial class EmpaquetadoForm : Form
    {
        private EmpaquetadoModel _empaquetadoModel;

        public EmpaquetadoForm()
        {
            InitializeComponent();
            _empaquetadoModel = new EmpaquetadoModel();

            // Evento que chequea que solamente se seleccione 1 checkbox. El componente ListView no soporta nativamente una propiedad para solamente 1 fila se seleccione
            OrdenesPreparacionListView.ItemCheck += OrdenesPreparacionListView_ItemCheck;

        }

        private void EmpaquetadoForm_Load(object sender, EventArgs e)
        {
            List<OrdenPreparacion> ordenes = _empaquetadoModel.ObtenerOrdenes();

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.Id.ToString(),                      // Convertir ID (int) a string
                        orden.DocumentoCliente ?? string.Empty,   // Documento del cliente, aseguramos que no sea null
                        orden.Prioridad.ToString(),               // Convertir PrioridadEnum a string
                        orden.Estado.ToString()                   // Convertir EstadoOrdenPreparacionEnum a string
                    });

                // Agregar el item al ListView
                OrdenesPreparacionListView.Items.Add(item);
            }

            GenerarOrdenButton.Enabled = false; // El botón empieza deshabilitado
            LimpiarButton.Enabled = false;

            OrdenesPreparacionListView.ItemCheck += OrdenesPreparacionListView_ItemCheck;
        }

        private void OrdenesPreparacionListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Evitar que se seleccione más de un checkbox
            if (e.NewValue == CheckState.Checked)
            {
                foreach (ListViewItem item in OrdenesPreparacionListView.Items)
                {
                    if (item != OrdenesPreparacionListView.Items[e.Index])
                    {
                        // Desmarcar otros checkboxes
                        item.Checked = false;
                    }
                }
            }

            bool hayOrdenSeleccionada = e.NewValue == CheckState.Checked;

            GenerarOrdenButton.Enabled = hayOrdenSeleccionada;
        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registró correctamente el empaquetado de la orden de preparación ID 0009");
        }

        private void VolverAlMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                     "Tienes una Órden de Preparación en proceso. Si sales se perderá el progreso y la órden no será creada, ¿deseas salir?",
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
