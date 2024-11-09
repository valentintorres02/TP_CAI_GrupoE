using TP_CAI.Almacenes;

namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {
        public class OrdenPreparacion
        {
            public int Id { get; set; }
            public string DocumentoTransportista{ get; set; }
            public EstadoOrdenPreparacion Estado { get; set; }
            public DateTime FechaEntrega { get; set; }
            public int IdOrdenEntrega { get; set; }

            public OrdenPreparacion(int id, string documentoTransportista, EstadoOrdenPreparacion estado, int idOrdenEntrega)
            {
                Id = id;
                DocumentoTransportista = documentoTransportista;
                Estado = estado;
                FechaEntrega = DateTime.Now;
                IdOrdenEntrega = idOrdenEntrega;
            }
        }
    }
}
