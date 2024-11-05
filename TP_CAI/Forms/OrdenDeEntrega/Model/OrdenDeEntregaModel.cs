using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TP_CAI.Almacenes;
using TP_CAI.Forms.Empaquetado.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.OrdenDeEntrega.Model
{

    internal partial class OrdenDeEntregaModel
    {

        public List<OrdenPreparacion> OrdenesDePreparacion{ get; private set; }

        public OrdenDeEntregaModel()
        {
            OrdenesDePreparacion = new List<OrdenPreparacion>();

            var ordenesPreparacionPreparadas = OrdenPreparacionAlmacen.ObtenerOrdenesPreparadas();

            foreach(var ordenPreparacionPreparada in ordenesPreparacionPreparadas)
            {
                var cliente = ClienteAlmacen.ObtenerClientePorId(ordenPreparacionPreparada.IDCliente);
                OrdenPreparacion ordenPreparacion = new OrdenPreparacion(
                    ordenPreparacionPreparada.IDOrdenPreparacion, 
                    cliente.CUITCliente, 
                    cliente.Nombre,
                    ordenPreparacionPreparada.DNITransportista,
                    ordenPreparacionPreparada.Prioridad,
                    ordenPreparacionPreparada.Estado,
                    ordenPreparacionPreparada.FechaEntrega
                    );

                OrdenesDePreparacion.Add(ordenPreparacion);
            }
        }

        public string ValidarOrdenEntrega()
        {
            if (OrdenesDePreparacion.Count == 0)
            {
                return "Debe haber al menos una orden de preparacion para crear una orden de entrega";
            }

            return null;
        }

        public string CrearOrdenEntrega()
        {

            var ordenEntregaACrear = new OrdenEntregaEntidad();

            ordenEntregaACrear.Estado = EstadoOrdenEntrega.PendienteDeDespacho;
            ordenEntregaACrear.IDsOrdenesPreparacion = [];

            foreach(var ordenPreparacion in OrdenesDePreparacion)
            {
                OrdenPreparacionEntidad ordenPreparacionEntidad = OrdenPreparacionAlmacen.ObtenerOrdenPorId(ordenPreparacion.Id);
                ordenPreparacionEntidad.MarcarComoPendienteDeDespacho();
                ordenEntregaACrear.IDsOrdenesPreparacion.Add(ordenPreparacion.Id);
            }

            OrdenesDePreparacion = new List<OrdenPreparacion>();

            var ordenEntrega = OrdenEntregaAlmacen.Nueva(ordenEntregaACrear);

            return null;
        }
    }
}
