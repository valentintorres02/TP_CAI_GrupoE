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

            // Registrar los eventos SelectedIndexChanged de los ComboBox
            ClienteCombobox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            DepositoCombobox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            // Registrar el evento SelectedIndexChanged del ListView
            ProductosDisponiblesListView.SelectedIndexChanged += new EventHandler(ProductosDisponiblesListView_SelectedIndexChanged);

            // Registrar el evento SelectedIndexChanged del ListView
            ProductosAgregadosListView.SelectedIndexChanged += new EventHandler(ProductosAgregadosListView_SelectedIndexChanged);

            // Registrar el evento TextChanged del CantidadTextBox
            CantidadTextBox.TextChanged += new EventHandler(CantidadTextBox_TextChanged);

            ProductosDisponiblesListView.FullRowSelect = true;
            ProductosAgregadosListView.FullRowSelect = true;

        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si ambos ComboBox tienen un valor seleccionado
            if (ClienteCombobox.SelectedItem != null && DepositoCombobox.SelectedItem != null)
            {
                ContinuarButton.Enabled = true; // Habilitar el botón
            }
            else
            {
                ContinuarButton.Enabled = false; // Deshabilitar el botón
            }
        }

        private void ProductosDisponiblesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en el ListView
            if (ProductosDisponiblesListView.SelectedItems.Count > 0)
            {
                CantidadTextBox.Enabled = true; // Habilitar el TextBox
            }
            else
            {
                EliminarProductoButton.Enabled = false; // Deshabilitar el TextBox
            }
        }

        private void ProductosAgregadosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en el ListView
            if (ProductosAgregadosListView.SelectedItems.Count > 0)
            {
                EliminarProductoButton.Enabled = true; // Habilitar el TextBox
            }
            else
            {
                CantidadTextBox.Enabled = false; // Deshabilitar el TextBox
            }
        }

        private void CantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el valor ingresado es un número válido
            if (int.TryParse(CantidadTextBox.Text, out int cantidad))
            {
                AgregarProductoButton.Enabled = true; // Habilitar el botón si es un número positivo
            }
            else
            {
                AgregarProductoButton.Enabled = false; // Deshabilitar el botón si el valor no es válido
            }
        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {
                ProductosGroup.Enabled = true;

                // Limpiar las columnas antes de agregar nuevas
                ProductosDisponiblesListView.Columns.Clear();
                ProductosAgregadosListView.Columns.Clear();

                // Agregar columnas a la lista de productos disponibles
                ProductosDisponiblesListView.Columns.Add("ID", 70); // Ancho de la columna 70
                ProductosDisponiblesListView.Columns.Add("Descripción", 170);
                ProductosDisponiblesListView.Columns.Add("Unidades disponibles", 100);

                // Agregar columnas a la lista de productos agregados
                ProductosAgregadosListView.Columns.Add("ID", 70); // Ancho de la columna 70
                ProductosAgregadosListView.Columns.Add("Descripción", 170);
                ProductosAgregadosListView.Columns.Add("Unidades agregadas", 100);

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

        private void ActualizarListViewDisponibles()
        {
            ProductosDisponiblesListView.Items.Clear();
            foreach (var producto in _ordenDePreparacionModel.ProductosDisponibles)
            {
                ListViewItem item = new ListViewItem(new[] { producto.Id, producto.Descripcion, producto.Cantidad.ToString() });
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

            // Habilitar los campos que estaban deshabilitados
            CantidadTextBox.Enabled = true;
            EliminarProductoButton.Enabled = true; // Habilitar el botón de eliminar
            InfoOrdenGroup.Enabled = true; // Habilitar el grupo de información de la orden

            // Deshabilitar el botón nuevamente
            AgregarProductoButton.Enabled = false;

            // Habilitar el botón de crear orden
            CrearOrdenButton.Enabled = true;
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
                bool isPrioridadSeleccionada = PrioridadComboBox.SelectedIndex != -1; // -1 indica que no hay selección

                // Validar prioridad
                string errorPrioridad = _ordenDePreparacionModel.ValidarPrioridad(isPrioridadSeleccionada);

                if (errorPrioridad != null)
                {
                    MessageBox.Show(errorPrioridad);
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

                // Si todo es válido, continuar con la creación de la orden
                string mensaje = _ordenDePreparacionModel.CrearOrden(documentoCliente, nombreCliente, dniTransportista, prioridad);
                MessageBox.Show(mensaje);
            }
            catch (Exception ex)
            {
                // Manejar errores inesperados
                MessageBox.Show("La Orden de Preparación no pudo ser creada correctamente. Por favor intente de nuevo o contacte al área de sistemas.\n" + ex.Message);
            }
            finally
            {
                // Resetear el formulario después de la creación
                ResetearFormulario();
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

            ContinuarButton.Enabled = false;

             

            // deshabilitar controles 
            CantidadTextBox.Enabled = false;
            EliminarProductoButton.Enabled = false; // Deshabilitar el botón de eliminar
            InfoOrdenGroup.Enabled = false; // Deshabilitar el grupo de información de la orden
            AgregarProductoButton.Enabled = false; // Habilitar el botón de agregar
            CrearOrdenButton.Enabled = false; // Habilitar el botón de crear orden
            ProductosGroup.Enabled = false;

            InfoOrdenGroup.Enabled = false;

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
