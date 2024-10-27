namespace TP_CAI.Forms.GestionOrdenSeleccion.Model
{
    public class OrdenSeleccion
    {
        public int Id { get; set; }
        public EstadoOrdenSeleccion Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<int> IdsOrdenesPreparacion { get; set; }

        public OrdenSeleccion(int id, List<int> idsOrdenesPreparacion = null, EstadoOrdenSeleccion estado = EstadoOrdenSeleccion.PendienteDeSeleccion)
        {
            Id = id;
            Estado = estado;
            FechaEmision = DateTime.Now;
            IdsOrdenesPreparacion = idsOrdenesPreparacion ?? new List<int>();
        }
    }
}


