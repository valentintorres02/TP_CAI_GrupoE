using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP_CAI.Almacenes
{
    internal static class RemitoAlmacen
    {
        private static List<RemitoEntidad> remitos = new List<RemitoEntidad>();

        public static IReadOnlyCollection<RemitoEntidad> Remitos => remitos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(remitos);

            File.WriteAllText(@"Datos\Remito.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists(@"Datos\Remito.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Datos\Remito.json");

            remitos = JsonSerializer.Deserialize<List<RemitoEntidad>>(datos)!;
        }

        internal static string Nuevo(RemitoEntidad nuevoRemito)
        {
            if (RemitoAlmacen.remitos.Count == 0)
            {
                nuevoRemito.IDRemito = 1;
            }
            else
            {
                nuevoRemito.IDRemito = RemitoAlmacen.Remitos.Max(o => o.IDRemito) + 1;
            }

            nuevoRemito.Fecha = DateTime.Now;
            remitos.Add(nuevoRemito);
            return null; //sin errores.
        }
    }
}
