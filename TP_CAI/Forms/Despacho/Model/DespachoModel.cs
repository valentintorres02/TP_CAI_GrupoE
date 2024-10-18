using System.Collections.Generic;
using System.Net;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {

        public List<OrdenEntrega> OrdenesDeEntrega { get; private set; }
        public List<Transportista> Transportistas { get; private set; }

        public DespachoModel()
        {
            OrdenesDeEntrega = new List<OrdenEntrega>
            {
               new OrdenEntrega(019, "20456765"),
               new OrdenEntrega(055, "45324567"),
               new OrdenEntrega(031, "34567544"),
               new OrdenEntrega(042, "22345678"),
               new OrdenEntrega(011, "22345678"),
            };

            Transportistas = new List<Transportista>
            {
               new Transportista("20456765"),
               new Transportista("45324567"),
               new Transportista("34567544"),
               new Transportista("22345678"),
            };
        }

        public List<OrdenEntrega> ObtenerOrdenesPorTransportista(string dniTransportista)
        {
            return OrdenesDeEntrega.Where(orden => orden.DocumentoTransportista == dniTransportista).ToList();
        }

        public string ValidarTransportista(string dniTransportista)
        {
            if (dniTransportista == null || dniTransportista == "")
            {
                return "Por favor seleccione un transportista valido.";
            }

            return null;
        }

    }
}
