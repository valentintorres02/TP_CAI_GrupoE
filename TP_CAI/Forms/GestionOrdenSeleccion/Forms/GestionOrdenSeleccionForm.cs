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
using static TP_CAI.Forms.GestionOrdenSeleccion.Model.GestionOrdenSeleccionModel;

namespace TP_CAI.Forms.GestionOrdenSeleccion.Forms
{
    public partial class GestionOrdenSeleccionForm : Form
    {
        private GestionOrdenSeleccionModel _gestionOrdenSeleccionModel;
        public GestionOrdenSeleccionForm()
        {
            InitializeComponent();
            _gestionOrdenSeleccionModel = new GestionOrdenSeleccionModel();
        }

        private void GestionOrdenSeleccionForm_Load(object sender, EventArgs e)
        {

            ActualizarOrdenesDeSeleccion();

        }

        private void ActualizarOrdenesDeSeleccion()
        {
            OrdenesSeleccionPendientesListView.Items.Clear();
            List<OrdenSeleccion> ordenes = _gestionOrdenSeleccionModel.OrdenesDeSeleccion;

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.Id.ToString(),
                    });

                OrdenesSeleccionPendientesListView.Items.Add(item);
            }
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

        private void VerItemsButton_Click(object sender, EventArgs e)
        {
            ItemsASeleccionarListView.Items.Clear();

            List<Producto> productos = _gestionOrdenSeleccionModel.Productos;

            foreach (var producto in productos)
            {
                var item = new ListViewItem(new[]
                  {
                        producto.Ubicacion,
                        producto.Cantidad.ToString(),
                        producto.IdProducto,
                        producto.DescripcionProducto,
                    });

                ItemsASeleccionarListView.Items.Add(item);
            }
        }

        private void ResetearFormulario()
        {
            ItemsASeleccionarListView.Items.Clear();
        }

        private void MarcarComoSeleccionadaButton_Click(object sender, EventArgs e)
        {
            string idOrdenSeleccionada = "";

            // Verificar si hay elementos seleccionados en el ListView
            if (OrdenesSeleccionPendientesListView.SelectedItems.Count > 0)
            {
                // Obtener el primer item seleccionado
                ListViewItem selectedItem = OrdenesSeleccionPendientesListView.SelectedItems[0];

                // Obtener el valor del ID (en este caso, asumimos que está en la primera columna)
                idOrdenSeleccionada = selectedItem.SubItems[0].Text;

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna orden. Por favor seleccione una");
                return;
            }

            _gestionOrdenSeleccionModel.EliminarOrdenDeLista(int.Parse(idOrdenSeleccionada));
            ActualizarOrdenesDeSeleccion();
            MessageBox.Show("Se seleccionó correctamente la selección de la orden de selección ID " + idOrdenSeleccionada);
            ResetearFormulario();
        }
    }


}
