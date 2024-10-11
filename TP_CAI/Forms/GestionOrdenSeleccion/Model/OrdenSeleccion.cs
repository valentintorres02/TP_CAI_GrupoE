namespace TP_CAI.Forms.GestionOrdenSeleccion.Model
{
    // Clase que representa una orden de selección
    public class OrdenSeleccion
    {
        public bool Seleccionado { get; set; }
        public string NumeroOrden { get; set; }
        public string NumeroSeguimiento { get; set; }
        public string Estado { get; set; }

        public OrdenSeleccion(bool seleccionado, string numeroOrden, string numeroSeguimiento, string estado)
        {
            Seleccionado = seleccionado;
            NumeroOrden = numeroOrden;
            NumeroSeguimiento = numeroSeguimiento;
            Estado = estado;
        }
    }
}
