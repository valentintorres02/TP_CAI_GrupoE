using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CAI.Almacenes
{
	internal class MercaderiaEntidad
	{
		public int ProductoId { get; set; }
		public int ClienteId { get; set; }
		public string Nombre { get; set; }
		public List<MercaderiaStock> Stock { get; set; } = [];


		//Es importante que un valor calculado sea un METODO.
		public int CalcularTotalStock(int depositoId) => Stock.Where(s => s.DepositoId == depositoId).Sum(s => s.Cantidad); 
	}
}
