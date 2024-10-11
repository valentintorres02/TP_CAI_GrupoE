namespace TP_CAI.Forms.GestionOrdenSeleccion.Model
{
    public class OrdenSeleccion
    {
        public int Id { get; set; }
        public string DocumentoCliente { get; set; }
        public EstadoOrdenSeleccionEnum Estado { get; set; }
        public DateTime FechaEmision { get; set; }

        public OrdenSeleccion(int id, string documentoCliente, EstadoOrdenSeleccionEnum estado)
        {
            Id = id;
            DocumentoCliente = documentoCliente;
            Estado = estado;
            FechaEmision = DateTime.Now;
        }
    }
}


