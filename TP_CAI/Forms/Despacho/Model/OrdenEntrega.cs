namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {
        public class OrdenEntrega
        {
            public int Id { get; set; }
            public string DocumentoTransportista{ get; set; }
            public EstadoOrdenDeEntregaEnum Estado { get; set; }

            public OrdenEntrega(int id, string documentoTransportista)
            {
                Id = id;
                DocumentoTransportista = documentoTransportista;
                Estado = EstadoOrdenDeEntregaEnum.Pendiente;
            }
        }
    }
}
