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
        private OrdenSeleccionModel _ordenDeSeleccionModel;

        public OrdenDeSeleccionForm()
        {
            InitializeComponent();
            _ordenDeSeleccionModel = new OrdenSeleccionModel();
        }

        private void OrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {
            OrdenesPreparacionPendientesListView.FullRowSelect = true;
            OrdenesPreparacionSeleccionadasListView.FullRowSelect = true;
            FechaEntregaDesdeDatePicker.Checked = false;
            FechaEntregaHastaDatePicker.Checked = false;

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
            if (PrioridadCombobox.SelectedItem != null && !string.IsNullOrWhiteSpace(PrioridadCombobox.SelectedItem.ToString()))
            {
                // Convertir el valor seleccionado a PrioridadEnum, ignorando mayúsculas y minúsculas
                prioridadSeleccionada = (PrioridadEnum)Enum.Parse(typeof(PrioridadEnum), PrioridadCombobox.SelectedItem.ToString(), true);
            }

            // Obtener el documento del cliente, validando que SelectedValue no sea nulo
            string documentoCliente = ClienteCombobox.SelectedValue?.ToString();

            DateTime? fechaEntregaDesde = null;
            if (FechaEntregaDesdeDatePicker.Value != null && FechaEntregaDesdeDatePicker.Checked)
            {
                fechaEntregaDesde = FechaEntregaDesdeDatePicker.Value.Date;
            }

            DateTime? fechaEntregaHasta= null;
            if (FechaEntregaHastaDatePicker.Value != null && FechaEntregaHastaDatePicker.Checked)
            {
                fechaEntregaHasta= FechaEntregaHastaDatePicker.Value.Date;
            }

            // Filtrar las órdenes en el modelo
            _ordenDeSeleccionModel.FiltrarOrdenes(prioridadSeleccionada, documentoCliente, fechaEntregaDesde, fechaEntregaHasta);

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
                    string agregarOrdenError = _ordenDeSeleccionModel.AgregarOrdenDePreparacionAOrdenDeSeleccion(idOrdenPreparacion);

                    if (agregarOrdenError != null)
                    {
                        MessageBox.Show(agregarOrdenError);
                        return;
                    }

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
                    string eliminarOrdenError = _ordenDeSeleccionModel.EliminarOrdenDePreparacionDeOrdenDeSeleccion(idOrdenPreparacion);

                    if (eliminarOrdenError != null)
                    {
                        MessageBox.Show(eliminarOrdenError);
                        return;
                    }
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
            ClienteCombobox.SelectedIndex = -1;
            PrioridadCombobox.SelectedIndex = -1;
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

            var nuevaOrdenMsg = _ordenDeSeleccionModel.CrearOrden(idsOrdenesPreparacion);

            MessageBox.Show(nuevaOrdenMsg);

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
        private void OrdenDeSeleccionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VolverAlMenu();
        }
    }

}
