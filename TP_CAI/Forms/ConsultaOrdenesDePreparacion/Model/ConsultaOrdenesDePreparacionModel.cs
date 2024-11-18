using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;
using TP_CAI.Almacenes;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.ConsultaOrdenesDePreparacion.Model
{
    internal class ConsultaOrdenesDePreparacionModel
    {
        public List<OrdenPreparacion> OrdenesDePreparacionIniciales { get; private set; }
        public List<OrdenPreparacion> OrdenesDePreparacionFiltradas { get; private set; }
        public List<Cliente> Clientes { get; private set; }

        public ConsultaOrdenesDePreparacionModel()
        {
            OrdenesDePreparacionIniciales = new List<OrdenPreparacion>();
            OrdenesDePreparacionFiltradas = new List<OrdenPreparacion>();
            Clientes = new List<Cliente>();
            foreach (var clienteEntidad in ClienteAlmacen.Clientes)
            {
                var clienteModelo = new Cliente();
                clienteModelo.Documento = clienteEntidad.CUITCliente;
                clienteModelo.Nombre = clienteEntidad.Nombre;
                Clientes.Add(clienteModelo);
            }

            ReiniciarOrdenes();
        }

        private void ReiniciarOrdenes()
        {
            OrdenesDePreparacionIniciales.Clear();

            // Agrega solo las órdenes pendientes a la lista inicial
            foreach (var ordenPreparacionEntidad in OrdenPreparacionAlmacen.ObtenerTodasLasOrdenes())
            {
                var clienteId = ordenPreparacionEntidad.IDCliente;

                var cliente = ClienteAlmacen.ObtenerClientePorId(clienteId);

                if (cliente == null)
                {
                    continue;
                }

                var ordenPreparacionModelo = new OrdenPreparacion(
                        ordenPreparacionEntidad.IDOrdenPreparacion, cliente.CUITCliente, ordenPreparacionEntidad.IDDeposito, ordenPreparacionEntidad.DNITransportista,
                        ordenPreparacionEntidad.Prioridad,
                        ordenPreparacionEntidad.Estado,
                        ordenPreparacionEntidad.FechaEntrega);

                OrdenesDePreparacionIniciales.Add(ordenPreparacionModelo);
            }

            // Actualiza las listas derivadas
            OrdenesDePreparacionFiltradas = new List<OrdenPreparacion>(OrdenesDePreparacionIniciales);
        }

        public void FiltrarOrdenes(PrioridadEnum? prioridad, string documentoCliente, DateTime? fechaEntrega)
        {
            // Iniciar la lista de órdenes filtradas
            var ordenesFiltradas = OrdenesDePreparacionIniciales.AsEnumerable();

            // Filtrar por prioridad si se proporciona
            if (prioridad.HasValue)
            {
                ordenesFiltradas = ordenesFiltradas.Where(o => o.Prioridad == (PrioridadOrdenPreparacion)prioridad.Value);
            }

            // Filtrar por documento del cliente si se proporciona
            if (!string.IsNullOrWhiteSpace(documentoCliente))
            {
                ordenesFiltradas = ordenesFiltradas.Where(o => o.DocumentoCliente.Equals(documentoCliente, StringComparison.OrdinalIgnoreCase));
            }

            // Filtrar por fecha de entrega si se proporciona
            if (fechaEntrega.HasValue)
            {
                ordenesFiltradas = ordenesFiltradas.Where(o => o.FechaEntrega.Date == fechaEntrega.Value.Date);
            }

            // Convertir a lista y asignar a OrdenesDePreparacionFiltradas
            OrdenesDePreparacionFiltradas = ordenesFiltradas.ToList();
        }

        public void ResetearFiltros()
        {
            OrdenesDePreparacionFiltradas = new List<OrdenPreparacion>(OrdenesDePreparacionIniciales);
        }
    }
}
