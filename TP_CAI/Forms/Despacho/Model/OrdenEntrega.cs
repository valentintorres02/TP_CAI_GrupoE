namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {
        public class OrdenEntrega
        {
            public int Id { get; set; }
            public string DocumentoCliente { get; set; }
            public EstadoOrdenDeEntregaEnum Estado { get; set; }

            public OrdenEntrega(int id, string documentoCliente, EstadoOrdenDeEntregaEnum estado)
            {
                Id = id;
                DocumentoCliente = documentoCliente;
                Estado = estado;
            }
        }
    }
}
