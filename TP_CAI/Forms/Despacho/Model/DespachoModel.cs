using System.Collections.Generic;

namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {

        public List<OrdenDespacho> ObtenerOrdenes()
        {
            // Crear una lista para almacenar las ordenes
            List<OrdenDespacho> ordenes = new List<OrdenDespacho>
            {
                new OrdenDespacho("019", "20-44444444-4", "GrupoE S.R.L", "35012345", "Media", "Preparada"),
                new OrdenDespacho("025", "20-44444444-4", "C.A.I S.A", "35012345", "Media", "Preparada"),
                new OrdenDespacho("034", "20-44444444-4", "Grupo-Z S.A", "35012345", "Media", "Preparada"),
                new OrdenDespacho("055", "20-44444444-4", "Molinos S.R.L", "35012345", "Media", "Preparada")
            };

            // Devolver la lista de ordenes
            return ordenes;
        }
    }
}
