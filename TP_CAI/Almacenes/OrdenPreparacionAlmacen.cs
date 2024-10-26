using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_CAI.Almacenes
{
	internal static class OrdenPreparacionAlmacen
	{
		private static List<OrdenPreparacionEntidad> ordenDePreparacion = new List<OrdenPreparacionEntidad>();

		public static IReadOnlyCollection<OrdenPreparacionEntidad> OrdenDePreparacion => ordenDePreparacion.AsReadOnly(); 



		public static void Grabar()
		{
			var datos = JsonSerializer.Serialize(ordenDePreparacion);

			File.WriteAllText("OrdenDePreparacion.json",datos);
		}

		public static void Leer()
		{
			if (!File.Exists("OrdenDePreparacion.json"))
			{
				return;
			}

			var datos = File.ReadAllText("OrdenDePreparacion.json");

			ordenDePreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEntidad>>(datos)!;
		}

		//FALTA AGREGAR EN EL PROGRAM SE EJECUTEN GRABAR Y LEER


	}
}
