using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TP_CAI.Forms.GestionOrdenSeleccion.Model;

namespace TP_CAI.Almacenes
{
		internal static class OrdenSeleccionAlmacen
		{
		private static List<OrdenSeleccionEntidad> ordenesSeleccion = new List<OrdenSeleccionEntidad>();

        static OrdenSeleccionAlmacen()
			{
				Leer();
			}

			public static IReadOnlyCollection<OrdenSeleccionEntidad> OrdenesSeleccion => ordenesSeleccion.AsReadOnly();

			public static void Grabar()
			{
				var datos = JsonSerializer.Serialize(ordenesSeleccion);

				File.WriteAllText(@"Datos\OrdenSeleccion.json", datos);
			}

			public static void Leer()
			{
				if (!File.Exists(@"Datos\OrdenSeleccion.json"))
				{
					return;
				}

				var datos = File.ReadAllText(@"Datos\OrdenSeleccion.json");

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

        public static List<OrdenSeleccionEntidad> ObtenerOrdenesPendientes()
        {
            return ordenesSeleccion.FindAll(o => o.Estado == EstadoOrdenSeleccionEnum.PendienteDeSeleccion);
        }

        public static OrdenSeleccionEntidad ObtenerOrdenPorId(int idOrden)
        {
            return ordenesSeleccion.FirstOrDefault(o => o.IDOrdenSeleccion == idOrden);
        }
    }	

}
