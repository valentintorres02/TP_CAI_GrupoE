using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.OrdenDeEntrega.Model
{

    internal class OrdenDeEntregaModel
    {
        // Obtener las órdenes como una lista de OrdenEntrega
        public List<OrdenPreparacion> ObtenerOrdenes()
        {
            // Crear una lista para almacenar las órdenes
            List<OrdenPreparacion> ordenes = new List<OrdenPreparacion>
            {
               new OrdenPreparacion(019, "20-44444444-4", "GrupoE S.R.L", 35012345, PrioridadEnum.Baja, EstadoOrdenPreparacionEnum.Preparada, DateTime.Now),
                new OrdenPreparacion(025, "20-44444444-4", "C.A.I S.A", 35012345, PrioridadEnum.Media, EstadoOrdenPreparacionEnum.Preparada, DateTime.Now),
                new OrdenPreparacion(034, "20-44444444-4", "Grupo-Z S.A", 35012345, PrioridadEnum.Alta, EstadoOrdenPreparacionEnum.Preparada, DateTime.Now),
                new OrdenPreparacion(055, "20-44444444-4", "Molinos S.R.L", 35012345, PrioridadEnum.Alta, EstadoOrdenPreparacionEnum.Preparada, DateTime.Now)
            };

            return ordenes;
        }
    }
}
