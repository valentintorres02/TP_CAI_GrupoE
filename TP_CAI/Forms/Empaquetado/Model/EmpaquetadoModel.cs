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
                new OrdenPreparacion(false, "19", "20-44444444-4", "Media", "En Preparación"),
                new OrdenPreparacion(false, "20", "20-55555555-4", "Media", "En Preparación"),
                new OrdenPreparacion(false, "21", "20-66666666-4", "Alta", "En Preparación"),
                new OrdenPreparacion(false, "22", "20-77777777-4", "Baja", "En Preparación"),
                new OrdenPreparacion(false, "23", "20-88888888-4", "Alta", "En Preparación"),
                new OrdenPreparacion(false, "24", "20-99999999-4", "Alta", "En Preparación")
            };

            // Devolver la lista de ordenes
            return ordenes;
        }
    }
}
