using TP_CAI.Forms.OrdenDePreparacion.Model;

namespace TP_CAI.Forms.Empaquetado.Model
{
    public class OrdenDePreparacionAEmpaquetar
    {
        public string Id { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
