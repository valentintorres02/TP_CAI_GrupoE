using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;

namespace TP_CAI.Almacenes
{
    internal static class DepositosAlmacen
    {
        private static List<DepositoEntidad> depositos = new List<DepositoEntidad>();

        public static IReadOnlyCollection<DepositoEntidad> Depositos => depositos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(depositos);
            File.WriteAllText(@"Datos\Depositos.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists(@"Datos\Depositos.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Datos\Depositos.json");

            depositos = JsonSerializer.Deserialize<List<DepositoEntidad>>(datos)!;
        }

        public static DepositoEntidad ObtenerDepositoPorId(int id)
        {
            return depositos.FirstOrDefault(c => c.IDDeposito == id);
        }
    }
}
