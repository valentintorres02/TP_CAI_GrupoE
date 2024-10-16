using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.GestionOrdenSeleccion.Model
{

    internal partial class GestionOrdenSeleccionModel
    {

        public List<OrdenSeleccion> OrdenesDeSeleccion { get; private set; }
        public List<Producto> Productos { get; private set; }

        public GestionOrdenSeleccionModel()
        {
            OrdenesDeSeleccion = new List<OrdenSeleccion>
            {
                new OrdenSeleccion(19),
                new OrdenSeleccion(20),
                new OrdenSeleccion(21),
                new OrdenSeleccion(22),
                new OrdenSeleccion(23),
                new OrdenSeleccion(24),
            };

            Productos = new List<Producto>
            {
                new Producto("12-43-2", 17, "001", "Pantalones"),
                new Producto("4-45-1", 14, "002", "Camperas"),
                new Producto("4-45-2", 1, "002", "Camperas"),
                new Producto("4-48-5", 5, "006", "Remeras"),
                new Producto("4-48-6", 2, "006", "Remeras"),
            };
        }

        public void EliminarOrdenDeLista(int idOrden)
        {
            OrdenSeleccion ordenAEliminar = OrdenesDeSeleccion.FirstOrDefault(o => o.Id == idOrden);

            OrdenesDeSeleccion.Remove(ordenAEliminar);
        }

    }
}
