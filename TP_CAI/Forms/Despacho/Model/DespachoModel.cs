using System.Collections.Generic;
using System.Net;

namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {

        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; }
        public List<Transportista> Transportistas { get; private set; }

        public DespachoModel()
        {
            OrdenesDePreparacion = new List<OrdenPreparacion>
            {
               new OrdenPreparacion(019, "20456765", 11),
               new OrdenPreparacion(055, "45324567", 11),
               new OrdenPreparacion(031, "34567544", 15),
               new OrdenPreparacion(042, "22345678", 30),
               new OrdenPreparacion(011, "22345678", 4),
            };

            Transportistas = new List<Transportista>
            {
               new Transportista("20456765"),
               new Transportista("45324567"),
               new Transportista("34567544"),
               new Transportista("22345678"),
            };
        }

        public List<OrdenPreparacion> ObtenerOrdenesPorTransportista(string dniTransportista)
        {
            return OrdenesDePreparacion.Where(orden => orden.DocumentoTransportista == dniTransportista).ToList();
        }

        public string ValidarTransportista(string dniTransportista)
        {
            if (dniTransportista == null || dniTransportista == "")
            {
                return "Por favor seleccione un transportista valido.";
            }

            return null;
        }

        public void MarcarComoListasParaDespacho(string dniTransportista)
        {
            List<OrdenPreparacion> ordenesPreparacion = ObtenerOrdenesPorTransportista(dniTransportista);

            foreach (var orden in ordenesPreparacion)
            {
                orden.Estado = EstadoOrdenDePreparacionEnum.ListaParaDespacho;
            }
        }

    }
}
