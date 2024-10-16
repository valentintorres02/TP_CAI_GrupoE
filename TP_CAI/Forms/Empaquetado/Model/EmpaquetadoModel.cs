using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI.Forms.GestionOrdenSeleccion.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.Empaquetado.Model
{
    internal class EmpaquetadoModel
    {
        public List<OrdenPreparacion> ObtenerOrdenes()
        {
            // Crear una lista para almacenar las ordenes
            List<OrdenPreparacion> ordenes = new List<OrdenPreparacion>
            {
               new OrdenPreparacion(019, "20-44444444-4", "GrupoE S.R.L", 35012345, PrioridadEnum.Baja, EstadoOrdenPreparacionEnum.EnPreparacion, DateTime.Now),
               new OrdenPreparacion(025, "20-44444444-4", "C.A.I S.A", 35012345, PrioridadEnum.Media, EstadoOrdenPreparacionEnum.EnPreparacion, DateTime.Now),
               new OrdenPreparacion(034, "20-44444444-4", "Grupo-Z S.A", 35012345, PrioridadEnum.Alta, EstadoOrdenPreparacionEnum.EnPreparacion, DateTime.Now),
               new OrdenPreparacion(055, "20-44444444-4", "Molinos S.R.L", 35012345, PrioridadEnum.Alta, EstadoOrdenPreparacionEnum.EnPreparacion, DateTime.Now)
            };

            // Devolver la lista de ordenes
            return ordenes;
        }
    }
}
