using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI.Forms.GestionOrdenSeleccion.Model;

namespace TP_CAI.Almacenes
{
	internal class OrdenEntregaEntidad
	{
		public int IDOrdenEntrega {  get; set; }
		public EstadoOrdenEntrega Estado { get; set; }
		public List<int> IDsOrdenesPreparacion { get; set; }
        public void MarcarComoListaParaDespachar()
        {
            this.Estado = EstadoOrdenEntrega.ListaParaDespachar;
        }
        public void MarcarComoFinalizada()
        {
            this.Estado = EstadoOrdenEntrega.Finalizada;
        }
    }
}
