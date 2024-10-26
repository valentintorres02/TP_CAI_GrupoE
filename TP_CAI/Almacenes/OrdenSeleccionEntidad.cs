using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI.Forms.GestionOrdenSeleccion.Model;

namespace TP_CAI.Almacenes
{
	internal class OrdenSeleccionEntidad
	{
        public int IDOrdenSeleccion { get; set; }
        public EstadoOrdenSeleccionEnum Estado { get; set; }
        public List<OrdenPreparacionEntidad> OrdenesPreparacion { get; } = new();
    }
}
