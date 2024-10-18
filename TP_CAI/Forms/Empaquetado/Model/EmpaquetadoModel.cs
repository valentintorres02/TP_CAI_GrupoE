using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CAI.Forms.OrdenDePreparacion.Model;

namespace TP_CAI.Forms.Empaquetado.Model
{

    internal class EmpaquetadoModel
    {
        public List<OrdenDePreparacionAEmpaquetar> OrdenesDePreparacionAEmpaquetar{ get; private set; }
       
        private List<Producto> ProductosIniciales = new List<Producto>
        {
            new Producto { Id = "001", Descripcion = "Producto A", Cantidad = 10 },
            new Producto { Id = "002", Descripcion = "Producto B", Cantidad = 20 },
            new Producto { Id = "003", Descripcion = "Producto C", Cantidad = 15 },
            new Producto { Id = "004", Descripcion = "Producto D", Cantidad = 25 },
            new Producto { Id = "005", Descripcion = "Producto E", Cantidad = 30 }
        };

        private List<Producto> ProductosIniciales2 = new List<Producto>
        {
            new Producto { Id = "014", Descripcion = "Producto F", Cantidad = 75 },
            new Producto { Id = "024", Descripcion = "Producto G", Cantidad = 3 },
            new Producto { Id = "030", Descripcion = "Producto H", Cantidad = 5 },
        };

        private List<Producto> ProductosIniciales3 = new List<Producto>
        {
            new Producto { Id = "014", Descripcion = "Producto I", Cantidad = 5 },
            new Producto { Id = "024", Descripcion = "Producto J", Cantidad = 30 },
            new Producto { Id = "030", Descripcion = "Producto K", Cantidad = 12 },
        };

        private List<Producto> ProductosIniciales4 = new List<Producto>
        {
            new Producto { Id = "014", Descripcion = "Producto L", Cantidad = 11 },
            new Producto { Id = "024", Descripcion = "Producto M", Cantidad = 3 },
            new Producto { Id = "030", Descripcion = "Producto N", Cantidad = 21 },
            new Producto { Id = "030", Descripcion = "Producto O", Cantidad = 4 },
        };

        private List<Producto> ProductosIniciales5 = new List<Producto>
        {
            new Producto { Id = "014", Descripcion = "Producto P", Cantidad = 3 },
            new Producto { Id = "024", Descripcion = "Producto Q", Cantidad = 12 },
            new Producto { Id = "030", Descripcion = "Producto R", Cantidad = 1 },
            new Producto { Id = "030", Descripcion = "Producto S", Cantidad = 22 },
            new Producto { Id = "030", Descripcion = "Producto T", Cantidad = 40 },
        };

        public EmpaquetadoModel()
        {
            OrdenesDePreparacionAEmpaquetar = new List<OrdenDePreparacionAEmpaquetar>
            {
                new OrdenDePreparacionAEmpaquetar { Id = "001", Productos = ProductosIniciales },
                new OrdenDePreparacionAEmpaquetar { Id = "002", Productos = ProductosIniciales2 },
                new OrdenDePreparacionAEmpaquetar { Id = "003", Productos = ProductosIniciales3 },
                new OrdenDePreparacionAEmpaquetar { Id = "004", Productos = ProductosIniciales4 },
                new OrdenDePreparacionAEmpaquetar { Id = "005", Productos = ProductosIniciales5 },
             };
        }

        public void MarcarOrdenComoEmpaquetada(OrdenDePreparacionAEmpaquetar orden)
        {
            if(orden == null)
            {
                return;
            }

            OrdenesDePreparacionAEmpaquetar.Remove(orden);
        }
    }
}
