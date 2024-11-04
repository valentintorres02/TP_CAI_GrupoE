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

                foreach (var mercaderiaOrden in orden.MercaderiaOrden)
                {
                    var mercaderia = MercaderiaAlmacen.ObtenerMercaderiaPorId(mercaderiaOrden.IDMercaderia);

                    if (mercaderia == null)
                    {
                        continue;
                    }

                    int cantidadRestante = mercaderiaOrden.Cantidad;
                    var ubicaciones = mercaderia.Ubicaciones
                        .Where(u => u.IDDeposito == orden.IDDeposito && u.Cantidad > 0)
                        .OrderBy(u => u.Cantidad)
                        .ToList();

                    MessageBox.Show("Mercaderia" + mercaderia.IDMercaderia + mercaderia.DescripcionMercaderia);
                    MessageBox.Show("Ubicaciones" + ubicaciones.Count.ToString());

                    foreach (var ubicacion in ubicaciones)
                    {
                        if (cantidadRestante <= 0) break;

                        int cantidadTomada = Math.Min(ubicacion.Cantidad, cantidadRestante);

                        var producto = new Producto(
                            ubicacion: $"{ubicacion.IDDeposito}-{ubicacion.Ubicacion}",
                            cantidad: cantidadTomada,
                            idProducto: mercaderiaOrden.IDMercaderia.ToString(),
                            descripcionProducto: mercaderia.DescripcionMercaderia
                        );

                        productos.Add(producto);

                        cantidadRestante -= cantidadTomada;
                    }

                    if (cantidadRestante > 0)
                    {
                        // Añadir un producto indicando que no hay suficiente stock
                        productos.Add(new Producto(
                            ubicacion: "Sin stock suficiente",
                            cantidad: cantidadRestante,
                            idProducto: mercaderiaOrden.IDMercaderia.ToString(),
                            descripcionProducto: $"{mercaderia.DescripcionMercaderia} (faltante)"
                        ));
                    }
                }
            }

            return productos;
        }

    }
}
