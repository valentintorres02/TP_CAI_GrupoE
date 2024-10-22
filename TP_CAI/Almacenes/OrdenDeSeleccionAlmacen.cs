using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_CAI.Almacenes
{
		internal static class OrdenDeSeleccionAlmacen
		{
			private static List<OrdenDeSeleccionEntidad> ordenDeSeleccion = new List<OrdenDeSeleccionEntidad>();

			public static IReadOnlyCollection<OrdenDeSeleccionEntidad> OrdenDeSeleccion => ordenDeSeleccion.AsReadOnly();



			public static void Grabar()
			{
				var datos = JsonSerializer.Serialize(ordenDeSeleccion);

				File.WriteAllText("OrdenDeSeleccion.json", datos);
			}

			public static void Leer()
			{
				if (!File.Exists("OrdenDeSeleccion.json"))
				{
					return;
				}

				var datos = File.ReadAllText("OrdenDeSeleccion.json");

				ordenDeSeleccion = JsonSerializer.Deserialize<List<OrdenDeSeleccionEntidad>>(datos)!;
			}

			//FALTA AGREGAR EN EL PROGRAM SE EJECUTEN GRABAR Y LEER


		}
}
