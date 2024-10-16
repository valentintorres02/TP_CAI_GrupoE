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
using TP_CAI.Forms.OrdenDePreparacion.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;

namespace TP_CAI.Archivos.OrdenDePreparacion.Forms
{
    public partial class OrdenDePreparacionForm : Form
    {
        private OrdenDePreparacionModel _ordenDePreparacionModel;

        public OrdenDePreparacionForm()
        {
            InitializeComponent();
            _ordenDePreparacionModel = new OrdenDePreparacionModel();
        }

        private void OrdenDePreparacionForm_Load(object sender, EventArgs e)
        {
            ResetearFormulario();
            ProductosDisponiblesListView.FullRowSelect = true;
            ProductosAgregadosListView.FullRowSelect = true;

            CargarClientesCombobox();
            CargarDepositosCombobox();
        }

        private void CargarClientesCombobox()
        {
            List<Cliente> clientes = _ordenDePreparacionModel.Clientes;

            ClienteCombobox.DataSource = clientes;
            ClienteCombobox.DisplayMember = "DisplayText"; // Texto visible
            ClienteCombobox.ValueMember = "Documento";       // Valor asociado

            ClienteCombobox.SelectedIndex = -1; // arranca sin ningun valor
        }

        private void CargarDepositosCombobox()
        {
            List<Deposito> depositos = _ordenDePreparacionModel.Depositos;

            DepositoCombobox.DataSource = depositos;
            DepositoCombobox.DisplayMember = "DisplayText"; // Texto visible
            DepositoCombobox.ValueMember = "Id";       // Valor asociado

            DepositoCombobox.SelectedIndex = -1; // arranca sin ningun valor
        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {
            string documentoClienteSeleccionado = "";


            if (ClienteCombobox.SelectedValue != null)
            {
                documentoClienteSeleccionado = ClienteCombobox.SelectedValue.ToString();
            }

            string errorDocumentoClienteSeleccionado = _ordenDePreparacionModel.ValidarCliente(documentoClienteSeleccionado);

            if (errorDocumentoClienteSeleccionado != null)
            {
                MessageBox.Show(errorDocumentoClienteSeleccionado);
                return;
            }

            string idDepositoSeleccionado = "";

            if (DepositoCombobox.SelectedValue != null)
            {
                idDepositoSeleccionado = DepositoCombobox.SelectedValue.ToString();
            }

            string errorIdDepositoSeleccionado = _ordenDePreparacionModel.ValidarDeposito(idDepositoSeleccionado);

            if (errorIdDepositoSeleccionado != null)
            {
                MessageBox.Show(errorIdDepositoSeleccionado);
                return;
            }

            ProductosGroup.Enabled = true;
            InfoOrdenGroup.Enabled = true;
            CrearOrdenButton.Enabled = true;

            // Mapear productos disponibles a la lista
            foreach (var producto in _ordenDePreparacionModel.ProductosDisponibles)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                producto.Id,
                producto.Descripcion,
                producto.Cantidad.ToString()
            });

