using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_CAI.Almacenes
{
	internal static class ClienteAlmacen
	{
		private static List<ClienteEntidad> clientes = [];

		public static IReadOnlyCollection<ClienteEntidad> Clientes => clientes.AsReadOnly();

		public static void Grabar()
		{
			var datos = JsonSerializer.Serialize(clientes);
			File.WriteAllText("Clientes.json", datos);
		}

		public static void Leer()
		{
			if (!File.Exists(@"Clientes.json"))
			{
				return;
			}

			var datos = File.ReadAllText("Clientes.json");

			clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(datos)!;
		}
	}
}
