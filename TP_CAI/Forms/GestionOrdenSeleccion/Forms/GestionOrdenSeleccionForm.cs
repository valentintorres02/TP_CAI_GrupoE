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

            if (ordenes.Count == 0)
            {
                MessageBox.Show("Actualmente no hay ordenes de seleccion pendientes.");
            }

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.Id.ToString(),
                    });

                OrdenesSeleccionPendientesListView.Items.Add(item);
            }
        }
        private void VerItemsButton_Click(object sender, EventArgs e)
        {
            ItemsASeleccionarListView.Items.Clear();
            int idOrdenSeleccionada = ObtenerIdOrden();

            if(idOrdenSeleccionada == -1)
            {
                return;
            }   

            List<Producto> productos = _gestionOrdenSeleccionModel.ObtenerProductosDeOrden(idOrdenSeleccionada);
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

        private int ObtenerIdOrden()
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
                return -1;
            }

            return int.Parse(idOrdenSeleccionada);
        }

        private void MarcarComoSeleccionadaButton_Click(object sender, EventArgs e)
        {
            int idOrdenSeleccionada = ObtenerIdOrden();

            if (idOrdenSeleccionada == -1)
            {
                return;
            }

            _gestionOrdenSeleccionModel.MarcarOrdenComoSeleccionada(idOrdenSeleccionada);
            MessageBox.Show("Se seleccionó correctamente la orden de selección ID " + idOrdenSeleccionada);
            ActualizarOrdenesDeSeleccion();
            ResetearFormulario();
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

        private void VolverButton_Click(object sender, EventArgs e)
        {
            VolverAlMenu();
        }

        private void GestionOrdenSeleccionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VolverAlMenu();
        }
    }


}
