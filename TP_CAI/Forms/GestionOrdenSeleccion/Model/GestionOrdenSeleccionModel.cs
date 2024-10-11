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
                new OrdenSeleccion(false, "19", "20-44444444-4", "Pendiente de Seleccion"),
                new OrdenSeleccion(false, "20", "20-55555555-4", "Pendiente de Seleccion"),
                new OrdenSeleccion(false, "21", "20-66666666-4", "Pendiente de Seleccion"),
                new OrdenSeleccion(false, "22", "20-77777777-4", "Pendiente de Seleccion"),
                new OrdenSeleccion(false, "23", "20-88888888-4", "Pendiente de Seleccion"),
                new OrdenSeleccion(false, "24", "20-99999999-4", "Pendiente de Seleccion")
            };

            // Devolver la lista de ordenes
            return ordenes;
        }
    }
}
