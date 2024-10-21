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
using TP_CAI.Forms.OrdenDePreparacion.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;

namespace TP_CAI.Archivos.OrdenDeSeleccion.Forms
{
    public partial class OrdenDeSeleccionForm : Form
    {
        private OrdenDeSeleccionModel _ordenDeSeleccionModel;

        public OrdenDeSeleccionForm()
        {
            InitializeComponent();
            _ordenDeSeleccionModel = new OrdenDeSeleccionModel();
        }

        private void OrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
            OrdenesPreparacionPendientesListView.FullRowSelect = true;
            OrdenesPreparacionSeleccionadasListView.FullRowSelect = true;

            CargarPrioridadesCombobox();
            CargarClientesCombobox();

            ActualizarOrdenesFiltradas();

        }

        private bool OrdenEnProceso()
        {
            bool ordenEnProceso = false;

            if (_ordenDeSeleccionModel.OrdenesDePreparacionAgregadas.Count > 0)
            {
                ordenEnProceso = true;
            }

            return ordenEnProceso;
        }

        private void ActualizarOrdenesFiltradas()
        {
            OrdenesPreparacionPendientesListView.Items.Clear();

            List<OrdenPreparacion> ordenes = _ordenDeSeleccionModel.OrdenesDePreparacionFiltradas;

            foreach (var orden in ordenes)
            {
                // Crear un nuevo ListViewItem con todos los elementos convertidos a string
                ListViewItem item = new ListViewItem(new[]
                {
                    orden.Id.ToString(),
                    orden.Prioridad.ToString(),
                    orden.DocumentoCliente,
                    orden.FechaEntrega.ToString("d"),
                });

                OrdenesPreparacionPendientesListView.Items.Add(item);
            }
        }

