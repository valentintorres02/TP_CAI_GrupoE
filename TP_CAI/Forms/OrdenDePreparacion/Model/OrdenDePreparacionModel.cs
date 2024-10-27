using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TP_CAI.Almacenes;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;

namespace TP_CAI.Forms.OrdenDePreparacion.Model
{
    internal partial class OrdenDePreparacionModel
    {
        //Agregamos esta propiedad y hacemos que la pantalla, al seleccionar un cliente, le 
        //pase este dato al modelo.
        public string ClienteSeleccionado { get; set; }
        public int DepositoSeleccionado { get; set; }

        public List<Producto> ProductosDisponibles
        {
            get
            {
                var clienteEntidad = ClienteAlmacen.Clientes.FirstOrDefault(c => c.CUITCliente == ClienteSeleccionado);
                if (clienteEntidad == null)
                {
                    return new List<Producto>();
                }

                var depositoEntidad = DepositosAlmacen.Depositos.FirstOrDefault(d => d.IDDeposito == DepositoSeleccionado);
                if (depositoEntidad == null)
                {
                    return new List<Producto>();
                }


                var productosCliente = new List<Producto>();

                foreach (var productoEntidad in MercaderiaAlmacen.Mercaderia)
                {
                    if (productoEntidad.IDCliente == clienteEntidad.IDCliente)
                    {
                        var productoModelo = new Producto();
                        productoModelo.Id = productoEntidad.IDMercaderia.ToString();
                        productoModelo.Cantidad = productoEntidad.CalcularTotalStock(depositoEntidad.IDDeposito);
                        productoModelo.Descripcion = productoEntidad.DescripcionMercaderia;

                        if (productoModelo.Cantidad == 0)
                        {
                            continue;
                        }

                        var productoAgregado = ProductosAgregados.FirstOrDefault(pa => pa.Id == productoEntidad.IDMercaderia.ToString());
                        if (productoAgregado != null) //significa que ya está este producto en la orden
                        {
                            continue;
                        }

                        productosCliente.Add(productoModelo);
                    }
                }

                return productosCliente;
            }
        }

        public int DniTransportista { get; set; }
        public List<Producto> ProductosAgregados { get; private set; }
        public List<Cliente> Clientes { get; private set; }
        public List<Deposito> Depositos { get; private set; }

        public OrdenDePreparacionModel()
        {
            Depositos = DepositosAlmacen.Depositos.Select(d => new Deposito
            {
                Id = d.IDDeposito,
                Direccion = d.Direccion
            }).ToList(); 

            Clientes = new List<Cliente>();
            foreach (var clienteEntidad in ClienteAlmacen.Clientes)
            {
                var clienteModelo = new Cliente();
                clienteModelo.Documento = clienteEntidad.CUITCliente;
                clienteModelo.Nombre = clienteEntidad.Nombre;
                Clientes.Add(clienteModelo);
            }

            ProductosAgregados = [];
        }

        public string? ValidarDniTransportista(string dniText)
        {
            var isDniCompleto = !string.IsNullOrWhiteSpace(dniText);

            if (!isDniCompleto)
            {
                return "Por favor complete el campo DNI Transportista.";
            }

            if (!int.TryParse(dniText, out _))
            {
                return "El DNI de Transportista debe ser un número válido. Por favor ingrese un valor correcto.";
            }

            if (dniText.Length < 7)
            {
                return "El DNI de Transportista debe tener como mínimo 7 dígitos. Por favor ingrese un valor correcto.";
            }

            if (dniText.Length > 8)
            {
                return "El DNI de Transportista debe tener como máximo 8 dígitos. Por favor ingrese un valor correcto.";
            }

            return null;
        }

        public string? ValidarPrioridad(bool isPrioridadSeleccionada)
        {
            if (!isPrioridadSeleccionada)
            {
                return "Por favor complete el campo Prioridad.";
            }

            return null;

        }

        public string? ValidarCliente(string documentoCliente)
        {
            if (documentoCliente is null or "")
            {
                return "Por favor seleccione un cliente valido.";
            }

            return null;
        }

        public string? ValidarDeposito(string idDepositoOpcion)
        {
            if (idDepositoOpcion is null or "")
            {
                return "Por favor seleccione un deposito valido.";
            }

            return null;
        }

        public string? ValidarCantidades(int cantidad1, int cantidad2, string descripcion, string cantidadItem)
        {
            if (cantidad1 < 1)
            {
                return "No pueden agregarse a la órden de preparación " + cantidad1 + " unidades del producto " + descripcion + " ya que debe ser igual o superior a 1. Por favor intente con un valor igual o menor a " + cantidadItem + " pero mayor que 0.";
            }

            if (cantidad1 > cantidad2)
            {
                return "No pueden agregarse a la órden de preparación " + cantidad1 + " unidades del producto " + descripcion + " ya que solo se cuentan con " + cantidadItem + " unidades. Por favor intente con un valor igual o menor a " + cantidadItem;
            }

            return null;
        }

