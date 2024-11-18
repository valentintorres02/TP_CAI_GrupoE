using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI.Forms.ConsultaStock.Model;
using TP_CAI.Forms.OrdenDePreparacion.Model;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;

namespace TP_CAI.Forms.ConsultaStock.Forms
{
    public partial class ConsultaStockForm : Form
    {
        private ConsultaStockModel _consultaStockModel;
        public ConsultaStockForm()
        {
            InitializeComponent();
            _consultaStockModel = new ConsultaStockModel();
        }

        private void CargarClientesCombobox()
        {
            List<Cliente> clientes = _consultaStockModel.Clientes;

            ClienteCombobox.DataSource = clientes;
            ClienteCombobox.DisplayMember = "DisplayText"; // Texto visible
            ClienteCombobox.ValueMember = "Documento";       // Valor asociado

            ClienteCombobox.SelectedIndex = -1; // arranca sin ningun valor
        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {
            string documentoClienteSeleccionado = "";


            if (ClienteCombobox.SelectedValue != null)
            {
                documentoClienteSeleccionado = ClienteCombobox.SelectedValue.ToString();
            }

            string errorDocumentoClienteSeleccionado = _consultaStockModel.ValidarCliente(documentoClienteSeleccionado);

            if (errorDocumentoClienteSeleccionado != null)
            {
                MessageBox.Show(errorDocumentoClienteSeleccionado);
                return;
            }

            _consultaStockModel.ClienteSeleccionado = documentoClienteSeleccionado;

            ProductosGroup.Enabled = true;

            ProductosDisponiblesListView.Items.Clear();

            if (_consultaStockModel.StockProductos.Count == 0)
            {
                MessageBox.Show("No hay productos en existencia para el cliente " + documentoClienteSeleccionado + ". Por favor intente con otro cliente.");
                return;
            }

            foreach (var producto in _consultaStockModel.StockProductos)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                producto.Id.ToString(),
                producto.Descripcion,
                producto.Cantidad.ToString(),
                producto.Deposito,
                producto.Ubicacion
            });

                ProductosDisponiblesListView.Items.Add(item);
            }
        }

        private void ConsultaStockForm_Load(object sender, EventArgs e)
        {
            CargarClientesCombobox();
        }
    }
}
