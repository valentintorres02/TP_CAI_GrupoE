using System.Collections.Generic;
using System.Net;
using TP_CAI.Almacenes;

namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {

        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; }
        public List<Transportista> Transportistas { get; private set; }

        public DespachoModel()
        {
            OrdenesDePreparacion = new List<OrdenPreparacion>();

            CargarTransportistas();
        }

        public string ValidarTransportista(string dniTransportista)
        {
            if (dniTransportista == null || dniTransportista == "")
            {
                return "Por favor seleccione un transportista valido.";
            }

            return null;
        }

        public void CargarOrdenesPorTransportista(string dniTransportista)
        {
            OrdenesDePreparacion = [];
            var ordenesDeEntregaParaDespacho = OrdenEntregaAlmacen.ObtenerOrdenesParaDespacho();

            foreach (var ordenEntrega in ordenesDeEntregaParaDespacho)
            {
                foreach (var idOrdenPreparacion in ordenEntrega.IDsOrdenesPreparacion)
                {
                    var ordenPreparacion = OrdenPreparacionAlmacen.ObtenerOrdenPorId(idOrdenPreparacion);

                    if (ordenPreparacion.DNITransportista.ToString() == dniTransportista && ordenPreparacion.Estado != EstadoOrdenPreparacion.Despachada)
                    {
                        var ordenPreparacionParaDespacho = new OrdenPreparacion(ordenPreparacion.IDOrdenPreparacion, ordenPreparacion.DNITransportista.ToString(), ordenPreparacion.Estado, ordenEntrega.IDOrdenEntrega);
                        OrdenesDePreparacion.Add(ordenPreparacionParaDespacho);
                    }
                }
            }
        }

        public string MarcarComoListasParaDespacho()
        {
            if (OrdenesDePreparacion.Count == 0)
            {
                return "No hay ninguna orden para marcar como lista para despachar.";
            }


            if (OrdenesDePreparacion.FirstOrDefault(o => o.Estado == EstadoOrdenPreparacion.PendienteDeDespacho) == null)
            {
                return "No hay ninguna orden para marcar como lista para despachar.";
            }

            List<OrdenPreparacion> nuevasOrdenes = [];
            foreach (var orden in OrdenesDePreparacion)
            {
                var ordenPreparacion = OrdenPreparacionAlmacen.ObtenerOrdenPorId(orden.Id);
                ordenPreparacion.MarcarComoListaParaDespachar();
                var ordenEntrega = OrdenEntregaAlmacen.ObtenerOrdenPorId(orden.IdOrdenEntrega);
                ordenEntrega.MarcarComoListaParaDespachar();
                var ordenPreparacionParaDespacho = new OrdenPreparacion(ordenPreparacion.IDOrdenPreparacion, ordenPreparacion.DNITransportista.ToString(), ordenPreparacion.Estado, ordenEntrega.IDOrdenEntrega);
                nuevasOrdenes.Add(ordenPreparacionParaDespacho);
            }

            OrdenesDePreparacion = nuevasOrdenes;
            return null;
        }

        private void CargarTransportistas()
        {
            Transportistas = new List<Transportista>();

            var transportistasConOrdenesParaDespacho = OrdenPreparacionAlmacen.ObtenerTransportistasConOrdenesParaDespacho();
            foreach (var dniTransportista in transportistasConOrdenesParaDespacho)
            {
                Transportista transportista = new Transportista(dniTransportista.ToString());
                Transportistas.Add(transportista);
            }
        }

        private void ActualizarOrdenDeEntrega(int idOrdenEntrega)
        {
            bool marcarOrdenComoFinalizada = true;

            var ordenEntrega = OrdenEntregaAlmacen.ObtenerOrdenPorId(idOrdenEntrega);

            foreach(var idOrdenPreparacion in ordenEntrega.IDsOrdenesPreparacion)
            {
                var ordenPrep = OrdenPreparacionAlmacen.ObtenerOrdenPorId(idOrdenPreparacion);

                if(ordenPrep.Estado != EstadoOrdenPreparacion.Despachada)
                {
                    marcarOrdenComoFinalizada = false;
                }
            }

            if(marcarOrdenComoFinalizada)
            {
                ordenEntrega.MarcarComoFinalizada();
            }
        }

        public string MarcarComoDespachadas()
        {
            if(OrdenesDePreparacion.Count == 0)
            {
                return "No hay ninguna orden para marcar como despachada.";
            }

            var primeraOrden = OrdenPreparacionAlmacen.ObtenerOrdenPorId(OrdenesDePreparacion[0].Id);

            RemitoEntidad remito = new();

            remito.DNITransportista = primeraOrden.DNITransportista;
            remito.IDCliente = primeraOrden.IDCliente;
            remito.IDsOrdenesPreparacion = [];

            foreach (var orden in OrdenesDePreparacion)
            {
                var ordenPreparacion = OrdenPreparacionAlmacen.ObtenerOrdenPorId(orden.Id);
                ordenPreparacion.MarcarComoDespachada();
                remito.IDsOrdenesPreparacion.Add(ordenPreparacion.IDOrdenPreparacion);
                ActualizarOrdenDeEntrega(orden.IdOrdenEntrega);
            }

            RemitoAlmacen.Nuevo(remito);
            OrdenesDePreparacion = [];

            return null;
        }

    }
}
