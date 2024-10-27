using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;
using TP_CAI.Almacenes;
using System.Xml;

namespace TP_CAI.Forms.GestionOrdenSeleccion.Model
{

    internal partial class GestionOrdenSeleccionModel
    {

        public List<OrdenSeleccion> OrdenesDeSeleccion { get; private set; }
        public List<Producto> Productos { get; private set; }

        public GestionOrdenSeleccionModel()
        {
            OrdenesDeSeleccion = new List<OrdenSeleccion>();
            Productos = new List<Producto>();

            foreach (var ordenSeleccionEntidad in OrdenSeleccionAlmacen.ObtenerOrdenesPendientes())
            {
                var ordenSeleccionModelo = new OrdenSeleccion(ordenSeleccionEntidad.IDOrdenSeleccion, null, ordenSeleccionEntidad.Estado);
                OrdenesDeSeleccion.Add(ordenSeleccionModelo);
            }
        }

        public void MarcarOrdenComoSeleccionada(int idOrden)
        {
            OrdenSeleccion ordenASeleccionar = OrdenesDeSeleccion.FirstOrDefault(o => o.Id == idOrden);

            var ordenSeleccion = OrdenSeleccionAlmacen.ObtenerOrdenPorId(idOrden);

            ordenSeleccion.MarcarComoSeleccionada();

            OrdenesDeSeleccion.Remove(ordenASeleccionar);
        }

        public List<Producto> ObtenerProductosDeOrden(int idOrden)
        {
            var ordenSeleccion = OrdenSeleccionAlmacen.ObtenerOrdenPorId(idOrden);
            var productos = new List<Producto>();

            foreach (var idOrdenPreparacion in ordenSeleccion.IDsOrdenesPreparacion)
            {
                var orden = OrdenPreparacionAlmacen.ObtenerOrdenPorId(idOrdenPreparacion);
                foreach (var detalle in orden.MercaderiaOrden)
                {
                    var newProducto = new Producto("UBICACION_WIP", detalle.Cantidad, detalle.IDProducto.ToString(), "DESCRIPCION_WIP");
                    productos.Add(newProducto);
                }
            }

            return productos;
        }

    }
}