        private void ActualizarOrdenesAgregadas()
        {
            OrdenesPreparacionSeleccionadasListView.Items.Clear();

            List<OrdenPreparacion> ordenes = _ordenDeSeleccionModel.OrdenesDePreparacionAgregadas;

            if (ordenes != null)
            {
                foreach (var orden in ordenes)
                {
                    // Crear un nuevo ListViewItem con todos los elementos convertidos a string
                    ListViewItem item = new ListViewItem(new[]
                    {
                        orden.Id.ToString(),
                        orden.Prioridad.ToString(),
                        orden.DocumentoCliente,
                        orden.FechaEntrega.ToString("d"),
                    });

                    OrdenesPreparacionSeleccionadasListView.Items.Add(item);
                }
            }
        }
        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            // Iterar sobre todos los elementos en el ListView
            foreach (ListViewItem item in OrdenesPreparacionPendientesListView.Items)
            {
                // Marcar el checkbox como seleccionado
                item.Checked = false;
            }
        }

        private void CargarPrioridadesCombobox()
        {
            var prioridades = Enum.GetNames(typeof(PrioridadEnum)).ToList();
            PrioridadCombobox.Items.AddRange(prioridades.ToArray());
        }

        private void CargarClientesCombobox()
        {
            List<Cliente> clientes = _ordenDeSeleccionModel.Clientes;

            ClienteCombobox.DataSource = clientes;
            ClienteCombobox.DisplayMember = "DisplayText"; // Texto visible
            ClienteCombobox.ValueMember = "Documento";       // Valor asociado

            ClienteCombobox.SelectedIndex = -1; // arranca sin ningun valor
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los filtros desde los controles de la interfaz de usuario
            PrioridadEnum? prioridadSeleccionada = null;
            if (PrioridadCombobox.SelectedItem != null)
            {
                // Convertir el valor seleccionado a PrioridadEnum
                prioridadSeleccionada = (PrioridadEnum)Enum.Parse(typeof(PrioridadEnum), PrioridadCombobox.SelectedItem.ToString());
            }

            string documentoCliente = string.IsNullOrWhiteSpace(ClienteCombobox.Text) ? null : ClienteCombobox.SelectedValue.ToString();

            DateTime? fechaEntrega = null;
            if (FechaEntregaDatePicker.Value != null && FechaEntregaDatePicker.Checked)
            {
                fechaEntrega = FechaEntregaDatePicker.Value.Date;
            }

            _ordenDeSeleccionModel.FiltrarOrdenes(prioridadSeleccionada, documentoCliente, fechaEntrega);


            // Actualizar la lista de órdenes mostradas
            ActualizarOrdenesFiltradas();            
        }

        private void LimpiarFiltroButton_Click(object sender, EventArgs e)
        {
            PrioridadCombobox.SelectedIndex = -1;
            ClienteCombobox.SelectedIndex = -1;

            _ordenDeSeleccionModel.ResetearFiltros();
            ActualizarOrdenesFiltradas();
        }

        private void SeleccionarTodoButton_Click(object sender, EventArgs e)
        {
            // Iterar sobre todos los elementos en el ListView
            foreach (ListViewItem item in OrdenesPreparacionPendientesListView.Items)
            {
                // Marcar el checkbox como seleccionado
                item.Checked = true;
            }
        }

        private void AgregarALaOrdenButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in OrdenesPreparacionPendientesListView.Items)
            {
                if (item.Checked) // Si el checkbox está marcado
                {
                    int idOrdenPreparacion = int.Parse(item.SubItems[0].Text);
                    _ordenDeSeleccionModel.AgregarOrdenDePreparacionAOrdenDeSeleccion(idOrdenPreparacion);
                }
            }

            ActualizarOrdenesAgregadas();
            ActualizarOrdenesFiltradas();
        }

        private void EliminarProductoButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in OrdenesPreparacionSeleccionadasListView.Items)
            {
                if (item.Checked) // Si el checkbox está marcado
                {
                    int idOrdenPreparacion = int.Parse(item.SubItems[0].Text);
                    _ordenDeSeleccionModel.EliminarOrdenDePreparacionDeOrdenDeSeleccion(idOrdenPreparacion);
                }
            }

            ActualizarOrdenesAgregadas();
            ActualizarOrdenesFiltradas();
        }

        private void SeleccionarTodoButton2_Click(object sender, EventArgs e)
        {
            // Iterar sobre todos los elementos en el ListView
            foreach (ListViewItem item in OrdenesPreparacionSeleccionadasListView.Items)
            {
                // Marcar el checkbox como seleccionado
                item.Checked = true;
            }
        }

        private void LimpiarButton2_Click(object sender, EventArgs e)
        {
            // Iterar sobre todos los elementos en el ListView
            foreach (ListViewItem item in OrdenesPreparacionSeleccionadasListView.Items)
            {
                // Marcar el checkbox como seleccionado
                item.Checked = false;
            }
        }

        private void ResetearFormulario()
        {
            _ordenDeSeleccionModel.ResetearFiltros();
            ActualizarOrdenesAgregadas();
            ActualizarOrdenesFiltradas();

        }

        private void CrearOrdenButton_Click(object sender, EventArgs e)
        {
            // Lista para almacenar los IDs de las órdenes seleccionadas
            List<int> idsOrdenesPreparacion = new List<int>();

            foreach (ListViewItem item in OrdenesPreparacionSeleccionadasListView.Items)
            {
                int idOrdenPreparacion = int.Parse(item.SubItems[0].Text);
                idsOrdenesPreparacion.Add(idOrdenPreparacion);
            }

            string errorOrdenesPreparacion = _ordenDeSeleccionModel.ValidarOrdenesSeleccionadas(idsOrdenesPreparacion.Count);

            if (errorOrdenesPreparacion != null)
            {
                MessageBox.Show(errorOrdenesPreparacion);
                return;
            }

            var nuevaOrden = _ordenDeSeleccionModel.CrearOrden(idsOrdenesPreparacion);

            MessageBox.Show($"La orden de selección ID {nuevaOrden.Id} se generó correctamente");

            ResetearFormulario();
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
