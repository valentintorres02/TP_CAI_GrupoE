using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TP_CAI.Forms.GestionOrdenSeleccion.Model;

namespace TP_CAI.Almacenes
{
	internal static class OrdenEntregaAlmacen
	{
        private static List<OrdenEntregaEntidad> ordenesEntrega = new List<OrdenEntregaEntidad>();

        public static IReadOnlyCollection<OrdenEntregaEntidad> OrdenesEntrega => ordenesEntrega.AsReadOnly();

		public static void Grabar()
		{
			var datos = JsonSerializer.Serialize(ordenesEntrega);

			File.WriteAllText(@"Datos\OrdenEntrega.json", datos);
		}

		public static void Leer()
		{
			if (!File.Exists(@"Datos\OrdenEntrega.json"))
			{
				return;
			}

			var datos = File.ReadAllText(@"Datos\OrdenEntrega.json");

			ordenesEntrega = JsonSerializer.Deserialize<List<OrdenEntregaEntidad>>(datos)!;
		}

        internal static string Nueva(OrdenEntregaEntidad nuevaOrden)
        {
            if (OrdenEntregaAlmacen.ordenesEntrega.Count == 0)
            {
                nuevaOrden.IDOrdenEntrega = 1;
            }
            else
            {
                nuevaOrden.IDOrdenEntrega = OrdenEntregaAlmacen.OrdenesEntrega.Max(o => o.IDOrdenEntrega) + 1;
            }


            ordenesEntrega.Add(nuevaOrden);
            return null; //sin errores.
        }

        public static List<OrdenEntregaEntidad> ObtenerOrdenesParaDespacho()
        {
            return ordenesEntrega.FindAll(o => o.Estado == EstadoOrdenEntrega.PendienteDeDespacho || o.Estado == EstadoOrdenEntrega.ListaParaDespachar);
        }

        public static OrdenEntregaEntidad ObtenerOrdenPorId(int idOrden)
        {
            return ordenesEntrega.FirstOrDefault(o => o.IDOrdenEntrega == idOrden);
        }
    }
}
