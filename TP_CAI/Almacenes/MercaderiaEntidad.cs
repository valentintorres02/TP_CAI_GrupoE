using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CAI.Almacenes
{
	internal class MercaderiaEntidad
	{
		public int IDMercaderia { get; set; }
		public int IDCliente { get; set; }
		public string DescripcionMercaderia { get; set; }
		public List<MercaderiaUbicacion> Ubicaciones { get; set; } = [];


		//Es importante que un valor calculado sea un METODO.
		public int CalcularTotalStock(int depositoId) => Ubicaciones.Where(s => s.IDDeposito == depositoId).Sum(s => s.Cantidad); 
		public int CalcularTotalStockSinDeposito() => Ubicaciones.Sum(s => s.Cantidad); 
	}
}
