using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace TP_CAI.Forms.OrdenDeSeleccion.Forms.Model
{

    internal class OrdenDeSeleccionModel
    {
        public int DniTransportista { get; set; }

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
    }
}