        public string? ValidarProductosAgregados(int cantidadProductosAgregados)
        {
            if (cantidadProductosAgregados < 1)
            {
                return "Debe agregar al menos 1 producto a la orden.";
            }

            return null;
        }

        private bool IsDateValid(DateTime selectedDate) =>
            // Comparar con la fecha actual
            selectedDate >= DateTime.Today;

        public string? ValidarFechaEntrega(DateTime fechaEntrega)
        {
            if (!IsDateValid(fechaEntrega))
            {
                return "Elige una fecha valida. No pueden elegirse fechas pasadas";
            }

            return null;
        }

        public string? AgregarProducto(string id, string descripcion, int cantidad1, int cantidad2)
        {
            // Validar la cantidad
            var errorCantidad = ValidarCantidades(cantidad1, cantidad2, descripcion, cantidad2.ToString());
            if (errorCantidad != null)
            {
                return errorCantidad; // Retornar el error si hay uno
            }

            // Agregar el producto a la lista de ProductosAgregados
            var producto = new Producto
            {
                Id = id,
                Descripcion = descripcion,
                Cantidad = cantidad1
            };

            ProductosAgregados.Add(producto);
            return null; // Sin errores
        }

        public void EliminarProducto(string id)
        {
            var producto = ProductosAgregados.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                _ = ProductosAgregados.Remove(producto);
            }
        }

        public void EliminarTodosLosProductos()
        {
            ProductosAgregados = [];
        }

        public string CrearOrden(string documentoCliente, string nombreCliente, int dniTransportista, PrioridadEnum prioridad, DateTime fechaEntrega)
        {
            //Crear una orden de preparacion (entidad)
            //pasarsela al archivo.

            var nuevaOrden = new OrdenPreparacionEntidad();

            nuevaOrden.Prioridad = prioridad switch
            {
                PrioridadEnum.Alta => PrioridadOrdenPreparacion.Alta,
                PrioridadEnum.Media => PrioridadOrdenPreparacion.Media,
                PrioridadEnum.Baja => PrioridadOrdenPreparacion.Baja,
                _ => throw new Exception($"Prioridad no contemplada: {prioridad}")
            };

            var cliente = ClienteAlmacen.Clientes.FirstOrDefault(c => c.CUITCliente == ClienteSeleccionado);
            if (cliente == null)
            {
                return "No hay un cliente seleccionado.";
            }

            nuevaOrden.IDCliente = cliente.IDCliente;
            nuevaOrden.DNITransportista = dniTransportista;
            nuevaOrden.FechaEntrega = fechaEntrega;
            nuevaOrden.FechaEmision = DateTime.Now;


            foreach (var producto in ProductosAgregados)
            {
                var nuevoProductoOrden = new MercaderiaOrden();
                nuevoProductoOrden.IDMercaderia = int.Parse(producto.Id);
                nuevoProductoOrden.Cantidad = producto.Cantidad;
                nuevaOrden.MercaderiaOrden.Add(nuevoProductoOrden);


            }

            // Resta el stock de los productos
            foreach (var detalle in nuevaOrden.MercaderiaOrden)
            {
                var productoEntidad = MercaderiaAlmacen.Mercaderia.FirstOrDefault(m => m.IDMercaderia == detalle.IDMercaderia);

                if (productoEntidad == null)
                {
                    return $"El producto con ID {detalle.IDMercaderia} no existe en el stock.";
                }

                int cantidadRequerida = detalle.Cantidad;

                // Intentar descontar el stock del producto
                foreach (var stockItem in productoEntidad.Ubicaciones)
                {
                    if (stockItem.Cantidad >= cantidadRequerida)
                    {
                        stockItem.Cantidad -= cantidadRequerida;
                        cantidadRequerida = 0; // Stock suficiente, se terminó la necesidad
                        break;
                    }
                    else
                    {
                        cantidadRequerida -= stockItem.Cantidad;
                        stockItem.Cantidad = 0; // Consumir todo el stock de esta ubicación
                    }
                }

                // Si no se pudo satisfacer completamente el stock requerido, cancelar la orden
                if (cantidadRequerida > 0)
                {
                    return $"No hay suficiente stock para el producto ID {detalle.IDMercaderia}. Se necesita {cantidadRequerida} más.";
                }
            }


            string error = OrdenPreparacionAlmacen.Nueva(nuevaOrden);
            if (error != null)
            {
                return null;
            }

            // resetear los ProductosAgregados
            ProductosAgregados = [];

            // Retornar un mensaje de éxito
            return $"Orden Creada Satisfactoriamente. ID de Orden: {nuevaOrden.IDOrdenPreparacion}. Fecha de emisión: {nuevaOrden.FechaEmision:dd/MM/yyyy HH:mm}";
        }
    }
}
