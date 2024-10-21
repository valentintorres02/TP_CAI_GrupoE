namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {
        public class OrdenPreparacion
        {
            public int Id { get; set; }
            public string DocumentoTransportista{ get; set; }
            public EstadoOrdenDePreparacionEnum Estado { get; set; }

            public OrdenPreparacion(int id, string documentoTransportista)
            {
                Id = id;
                DocumentoTransportista = documentoTransportista;
                Estado = EstadoOrdenDePreparacionEnum.PendienteDespacho;
            }
        }
    }
}
