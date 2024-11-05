using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using TP_CAI.Forms.GestionOrdenSeleccion.Model;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;
using TP_CAI.Forms.OrdenDePreparacion.Model;
using TP_CAI.Almacenes;
using System.ComponentModel;

namespace TP_CAI.Forms.OrdenDeSeleccion.Forms.Model
{

    internal class OrdenDeSeleccionModel
    {
        public List<OrdenPreparacion> OrdenesDePreparacionIniciales { get; private set; }
        public List<OrdenPreparacion> OrdenesDePreparacionFiltradas { get; private set; }
        public List<OrdenPreparacion> OrdenesDePreparacionAgregadas{ get; private set; }
        public List<Cliente> Clientes { get; private set; }

        public OrdenDeSeleccionModel() {
            OrdenesDePreparacionIniciales = new List<OrdenPreparacion>();
            OrdenesDePreparacionFiltradas = new List<OrdenPreparacion>();
            OrdenesDePreparacionAgregadas = new List<OrdenPreparacion>();
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
            foreach (var ordenPreparacionEntidad in OrdenPreparacionAlmacen.ObtenerOrdenesPendientesDeSeleccion())
            {
                    var clienteId = ordenPreparacionEntidad.IDCliente;

                    var cliente = ClienteAlmacen.ObtenerClientePorId(clienteId);

                    if (cliente == null)
                    {
                        continue;
                    }

                    var ordenPreparacionModelo = new OrdenPreparacion(
                            ordenPreparacionEntidad.IDOrdenPreparacion, cliente.CUITCliente, cliente.Nombre, ordenPreparacionEntidad.DNITransportista,
                            ordenPreparacionEntidad.Prioridad,
                            ordenPreparacionEntidad.Estado,
                            ordenPreparacionEntidad.FechaEntrega);

                    OrdenesDePreparacionIniciales.Add(ordenPreparacionModelo);
            }

            // Actualiza las listas derivadas
            OrdenesDePreparacionFiltradas = new List<OrdenPreparacion>(OrdenesDePreparacionIniciales);
            OrdenesDePreparacionAgregadas.Clear();
        }


        public string ValidarOrdenesSeleccionadas(int cantidadOrdenesSeleccionadas)
        {
            if(cantidadOrdenesSeleccionadas == 0)
            {
                return "Al menos una orden de preparacion debe ser agregada a la nueva orden de seleccion para que esta pueda ser creada.";
            }

            return null;
        }

        public string CrearOrden(List<int> idOrdenesPreparacion)
        {
            var nuevaOrden = new OrdenSeleccionEntidad();

            foreach (int idOrden in idOrdenesPreparacion)
            {
                var ordenPreparacion = OrdenPreparacionAlmacen.ObtenerOrdenPorId(idOrden);

                if (ordenPreparacion != null)
                {
                    nuevaOrden.IDsOrdenesPreparacion.Add(ordenPreparacion.IDOrdenPreparacion);
                    ordenPreparacion.MarcarComoEnPreparacion();
                }
            }

            string error = OrdenSeleccionAlmacen.Nueva(nuevaOrden);

            // Refresca las listas para que las órdenes en preparación no aparezcan
            ReiniciarOrdenes();
            ResetearFiltros();

            return $"Orden Creada Satisfactoriamente. ID de Orden: {nuevaOrden.IDOrdenSeleccion}.";
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
            OrdenesDePreparacionAgregadas = new List<OrdenPreparacion>();
        }

        public string AgregarOrdenDePreparacionAOrdenDeSeleccion(int idOrdenPreparacion)
        {
            // Buscar la orden de preparación en la lista inicial
            var ordenPreparacion = OrdenesDePreparacionFiltradas.FirstOrDefault(o => o.Id == idOrdenPreparacion);

            // Verificar si la orden fue encontrada
            if (ordenPreparacion != null)
            {
                // Agregar la orden a la lista de órdenes agregadas
                OrdenesDePreparacionAgregadas.Add(ordenPreparacion);

                // Eliminar la orden de la lista de órdenes filtradas (opcional)
                OrdenesDePreparacionFiltradas.Remove(ordenPreparacion);
                return null;
            }
            else
            {
                return $"Hubo un error al agregar la orden ID {idOrdenPreparacion}.";
            }
        }

        public string EliminarOrdenDePreparacionDeOrdenDeSeleccion(int idOrdenPreparacion)
        {
            // Buscar la orden de preparación en la lista inicial
            var ordenPreparacion = OrdenesDePreparacionAgregadas.FirstOrDefault(o => o.Id == idOrdenPreparacion);

            // Verificar si la orden fue encontrada
            if (ordenPreparacion != null)
            {
                OrdenesDePreparacionFiltradas.Add(ordenPreparacion);

                OrdenesDePreparacionAgregadas.Remove(ordenPreparacion);
                return null;
            }
            else
            {
                return $"Hubo un error al eliminar la orden ID {idOrdenPreparacion}.";
            }
        }
    }
}
