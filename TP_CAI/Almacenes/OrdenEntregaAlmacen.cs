using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_CAI.Almacenes
{
	internal static class OrdenEntregaAlmacen
	{
		private static List<OrdenEntregaEntidad> ordenDeEntrega = new List<OrdenEntregaEntidad>();

		public static IReadOnlyCollection<OrdenEntregaEntidad> OrdenDeEntrega => ordenDeEntrega.AsReadOnly();



		public static void Grabar()
		{
			var datos = JsonSerializer.Serialize(ordenDeEntrega);

			File.WriteAllText("OrdenDeEntrega.json", datos);
		}

		public static void Leer()
		{
			if (!File.Exists("OrdenDeEntrega.json"))
			{
				return;
			}

			var datos = File.ReadAllText("OrdenDeEntrega.json");

			ordenDeEntrega = JsonSerializer.Deserialize<List<OrdenEntregaEntidad>>(datos)!;
		}

		//FALTA AGREGAR EN EL PROGRAM SE EJECUTEN GRABAR Y LEER


	}
}
