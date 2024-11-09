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

            Transportistas = new List<Transportista>();

            var transportistasConOrdenesParaDespacho = OrdenPreparacionAlmacen.ObtenerTransportistasConOrdenesParaDespacho();
            foreach(var dniTransportista in transportistasConOrdenesParaDespacho)
            {
                Transportista transportista = new Transportista(dniTransportista.ToString());
                Transportistas.Add(transportista);
            }
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

                    if(ordenPreparacion.DNITransportista.ToString() ==  dniTransportista)
                    {
                        var ordenPreparacionParaDespacho = new OrdenPreparacion(ordenPreparacion.IDOrdenPreparacion, ordenPreparacion.DNITransportista.ToString(), ordenPreparacion.Estado, ordenEntrega.IDOrdenEntrega);
                        OrdenesDePreparacion.Add(ordenPreparacionParaDespacho);
                    }
                }
            }
        }

        public string MarcarComoListasParaDespacho()
        {

            if (OrdenesDePreparacion.FirstOrDefault(o => o.Estado == EstadoOrdenPreparacion.ListaParaDespachar) != null)
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

        public void MarcarComoDespachadas()
        {
            foreach (var orden in OrdenesDePreparacion)
            {
                var ordenPreparacion = OrdenPreparacionAlmacen.ObtenerOrdenPorId(orden.Id);
                ordenPreparacion.MarcarComoDespachada();
                var ordenEntrega = OrdenEntregaAlmacen.ObtenerOrdenPorId(orden.IdOrdenEntrega);
                ordenEntrega.MarcarComoFinalizada();
            }

            OrdenesDePreparacion = [];
        }

    }
}
