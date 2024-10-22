namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {
        public class OrdenPreparacion
        {
            public int Id { get; set; }
            public string DocumentoTransportista{ get; set; }
            public EstadoOrdenDePreparacionEnum Estado { get; set; }
            public DateTime FechaEntrega { get; set; }
            public int IdOrdenEntrega { get; set; }

            public OrdenPreparacion(int id, string documentoTransportista, int idOrdenEntrega)
            {
                Id = id;
                DocumentoTransportista = documentoTransportista;
                Estado = EstadoOrdenDePreparacionEnum.PendienteDespacho;
                FechaEntrega = DateTime.Now;
                IdOrdenEntrega = idOrdenEntrega;
            }
        }
    }
}
