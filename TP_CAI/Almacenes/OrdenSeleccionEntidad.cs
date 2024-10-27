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
        public EstadoOrdenSeleccion Estado { get; set; }
        public List<int> IDsOrdenesPreparacion { get; set; } = new();
        public void MarcarComoSeleccionada()
        {
            this.Estado = EstadoOrdenSeleccion.Seleccionada;
        }
    }
}