                ProductosDisponiblesListView.Items.Add(item);
            }
        }



        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            if (ProductosDisponiblesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto.");
                return;
            }

            int.TryParse(CantidadTextBox.Text, out int cantidad1);
            ListViewItem itemSeleccionado = ProductosDisponiblesListView.SelectedItems[0];

            string id = itemSeleccionado.SubItems[0].Text;  // Columna ID
            string descripcion = itemSeleccionado.SubItems[1].Text;  // Columna Descripción
            int.TryParse(itemSeleccionado.SubItems[2].Text, out int cantidad2);  // Cantidad disponible

            string? errorCantidad = _ordenDePreparacionModel.AgregarProducto(id, descripcion, cantidad1, cantidad2);

            if (errorCantidad != null)
            {
                MessageBox.Show(errorCantidad);
                return;
            }

            // Crear un nuevo ListViewItem con los valores y la cantidad especificada
            ListViewItem nuevoItem = new ListViewItem(new[] { id, descripcion, cantidad1.ToString() });

            // Agregar el nuevo item a la lista de productos agregados (ProductosAgregadosListView)
            ProductosAgregadosListView.Items.Add(nuevoItem);

            // Eliminar el item de la lista original (ProductosDisponiblesListView)
            ProductosDisponiblesListView.Items.Remove(itemSeleccionado);

            // Limpiar el campo de cantidad
            CantidadTextBox.Clear();
        }
        private void ActualizarListViewDisponibles()
        {
            ProductosDisponiblesListView.Items.Clear();
            foreach (var producto in _ordenDePreparacionModel.ProductosDisponibles)
            {
                ListViewItem item = new ListViewItem(new[] { producto.Id, producto.Descripcion, producto.Cantidad.ToString() });
                ProductosDisponiblesListView.Items.Add(item);
            }
        }

        private void ActualizarListViewAgregados()
        {
            ProductosAgregadosListView.Items.Clear();
            foreach (var producto in _ordenDePreparacionModel.ProductosAgregados)
            {
                ListViewItem item = new ListViewItem(new[] { producto.Id, producto.Descripcion, producto.Cantidad.ToString() });
                ProductosAgregadosListView.Items.Add(item);
            }
        }

        private void EliminarProductoButton_Click(object sender, EventArgs e)
        {
            if (ProductosAgregadosListView.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = ProductosAgregadosListView.SelectedItems[0];
                string id = itemSeleccionado.SubItems[0].Text;  // Columna ID

                // Eliminar el producto del modelo
                _ordenDePreparacionModel.EliminarProducto(id);

                // Actualizar la interfaz de usuario
                ActualizarListViewAgregados();
                ActualizarListViewDisponibles();
            }
        }

        private void CrearOrdenButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar productos agregados
                int cantidadProductosAgregados = ProductosAgregadosListView.Items.Count;
                string errorProductosAgregados = _ordenDePreparacionModel.ValidarProductosAgregados(cantidadProductosAgregados);

                if (errorProductosAgregados != null)
                {
                    MessageBox.Show(errorProductosAgregados);
                    return;
                }

                bool isPrioridadSeleccionada = PrioridadComboBox.SelectedIndex != -1; // -1 indica que no hay selección

                // Validar prioridad
                string errorPrioridad = _ordenDePreparacionModel.ValidarPrioridad(isPrioridadSeleccionada);

                if (errorPrioridad != null)
                {
                    MessageBox.Show(errorPrioridad);
                    return;
                }

                // Validar fecha entrega
                DateTime fechaEntregaSeleccionada = FechaEntregaDatePicker.Value;
                string errorFechaEntrega = _ordenDePreparacionModel.ValidarFechaEntrega(fechaEntregaSeleccionada);

                if (errorFechaEntrega != null)
                {
                    MessageBox.Show(errorFechaEntrega);
                    return;
                }

                // Validar el formato del DNI
                string dniText = DniTransportistaTextBox.Text;
                string errorDni = _ordenDePreparacionModel.ValidarDniTransportista(dniText);

                if (errorDni != null)
                {
                    MessageBox.Show(errorDni);
                    return;
                }

                // Obtener los valores necesarios para la creación de la orden
                string documentoCliente = "12345678"; // Aquí debes obtenerlo del formulario
                string nombreCliente = "Cliente Ejemplo"; // Aquí debes obtenerlo del formulario
                int dniTransportista = int.Parse(dniText);
                PrioridadEnum prioridad = (PrioridadEnum)PrioridadComboBox.SelectedIndex; // Ajustar según tu enumeración
                DateTime fechaDeEntrega = FechaEntregaDatePicker.Value;

                // Si todo es válido, continuar con la creación de la orden
                string mensaje = _ordenDePreparacionModel.CrearOrden(documentoCliente, nombreCliente, dniTransportista, prioridad, fechaDeEntrega);
                MessageBox.Show(mensaje);
                ResetearFormulario();
            }
            catch (Exception ex)
            {
                // Manejar errores inesperados
                MessageBox.Show("La Orden de Preparación no pudo ser creada correctamente. Por favor intente de nuevo o contacte al área de sistemas.\n" + ex.Message);
            }
        }


        private void ResetearFormulario()
        {
            // Limpiar campos de texto
            DniTransportistaTextBox.Clear();
            CantidadTextBox.Clear();

            // Restablecer comboBox
            PrioridadComboBox.SelectedIndex = -1; // Ninguna selección
            ClienteCombobox.SelectedIndex = -1;
            DepositoCombobox.SelectedIndex = -1;


            // Limpiar ListView
            ProductosAgregadosListView.Items.Clear();
            ProductosDisponiblesListView.Items.Clear();

            // Desactivar groups
            ProductosGroup.Enabled = false;
            InfoOrdenGroup.Enabled = false;
            CrearOrdenButton.Enabled = false;
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

        private void EliminarTodoButton_Click(object sender, EventArgs e)
        {
            _ordenDePreparacionModel.EliminarTodosLosProductos();
            ActualizarListViewAgregados();
            ActualizarListViewDisponibles();
        }
    }
}
