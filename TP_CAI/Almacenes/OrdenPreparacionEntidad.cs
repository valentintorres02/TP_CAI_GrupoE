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
		public int OrdenPreparacionId { get; set; }
		public int ClienteId { get; set; }
		public EstadosOrdenPreparacion Estado { get; set; }
		public int DniTransportista { get; set; }
		public Prioridades Prioridad { get; set; }
		public DateTime FechaEmision { get; set; }
		public DateTime FechaEntrega { get; set; }

		public List<OrdenPreparacionDetalle> Detalle { get; set; } = new();

		public void MarcarComoEnPreparacion()
		{
			this.Estado = EstadosOrdenPreparacion.EnPreparacion;
		}
	}
}
