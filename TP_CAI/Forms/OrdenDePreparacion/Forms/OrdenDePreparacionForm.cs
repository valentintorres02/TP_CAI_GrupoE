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
            // Desactivar el botón al cargar el formulario
            ContinuarButton.Enabled = false;

            // Desactivar el contenedor de Productos
            ProductosGroup.Enabled = false;

            InfoOrdenGroup.Enabled = false;

            // Registrar los eventos SelectedIndexChanged de los ComboBox
            comboBox1.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            comboBox2.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            // Registrar el evento SelectedIndexChanged del ListView
            ProductosDisponiblesListView.SelectedIndexChanged += new EventHandler(ProductosDisponiblesListView_SelectedIndexChanged);

            // Registrar el evento SelectedIndexChanged del ListView
            ProductosAgregadosListView.SelectedIndexChanged += new EventHandler(ProductosAgregadosListView_SelectedIndexChanged);

            // Registrar el evento TextChanged del CantidadTextBox
            CantidadTextBox.TextChanged += new EventHandler(CantidadTextBox_TextChanged);

            ProductosDisponiblesListView.FullRowSelect = true;
            ProductosAgregadosListView.FullRowSelect = true;

            CargarProductosDisponibles();



        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si ambos ComboBox tienen un valor seleccionado
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
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
            if(comboBox1.SelectedIndex != 0)
            {
                MessageBox.Show("No hay productos en existencia para el cliente C.A.I S.A en el depósito ID 7. Por favor intente con otro cliente u otro depósito.");
            } else
            {

            ProductosGroup.Enabled = true;

            ProductosDisponiblesListView.Columns.Add("ID", 70); // Ancho de la columna 50
            ProductosDisponiblesListView.Columns.Add("Descripción", 170);
            ProductosDisponiblesListView.Columns.Add("Unidades disponibles", 100);

            ProductosAgregadosListView.Columns.Add("ID", 70); // Ancho de la columna 50
            ProductosAgregadosListView.Columns.Add("Descripción", 170);
            ProductosAgregadosListView.Columns.Add("Unidades agregadas", 100);


                ListViewItem[] items = _ordenDePreparacionModel.CargarElementos();


                foreach (var item in items)
                {
                    ProductosDisponiblesListView.Items.Add(item);
                }
            }
        }

        private void CargarProductosDisponibles()
        {
            _ordenDePreparacionModel.CargarElementosDisponibles();

            ActualizarListViewDisponibles();
        }

        private void ActualizarListViewDisponibles()
        {
            ProductosDisponiblesListView.Items.Clear();
            foreach (var producto in _ordenDePreparacionModel.ProductosDisponibles)
            {
                ListViewItem item = new ListViewItem(new[] { producto.Id, producto.Descripcion, producto.UnidadesDisponibles.ToString() });
                ProductosDisponiblesListView.Items.Add(item);
            }
        }

        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            int.TryParse(CantidadTextBox.Text, out int cantidad1);
            ListViewItem itemSeleccionado = ProductosDisponiblesListView.SelectedItems[0];

            // Obtener los valores de las columnas (ID y Descripción) del item seleccionado
            string id = itemSeleccionado.SubItems[0].Text;  // Columna ID
            string descripcion = itemSeleccionado.SubItems[1].Text;  // Columna Descripción
            string cantidadItem = itemSeleccionado.SubItems[2].Text;  // Columna Descripción

            int.TryParse(cantidadItem, out int cantidad2);

            string errorCantidad = _ordenDePreparacionModel.ValidarCantidades(cantidad1, cantidad2, descripcion, cantidadItem);

            if(errorCantidad  != null)
            {
                MessageBox.Show(errorCantidad);
                return;
            }


            // Verificar si hay un elemento seleccionado en la lista original (listView1)
            if (ProductosDisponiblesListView.SelectedItems.Count > 0 && int.TryParse(CantidadTextBox.Text, out int cantidad) && cantidad > 0)
            {
                // Crear un nuevo ListViewItem con los valores y la cantidad especificada
                ListViewItem nuevoItem = new ListViewItem(new[] { id, descripcion, cantidad.ToString() });

                // Agregar el nuevo item a la lista de productos agregados (ProductosAgregadosListView)
                ProductosAgregadosListView.Items.Add(nuevoItem);

                // Eliminar el item de la lista original (listView1)
                ProductosDisponiblesListView.Items.Remove(itemSeleccionado);

                // Limpiar el campo de cantidad
                CantidadTextBox.Clear();

                // Habilitar los campos que estaban deshabilitados
                CantidadTextBox.Enabled = true;
                EliminarProductoButton.Enabled = true; // Habilitar el botón de eliminar
                InfoOrdenGroup.Enabled = true; // Habilitar el grupo de información de la orden

                // Deshabilitar el botón nuevamente
                AgregarProductoButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto y una cantidad válida.");
            }

            // Habilitar el botón de crear orden
            CrearOrdenButton.Enabled = true;
        }

        private void ActualizarListViewAgregados()
        {
            ProductosAgregadosListView.Items.Clear();
            foreach (var producto in _ordenDePreparacionModel.ProductosAgregados)
            {
                ListViewItem item = new ListViewItem(new[] { producto.Id, producto.Descripcion, producto.UnidadesDisponibles.ToString() });
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
            bool isPrioridadSeleccionada = PrioridadComboBox.SelectedIndex != -1; // -1 indica que no hay selección

            // validar prioridad
            string errorPrioridad = _ordenDePreparacionModel.ValidarPrioridad(isPrioridadSeleccionada);


            if (errorPrioridad != null)
            {
                MessageBox.Show(errorPrioridad);
                return;
            }

            // Validar el formato del DNI
            string dniText = DniTransportistaTextBox.Text;
            string errorDni = _ordenDePreparacionModel.ValidarDniTransportista(dniText);

            if(errorDni != null)
            {
                MessageBox.Show(errorDni);
                return;
            }

            // Si todo es válido, continuar con la creación de la orden
            MessageBox.Show("Orden Creada Satisfactoriamente. ID de Orden: 004. Fecha de emisión: 06/10/2024 14:50hs");
            ResetearFormulario();
        }

        private void ResetearFormulario()
        {
            // Limpiar campos de texto
            DniTransportistaTextBox.Clear();
            CantidadTextBox.Clear();

            // Restablecer comboBox
            PrioridadComboBox.SelectedIndex = -1; // Ninguna selección

            // Limpiar ListView
            ProductosAgregadosListView.Items.Clear();
            ProductosDisponiblesListView.Items.Clear();

            ContinuarButton.Enabled = false;

             

            // Habilitar/deshabilitar controles según sea necesario
            CantidadTextBox.Enabled = true;
            EliminarProductoButton.Enabled = false; // Deshabilitar el botón de eliminar
            InfoOrdenGroup.Enabled = false; // Deshabilitar el grupo de información de la orden
            AgregarProductoButton.Enabled = true; // Habilitar el botón de agregar
            CrearOrdenButton.Enabled = true; // Habilitar el botón de crear orden

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
