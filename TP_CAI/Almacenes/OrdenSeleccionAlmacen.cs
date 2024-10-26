using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_CAI.Almacenes
{
		internal static class OrdenSeleccionAlmacen
		{
			private static List<OrdenSeleccionEntidad> ordenesSeleccion = new List<OrdenSeleccionEntidad>();

			public static IReadOnlyCollection<OrdenSeleccionEntidad> OrdenesSeleccion => ordenesSeleccion.AsReadOnly();



			public static void Grabar()
			{
				var datos = JsonSerializer.Serialize(ordenesSeleccion);

				File.WriteAllText("OrdenDeSeleccion.json", datos);
			}

			public static void Leer()
			{
				if (!File.Exists("OrdenDeSeleccion.json"))
				{
					return;
				}

				var datos = File.ReadAllText("OrdenDeSeleccion.json");

				ordenesSeleccion = JsonSerializer.Deserialize<List<OrdenSeleccionEntidad>>(datos)!;
			}

        internal static string Nueva(OrdenSeleccionEntidad nuevaOrden)
        {
            if (OrdenSeleccionAlmacen.ordenesSeleccion.Count == 0)
            {
                nuevaOrden.IDOrdenSeleccion = 1;
            }
            else
            {
                nuevaOrden.IDOrdenSeleccion = OrdenSeleccionAlmacen.OrdenesSeleccion.Max(o => o.IDOrdenSeleccion) + 1;
            }


            ordenesSeleccion.Add(nuevaOrden);
            return null; //sin errores.
        }
    }	

}
