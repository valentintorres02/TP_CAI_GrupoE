using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI.Almacenes;
using TP_CAI.Forms.OrdenDePreparacion.Model;

namespace TP_CAI.Forms.Empaquetado.Model
{

    internal class EmpaquetadoModel
    {
        public List<OrdenDePreparacionAEmpaquetar> OrdenesDePreparacionAEmpaquetar{ get; private set; }

        private List<Producto> ProductosIniciales = new List<Producto>();

        public EmpaquetadoModel()
        {
        ProductosIniciales = new List<Producto>();
        OrdenesDePreparacionAEmpaquetar = new List<OrdenDePreparacionAEmpaquetar>();
            var ordenesDePreparacionPendientesDeEmpaquetado = OrdenPreparacionAlmacen.ObtenerOrdenesPendientesDeEmpaquetado();

            foreach(var ordenPreparacion in ordenesDePreparacionPendientesDeEmpaquetado)
            {
                OrdenDePreparacionAEmpaquetar ordenDePreparacionAEmpaquetar = new OrdenDePreparacionAEmpaquetar();
                ordenDePreparacionAEmpaquetar.Productos = [];
                ordenDePreparacionAEmpaquetar.Id = ordenPreparacion.IDOrdenPreparacion.ToString();

                foreach(var productoOrden in ordenPreparacion.MercaderiaOrden)
                {
                    MercaderiaEntidad mercaderia = MercaderiaAlmacen.ObtenerMercaderiaPorId(productoOrden.IDMercaderia);
                    Producto productoAAgregar = new Producto();
                    productoAAgregar.Id = mercaderia.IDMercaderia.ToString();
                    productoAAgregar.Cantidad = productoOrden.Cantidad;
                    productoAAgregar.Descripcion = mercaderia.DescripcionMercaderia;
                    ordenDePreparacionAEmpaquetar.Productos.Add(productoAAgregar);
                }

                OrdenesDePreparacionAEmpaquetar.Add(ordenDePreparacionAEmpaquetar);

            }
        }

        public void MarcarOrdenComoEmpaquetada(OrdenDePreparacionAEmpaquetar orden)
        {
            if(orden == null)
            {
                return;
            }

            var ordenPreparacion = OrdenPreparacionAlmacen.ObtenerOrdenPorId(int.Parse(orden.Id));

            ordenPreparacion.MarcarComoPreparada();

            OrdenesDePreparacionAEmpaquetar.Remove(orden);
        }
    }
}
