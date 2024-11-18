using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI.Almacenes;

namespace TP_CAI.Forms.ConsultaOrdenesDePreparacion.Model
{
    internal class OrdenPreparacion
    {
        public int Id { get; set; }
        public string DocumentoCliente { get; set; }
        public int DNITransportista { get; set; }
        public int IDDeposito { get; set; }
        public PrioridadOrdenPreparacion Prioridad { get; set; }
        public EstadoOrdenPreparacion Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEntrega { get; set; }

        public OrdenPreparacion(int id, string documentoCliente, int idDeposito, int dniTransportista, PrioridadOrdenPreparacion prioridad, EstadoOrdenPreparacion estado, DateTime fechaEntrega)
        {
            Id = id;
            DocumentoCliente = documentoCliente;
            IDDeposito = idDeposito;
            DNITransportista = dniTransportista;
            Prioridad = prioridad;
            Estado = estado;
            FechaEmision = DateTime.Now;
            FechaEntrega = fechaEntrega;
        }
    }
}
