using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CAI.Almacenes
{
    internal class RemitoEntidad
    {
        public int IDRemito {  get; set; }
        public DateTime Fecha { get; set; }
        public int IDCliente { get; set; }
        public int DNITransportista { get; set; }
        public List<int> IDsOrdenesPreparacion {  get; set; }
    }
}
