using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;

namespace TP_CAI.Almacenes
{
	internal static class OrdenPreparacionAlmacen
	{
        private static List<OrdenPreparacionEntidad> ordenesPreparacion = new List<OrdenPreparacionEntidad>();

        static OrdenPreparacionAlmacen()
		{
			Leer();
		}

		public static IReadOnlyCollection<OrdenPreparacionEntidad> OrdenesPreparacion => ordenesPreparacion.AsReadOnly(); 

		public static void Grabar()
		{
			var datos = JsonSerializer.Serialize(ordenesPreparacion);

            File.WriteAllText(@"Datos\OrdenPreparacion.json", datos);
        }

		public static void Leer()
		{
			if (!File.Exists(@"Datos\OrdenPreparacion.json"))
			{
				return;
			}

			var datos = File.ReadAllText(@"Datos\OrdenPreparacion.json");

			ordenesPreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEntidad>>(datos)!;
		}

        public static List<OrdenPreparacionEntidad> ObtenerOrdenesPendientes()
        {
            return ordenesPreparacion.FindAll(o => o.Estado == EstadoOrdenPreparacion.PendienteDeSeleccion);
        }

        internal static string Nueva(OrdenPreparacionEntidad nuevaOrden)
        {
            if (OrdenPreparacionAlmacen.ordenesPreparacion.Count == 0)
            {
                nuevaOrden.IDOrdenPreparacion = 1;
            }
            else
            {
                nuevaOrden.IDOrdenPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion.Max(o => o.IDOrdenPreparacion) + 1;
            }


            ordenesPreparacion.Add(nuevaOrden);
            return null; //sin errores.
        }

        public static OrdenPreparacionEntidad ObtenerOrdenPorId(int id)
        {
            return ordenesPreparacion.FirstOrDefault(o => o.IDOrdenPreparacion == id);
        }

    }
}
