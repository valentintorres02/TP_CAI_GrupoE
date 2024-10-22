using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_CAI.Almacenes
{
	internal static class MercaderiaAlmacen
	{
		private static List<MercaderiaEntidad> mercaderia = new List<MercaderiaEntidad>();

		public static IReadOnlyCollection<MercaderiaEntidad> Mercaderia => mercaderia.AsReadOnly();



		public static void Grabar()
		{
			var datos = JsonSerializer.Serialize(mercaderia);

			File.WriteAllText("Mercaderia.json", datos);
		}

		public static void Leer()
		{
			if (!File.Exists("Mercaderia.json"))
			{
				return;
			}

			var datos = File.ReadAllText("Mercaderia.json");

			mercaderia = JsonSerializer.Deserialize<List<MercaderiaEntidad>>(datos)!;
		}

		//FALTA AGREGAR EN EL PROGRAM SE EJECUTEN GRABAR Y LEER


	}
}
