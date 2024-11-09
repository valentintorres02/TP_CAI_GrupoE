using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static TP_CAI.Forms.Despacho.Model.DespachoModel;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;

namespace TP_CAI.Almacenes
{
	internal static class OrdenPreparacionAlmacen
	{
        private static List<OrdenPreparacionEntidad> ordenesPreparacion = new List<OrdenPreparacionEntidad>();

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

        public static List<OrdenPreparacionEntidad> ObtenerOrdenesPendientesDeSeleccion()
        {
            return ordenesPreparacion.FindAll(o => o.Estado == EstadoOrdenPreparacion.PendienteDeSeleccion);
        }

        public static List<OrdenPreparacionEntidad> ObtenerOrdenesPendientesDeEmpaquetado()
        {
            return ordenesPreparacion.FindAll(o => o.Estado == EstadoOrdenPreparacion.PendienteDeEmpaquetado);
        }

        public static List<OrdenPreparacionEntidad> ObtenerOrdenesParaDespacho()
        {
            return ordenesPreparacion.FindAll(o => o.Estado == EstadoOrdenPreparacion.PendienteDeDespacho || o.Estado == EstadoOrdenPreparacion.ListaParaDespachar);
        }

        public static List<int> ObtenerTransportistasConOrdenesParaDespacho()
        {

            // Crear un HashSet para almacenar DNI únicos
            HashSet<int> dniTransportistasUnicos = new HashSet<int>();

            var ordenes = ObtenerOrdenesParaDespacho();

            foreach (var o in ordenes)
            {
                dniTransportistasUnicos.Add(o.DNITransportista);
            }

           var transportistas = new List<int>(dniTransportistasUnicos);

            return transportistas;
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

        public static List<OrdenPreparacionEntidad> ObtenerOrdenesPreparadas()
        {
            return ordenesPreparacion.FindAll(o => o.Estado == EstadoOrdenPreparacion.Preparada);
        }

        public static int CalcularCantidadReservada(int idDeposito, int idMercaderia, int idCliente)
        {
            // Buscar las ordenes de preparacion en estado "EnPreparacion" o "Preparada", donde el deposito y el cliente coincidan
            var ordenes = ordenesPreparacion.FindAll(o => (o.Estado == EstadoOrdenPreparacion.PendienteDeSeleccion || o.Estado == EstadoOrdenPreparacion.EnPreparacion) && o.IDDeposito== idDeposito && o.IDCliente == idCliente);

            int cantidadReservada = 0;


            foreach (var o in ordenes) {
                // Buscar la mercaderia en la orden de preparacion
                var mercaderiaOrden = o.MercaderiaOrden.Find(mo => mo.IDMercaderia == idMercaderia);

                if (mercaderiaOrden != null)
                {
                    cantidadReservada += mercaderiaOrden.Cantidad;
                }
            }


            return cantidadReservada;
        }
    }
}
