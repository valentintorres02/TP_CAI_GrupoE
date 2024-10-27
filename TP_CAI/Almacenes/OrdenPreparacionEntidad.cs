using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TP_CAI.Forms.Despacho.Model.DespachoModel;

namespace TP_CAI.Almacenes
{
	public class OrdenPreparacionEntidad
	{
		public int IDOrdenPreparacion { get; set; }
		public int IDDeposito { get; set; }
		public int IDCliente { get; set; }
		public EstadoOrdenPreparacion Estado { get; set; }
		public PrioridadOrdenPreparacion Prioridad { get; set; }
		public int DNITransportista { get; set; }
		public DateTime FechaEmision { get; set; }
		public DateTime FechaEntrega { get; set; }

		public List<MercaderiaOrden> MercaderiaOrden { get; set; } = new();

		public void MarcarComoEnPreparacion()
		{
			this.Estado = EstadoOrdenPreparacion.EnPreparacion;
		}
	}
}
