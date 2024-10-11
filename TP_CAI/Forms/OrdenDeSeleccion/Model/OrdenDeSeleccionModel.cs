using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using TP_CAI.Forms.GestionOrdenSeleccion.Model;

namespace TP_CAI.Forms.OrdenDeSeleccion.Forms.Model
{

    internal class OrdenDeSeleccionModel
    {
        // Obtener las ordenes como una lista de OrdenPreparacion
        public List<OrdenPreparacion> ObtenerOrdenes()
        {
            // Crear una lista para almacenar las ordenes
            List<OrdenPreparacion> ordenes = new List<OrdenPreparacion>
            {
              new OrdenPreparacion(019, "20-44444444-4", "GrupoE S.R.L", 35012345, PrioridadEnum.Baja, EstadoOrdenPreparacionEnum.Pendiente),
                new OrdenPreparacion(025, "20-44444444-4", "C.A.I S.A", 35012345, PrioridadEnum.Media, EstadoOrdenPreparacionEnum.Pendiente),
                new OrdenPreparacion(034, "20-44444444-4", "Grupo-Z S.A", 35012345, PrioridadEnum.Alta, EstadoOrdenPreparacionEnum.Pendiente),
                new OrdenPreparacion(055, "20-44444444-4", "Molinos S.R.L", 35012345, PrioridadEnum.Alta, EstadoOrdenPreparacionEnum.Pendiente)
            };

            // Devolver la lista de ordenes
            return ordenes;
        }

        public string CrearOrden(string documentoCliente)
        {
            // Generar un ID único 
            int nuevoId = 1;

            // Crear una nueva instancia de OrdenPreparacion
            var nuevaOrden = new OrdenSeleccion(nuevoId, documentoCliente, EstadoOrdenSeleccionEnum.PendienteDeSeleccion);

            // Retornar un mensaje de éxito
            return $"La orden de selección ID {nuevaOrden.Id} se generó correctamente";
        }
    }
}
