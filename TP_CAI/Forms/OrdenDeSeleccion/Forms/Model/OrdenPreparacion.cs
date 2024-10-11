namespace TP_CAI.Forms.OrdenDeSeleccion.Forms.Model
{
    // Clase que representa una orden de preparación
    public class OrdenPreparacion
    {
        public bool Seleccionado { get; set; }
        public string NumeroOrden { get; set; }
        public string NumeroSeguimiento { get; set; }
        public string Prioridad { get; set; }
        public string Estado { get; set; }

        public OrdenPreparacion(bool seleccionado, string numeroOrden, string numeroSeguimiento, string prioridad, string estado)
        {
            Seleccionado = seleccionado;
            NumeroOrden = numeroOrden;
            NumeroSeguimiento = numeroSeguimiento;
            Prioridad = prioridad;
            Estado = estado;
        }
    }
}
