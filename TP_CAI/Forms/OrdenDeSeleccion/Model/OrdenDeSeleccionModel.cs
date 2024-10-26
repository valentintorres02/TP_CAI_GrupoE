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

namespace TP_CAI.Forms.OrdenDeSeleccion.Forms.Model
{

    internal class OrdenDeSeleccionModel
    {
        public List<OrdenPreparacion> OrdenesDePreparacionIniciales { get; private set; }
        public List<OrdenPreparacion> OrdenesDePreparacionFiltradas { get; private set; }
        public List<OrdenPreparacion> OrdenesDePreparacionAgregadas{ get; private set; }
        public List<Cliente> Clientes { get; private set; }

        public OrdenDeSeleccionModel() {
                 OrdenesDePreparacionIniciales = new List<OrdenPreparacion>
                    {
                        new OrdenPreparacion(019, "20-44444444-4", "GrupoE S.R.L", 35012345, PrioridadEnum.Baja, EstadoOrdenPreparacionEnum.Pendiente, DateTime.Now),
                        new OrdenPreparacion(025, "20-44444444-4", "C.A.I S.A", 35012345, PrioridadEnum.Media, EstadoOrdenPreparacionEnum.Pendiente, DateTime.Now),
                        new OrdenPreparacion(034, "20-44444444-4", "Grupo-Z S.A", 35012345, PrioridadEnum.Alta, EstadoOrdenPreparacionEnum.Pendiente, DateTime.Now),
                        new OrdenPreparacion(055, "20-44444444-4", "Molinos S.R.L", 35012345, PrioridadEnum.Alta, EstadoOrdenPreparacionEnum.Pendiente, DateTime.Now)
                    };

            OrdenesDePreparacionFiltradas = new List<OrdenPreparacion>(OrdenesDePreparacionIniciales);
            OrdenesDePreparacionAgregadas = new List<OrdenPreparacion>();
            Clientes = new List<Cliente>();
            foreach (var clienteEntidad in ClienteAlmacen.Clientes)
            {
                var clienteModelo = new Cliente();
                clienteModelo.Documento = clienteEntidad.CUIT;
                clienteModelo.Nombre = clienteEntidad.Nombre;
                Clientes.Add(clienteModelo);
            }

        }


       public string ValidarOrdenesSeleccionadas(int cantidadOrdenesSeleccionadas)
        {
            if(cantidadOrdenesSeleccionadas == 0)
            {
                return "Al menos una orden de preparacion debe ser agregada a la nueva orden de seleccion para que esta pueda ser creada.";
            }

            return null;
        }

       public OrdenSeleccion CrearOrden(List<int> idOrdenesPreparacion)
        {
            // Generar un ID único 
            int nuevoId = 1;

            // Crear una nueva instancia de OrdenPreparacion
            var nuevaOrden = new OrdenSeleccion(nuevoId, idOrdenesPreparacion);

            return nuevaOrden;
        }

        public void FiltrarOrdenes(PrioridadEnum? prioridad, string documentoCliente, DateTime? fechaEntrega)
        {
            // Iniciar la lista de órdenes filtradas
            var ordenesFiltradas = OrdenesDePreparacionIniciales.AsEnumerable();

            // Filtrar por prioridad si se proporciona
            if (prioridad.HasValue)
            {
                ordenesFiltradas = ordenesFiltradas.Where(o => o.Prioridad == prioridad.Value);
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
