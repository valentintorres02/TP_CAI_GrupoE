namespace TP_CAI.Forms.OrdenDeSeleccion.Forms.Model
{
    // Clase que representa una orden de preparación
    public class OrdenPreparacion
    {
        public int Id { get; set; }
        public string DocumentoCliente{ get; set; }
        public string NombreCliente{ get; set; }
        public int DNITransportista { get; set; }
        public PrioridadEnum Prioridad { get; set; }
        public EstadoOrdenPreparacionEnum Estado { get; set; }

        public OrdenPreparacion(int id, string documentoCliente, string nombreCliente, int dniTransportista, PrioridadEnum prioridad, EstadoOrdenPreparacionEnum estado)
        {
            Id = id;
            DocumentoCliente = documentoCliente;
            NombreCliente = nombreCliente;
            DNITransportista = dniTransportista;
            Prioridad = prioridad;
            Estado = estado;
        }
    }
}
