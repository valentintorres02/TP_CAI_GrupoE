﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_CAI.Archivos.OrdenDePreparacion.Forms
{
    public partial class OrdenDePreparacionForm : Form
    {
        public OrdenDePreparacionForm()
        {
            InitializeComponent();
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
            if (int.TryParse(CantidadTextBox.Text, out int cantidad) && cantidad > 0)
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

            ListViewItem item1 = new ListViewItem(new[] { "1", "Remeras", "10" });
            ListViewItem item2 = new ListViewItem(new[] { "2", "Zapatillas", "20" });
            ListViewItem item3 = new ListViewItem(new[] { "3", "Pantalones", "30" });

            ProductosDisponiblesListView.Columns.Add("ID", 70); // Ancho de la columna 50
            ProductosDisponiblesListView.Columns.Add("Descripción", 170);
            ProductosDisponiblesListView.Columns.Add("Unidades disponibles", 100);

            ProductosAgregadosListView.Columns.Add("ID", 70); // Ancho de la columna 50
            ProductosAgregadosListView.Columns.Add("Descripción", 170);
            ProductosAgregadosListView.Columns.Add("Unidades agregadas", 100);

            ProductosDisponiblesListView.Items.Add(item1);
            ProductosDisponiblesListView.Items.Add(item2);
            ProductosDisponiblesListView.Items.Add(item3);
        }

        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en la lista original (listView1)
            if (ProductosDisponiblesListView.SelectedItems.Count > 0 && int.TryParse(CantidadTextBox.Text, out int cantidad) && cantidad > 0)
            {
                // Obtener el elemento seleccionado
                ListViewItem itemSeleccionado = ProductosDisponiblesListView.SelectedItems[0];

                // Obtener los valores de las columnas (ID y Descripción) del item seleccionado
                string id = itemSeleccionado.SubItems[0].Text;  // Columna ID
                string descripcion = itemSeleccionado.SubItems[1].Text;  // Columna Descripción

                // Crear un nuevo ListViewItem con los valores y la cantidad especificada
                ListViewItem nuevoItem = new ListViewItem(new[] { id, descripcion, cantidad.ToString() });

                // Agregar el nuevo item a la lista de productos agregados (ProductosAgregadosListView)
                ProductosAgregadosListView.Items.Add(nuevoItem);

                // Eliminar el item de la lista original (listView1)
                ProductosDisponiblesListView.Items.Remove(itemSeleccionado);

                // Limpiar el campo de cantidad
                CantidadTextBox.Clear();

                // Deshabilitar el botón nuevamente
                AgregarProductoButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto y una cantidad válida.");
            }

            InfoOrdenGroup.Enabled = true;
            CrearOrdenButton.Enabled = true;
        }

        private void EliminarProductoButton_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en la lista de productos agregados
            if (ProductosAgregadosListView.SelectedItems.Count > 0)
            {
                // Obtener el elemento seleccionado
                ListViewItem itemSeleccionado = ProductosAgregadosListView.SelectedItems[0];

                // Obtener los valores de las columnas (ID y Descripción) del item seleccionado
                string id = itemSeleccionado.SubItems[0].Text;  // Columna ID
                string descripcion = itemSeleccionado.SubItems[1].Text;  // Columna Descripción
                string cantidad = "10";

                // Crear un nuevo ListViewItem para la lista original
                ListViewItem nuevoItem = new ListViewItem(new[] { id, descripcion, cantidad });

                // Agregar el item de vuelta a la lista original (listView1)
                ProductosDisponiblesListView.Items.Add(nuevoItem);

                // Eliminar el item de la lista de productos agregados (ProductosAgregadosListView)
                ProductosAgregadosListView.Items.Remove(itemSeleccionado);

                // Deshabilitar el botón de eliminar si ya no hay más elementos seleccionados
                EliminarProductoButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.");
            }
        }

        private void CrearOrdenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orden Creada Satisfactoriamente\". ID de Orden: 004. Fecha de emisión: 06/10/2024 14:50hs");
        }
    }
}