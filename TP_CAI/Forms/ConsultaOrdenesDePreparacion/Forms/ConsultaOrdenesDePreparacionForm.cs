using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;
using TP_CAI.Archivos.PantallaPrincipal.Forms;
using TP_CAI.Forms.ConsultaOrdenesDePreparacion.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;
using ConsultaOrdenesDePreparacionModel = TP_CAI.Forms.ConsultaOrdenesDePreparacion.Model.ConsultaOrdenesDePreparacionModel;
using OrdenPreparacion = TP_CAI.Forms.ConsultaOrdenesDePreparacion.Model.OrdenPreparacion;
using TP_CAI.Almacenes;

namespace TP_CAI.Forms.ConsultaOrdenesDePreparacion.Forms
{
    public partial class ConsultaOrdenesDePreparacionForm : Form
    {
        private ConsultaOrdenesDePreparacionModel _consultaOrdenesDePreparacionModel;

        public ConsultaOrdenesDePreparacionForm()
        {
            InitializeComponent();
            _consultaOrdenesDePreparacionModel = new ConsultaOrdenesDePreparacionModel();
        }

        private void ConsultaOrdenesDePreparacionForm_Load_1(object sender, EventArgs e)
        {
            OrdenesPreparacionPendientesListView.FullRowSelect = true;
            FechaEntregaDatePicker.Checked = false;

            CargarPrioridadesCombobox();
            CargarClientesCombobox();

            ActualizarOrdenesFiltradas();
        }

        private static string ConvertirEstadoEnumAString(EstadoOrdenPreparacion estado)
        {
            return estado switch
            {
                EstadoOrdenPreparacion.EnPreparacion => "En Preparacion",
                EstadoOrdenPreparacion.Preparada => "Preparada",
                EstadoOrdenPreparacion.ListaParaDespachar => "Lista para Despachar",
                EstadoOrdenPreparacion.Despachada => "Despachada",
                EstadoOrdenPreparacion.PendienteDeEmpaquetado => "Pendiente de Empaquetado",
                EstadoOrdenPreparacion.PendienteDeDespacho => "Pendiente de Despacho",
                EstadoOrdenPreparacion.PendienteDeSeleccion => "Pendiente de Seleccion",
                _ => estado.ToString() // Devuelve el nombre del enum por defecto
            };
        }

        private void ActualizarOrdenesFiltradas()
        {
            OrdenesPreparacionPendientesListView.Items.Clear();

            List<OrdenPreparacion> ordenes = _consultaOrdenesDePreparacionModel.OrdenesDePreparacionFiltradas;

            foreach (var orden in ordenes)
            {
                DepositoEntidad deposito = DepositosAlmacen.ObtenerDepositoPorId(orden.IDDeposito);
                Deposito depositoModel = new();
                depositoModel.Direccion = deposito.Direccion;
                depositoModel.Id = deposito.IDDeposito;
                // Crear un nuevo ListViewItem con todos los elementos convertidos a string
                ListViewItem item = new ListViewItem(new[]
                {
                    orden.Id.ToString(),
                    orden.Prioridad.ToString(),
                    orden.DocumentoCliente,
                    orden.FechaEntrega.ToString("d"),
                    depositoModel.DisplayText,
                    ConvertirEstadoEnumAString(orden.Estado),
                    orden.FechaEmision.ToString("d"),
                    orden.DNITransportista.ToString(),
                });

                OrdenesPreparacionPendientesListView.Items.Add(item);
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
            List<Cliente> clientes = _consultaOrdenesDePreparacionModel.Clientes;

            ClienteCombobox.DataSource = clientes;
            ClienteCombobox.DisplayMember = "DisplayText"; // Texto visible
            ClienteCombobox.ValueMember = "Documento";       // Valor asociado

            ClienteCombobox.SelectedIndex = -1; // arranca sin ningun valor
        }

        private void ResetearFormulario()
        {
            _consultaOrdenesDePreparacionModel.ResetearFiltros();
            ClienteCombobox.SelectedIndex = -1;
            PrioridadCombobox.SelectedIndex = -1;
            ActualizarOrdenesFiltradas();

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
        private void ConsultaOrdenesDePreparacionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VolverAlMenu();

        }

        private void BuscarButton_Click(object sender, EventArgs e)
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

            DateTime? fechaEntrega = null;
            if (FechaEntregaDatePicker.Value != null && FechaEntregaDatePicker.Checked)
            {
                fechaEntrega = FechaEntregaDatePicker.Value.Date;
            }

            // Filtrar las órdenes en el modelo
            _consultaOrdenesDePreparacionModel.FiltrarOrdenes(prioridadSeleccionada, documentoCliente, fechaEntrega);

            // Actualizar la lista de órdenes mostradas
            ActualizarOrdenesFiltradas();
        }

        private void LimpiarFiltroButton_Click_1(object sender, EventArgs e)
        {
            PrioridadCombobox.SelectedIndex = -1;
            ClienteCombobox.SelectedIndex = -1;

            _consultaOrdenesDePreparacionModel.ResetearFiltros();
            ActualizarOrdenesFiltradas();
        }

        private void VolverButton_Click_1(object sender, EventArgs e)
        {
            VolverAlMenu();
            return;
        }
    }
}
