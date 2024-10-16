using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP_CAI.Forms.GestionOrdenSeleccion.Model
{

    internal class GestionOrdenSeleccionModel
    {
        // Obtener las ordenes como una lista de OrdenSeleccion
        public List<OrdenSeleccion> ObtenerOrdenes()
        {
            // Crear una lista para almacenar las ordenes
            List<OrdenSeleccion> ordenes = new List<OrdenSeleccion>
            {
                new OrdenSeleccion(19),
                new OrdenSeleccion(20),
                new OrdenSeleccion(21),
                new OrdenSeleccion(22),
                new OrdenSeleccion(23),
                new OrdenSeleccion(24),
            };

            // Devolver la lista de ordenes
            return ordenes;
        }
    }
}
