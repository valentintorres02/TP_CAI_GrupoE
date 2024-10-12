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
using TP_CAI.Forms.GestionOrdenSeleccion.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.GestionOrdenSeleccion.Forms
{
    public partial class GestionOrdenSeleccionForm : Form
    {
        private GestionOrdenSeleccionModel _gestionOrdenSeleccionModel;
        public GestionOrdenSeleccionForm()
        {
            InitializeComponent();
            _gestionOrdenSeleccionModel = new GestionOrdenSeleccionModel();

            // Evento que chequea que solamente se seleccione 1 checkbox. El componente ListView no soporta nativamente una propiedad para solamente 1 fila se seleccione
            OrdenesSeleccionListView.ItemCheck += OrdenesSeleccionListView_ItemCheck;

        }

        private void OrdenesSeleccionListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Evitar que se seleccione más de un checkbox
            if (e.NewValue == CheckState.Checked)
            {
                foreach (ListViewItem item in OrdenesSeleccionListView.Items)
                {
                    if (item != OrdenesSeleccionListView.Items[e.Index])
                    {
                        // Desmarcar otros checkboxes
                        item.Checked = false;
                    }
                }
            }

            bool hayOrdenSeleccionada = e.NewValue == CheckState.Checked;

            GenerarOrdenButton.Enabled = hayOrdenSeleccionada;
        }

        private void GestionOrdenSeleccionForm_Load(object sender, EventArgs e)
        {

            List<OrdenSeleccion> ordenes = _gestionOrdenSeleccionModel.ObtenerOrdenes();

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.Id.ToString(),                      // Convertir ID (int) a string
                        orden.DocumentoCliente ?? string.Empty,   // Documento del cliente, aseguramos que no sea null
                        orden.Estado.ToString()                   // Convertir EstadoOrdenPreparacionEnum a string
                    });

                OrdenesSeleccionListView.Items.Add(item);
            }

            GenerarOrdenButton.Enabled = false; // El botón empieza deshabilitado
        }

        private void VolverAlMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tienes una Órden de Seleccion en proceso. Si sales se perderá el progreso y la órden no será seleccionada, ¿deseas salir?",
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VolverAlMenuButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Tienes una Órden de Seleccion en proceso. Si sales se perderá el progreso y la órden no será seleccionada, ¿deseas salir?",
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

        private void GenerarOrdenButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se seleccionó correctamente la selección de la orden de selección ID 0009");
        }
    }


}
