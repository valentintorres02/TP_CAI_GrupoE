using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP_CAI.Forms.OrdenDeEntrega.Model
{

    internal class OrdenDeEntregaModel
    {
        // Obtener las órdenes como una lista de OrdenEntrega
        public List<OrdenEntrega> ObtenerOrdenes()
        {
            // Crear una lista para almacenar las órdenes
            List<OrdenEntrega> ordenes = new List<OrdenEntrega>
            {
                new OrdenEntrega(false, "19", "20-44444444-4", "Media", "Preparada"),
                new OrdenEntrega(false, "20", "20-55555555-4", "Media", "Preparada"),
                new OrdenEntrega(false, "21", "20-66666666-4", "Alta", "Preparada"),
                new OrdenEntrega(false, "22", "20-77777777-4", "Baja", "Preparada"),
                new OrdenEntrega(false, "23", "20-88888888-4", "Alta", "Preparada"),
                new OrdenEntrega(false, "24", "20-99999999-4", "Alta", "Preparada")
            };

            return ordenes;
        }
    }
}
