using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;

namespace TP_CAI.Forms.OrdenDePreparacion.Model
{
    partial class OrdenDePreparacionModel
    {

        public int DniTransportista { get; set; }
        public List<Producto> ProductosIniciales { get; private set; }
        public List<Producto> ProductosDisponibles { get; private set; }
        public List<Producto> ProductosAgregados { get; private set; }
        public List<Cliente> Clientes { get; private set; }
        public List<Deposito> Depositos{ get; private set; }

        public OrdenDePreparacionModel()
        {
            ProductosIniciales = new List<Producto>
    {
        new Producto { Id = "001", Descripcion = "Producto A", Cantidad = 10 },
        new Producto { Id = "002", Descripcion = "Producto B", Cantidad = 20 },
        new Producto { Id = "003", Descripcion = "Producto C", Cantidad = 15 },
        new Producto { Id = "004", Descripcion = "Producto D", Cantidad = 25 },
        new Producto { Id = "005", Descripcion = "Producto E", Cantidad = 30 }
    };
            ProductosDisponibles = new List<Producto>(ProductosIniciales);
            ProductosAgregados = new List<Producto>();

            Clientes = new List<Cliente>
            {
                new Cliente { Documento = "20-44444444-4", Nombre = "CAI S.R.L" },
                new Cliente { Documento = "20-34506467-4", Nombre = "GrupoE S.A" },
                new Cliente { Documento = "20-65930234-4", Nombre = "Fravega S.R.L" },
                new Cliente { Documento = "20-42104211-4", Nombre = "Amazon S.A" },
            };

            Depositos = new List<Deposito>
            {
                new Deposito { Id = 1, Direccion = "Av. Cordoba 2100, CABA" },
                new Deposito { Id= 2, Direccion = "Belgrano 120, CABA" },
                new Deposito { Id = 3, Direccion = "Rivadavia 1100, Cordoba Capital" },
                new Deposito { Id = 4, Direccion = "Av. Pueyrredon 1100, CABA" },
            };
        }

        public string? ValidarDniTransportista(string dniText)
        {
            bool isDniCompleto = !string.IsNullOrWhiteSpace(dniText);

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
            if(documentoCliente == null || documentoCliente == "")
            {
                return "Por favor seleccione un cliente valido.";
            }

            return null;
        }

        public string? ValidarDeposito(string idDepositoOpcion)
        {
            if (idDepositoOpcion == null || idDepositoOpcion == "")
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

        private bool IsDateValid(DateTime selectedDate)
        {
            // Comparar con la fecha actual
            return selectedDate >= DateTime.Today;
        }

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
            string errorCantidad = ValidarCantidades(cantidad1, cantidad2, descripcion, cantidad2.ToString());
            if (errorCantidad != null)
            {
                return errorCantidad; // Retornar el error si hay uno
            }

            // Agregar el producto a la lista de ProductosAgregados
            Producto producto = new Producto
            {
                Id = id,
                Descripcion = descripcion,
                Cantidad = cantidad1
            };

            ProductosAgregados.Add(producto);
            Producto productoDisponible = ProductosDisponibles.FirstOrDefault(p => p.Id == id);
            ProductosDisponibles.Remove(productoDisponible);
            return null; // Sin errores
        }

        public void EliminarProducto(string id)
        {
            Producto producto = ProductosAgregados.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                ProductosAgregados.Remove(producto);


                Producto productoInicial = ProductosIniciales.FirstOrDefault(p => p.Id == id);

                if(productoInicial != null)
                {
                ProductosDisponibles.Add(productoInicial);
                }
            }
        }

        public void EliminarTodosLosProductos()
        {
            ProductosDisponibles = new List<Producto>(ProductosIniciales);
            ProductosAgregados = new List<Producto>();

        }

        public string CrearOrden(string documentoCliente, string nombreCliente, int dniTransportista, PrioridadEnum prioridad)
        {
            // Generar un ID único 
            int nuevoId = 1;

            // Crear una nueva instancia de OrdenPreparacion
            var nuevaOrden = new OrdenPreparacion(nuevoId, documentoCliente, nombreCliente, dniTransportista, prioridad, EstadoOrdenPreparacionEnum.Pendiente);

            // Retornar un mensaje de éxito
            return $"Orden Creada Satisfactoriamente. ID de Orden: {nuevaOrden.Id}. Fecha de emisión: {nuevaOrden.FechaEmision.ToString("dd/MM/yyyy HH:mm")}";
        }
    }
}
