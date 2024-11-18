using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TP_CAI.Forms.OrdenDePreparacion.Model.OrdenDePreparacionModel;
using TP_CAI.Almacenes;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.ConsultaStock.Model
{
    internal class ConsultaStockModel
    {
        public string ClienteSeleccionado { get; set; }

        public List<Stock> StockProductos
        {
            get
            {
                var clienteEntidad = ClienteAlmacen.Clientes.FirstOrDefault(c => c.CUITCliente == ClienteSeleccionado);
                if (clienteEntidad == null)
                {
                    return new List<Stock>();
                }

                var productosCliente = new List<Stock>();

                foreach (var productoEntidad in MercaderiaAlmacen.Mercaderia)
                {
                    if (productoEntidad.IDCliente == clienteEntidad.IDCliente)
                    {
                        if (productoEntidad.CalcularTotalStockSinDeposito() == 0)
                        {
                            continue; // No incluir productos sin stock
                        }

                        foreach (var ubicacion in productoEntidad.Ubicaciones)
                        {
                            // Crear una nueva instancia de Stock para cada ubicación
                            var productoModelo = new Stock
                            {
                                Id = productoEntidad.IDMercaderia,
                                Cantidad = productoEntidad.CalcularTotalStockSinDeposito(),
                                Descripcion = productoEntidad.DescripcionMercaderia,
                                Ubicacion = ubicacion.Ubicacion
                            };

                            Deposito deposito = new Deposito();
                            DepositoEntidad depositoEntidad = DepositosAlmacen.ObtenerDepositoPorId(ubicacion.IDDeposito);
                            deposito.Id = depositoEntidad.IDDeposito;
                            deposito.Direccion = depositoEntidad.Direccion;

                            productoModelo.Deposito = deposito.DisplayText;

                            // Agregar el modelo único a la lista
                            productosCliente.Add(productoModelo);
                        }
                    }
                }

                // Ordenar por depósito antes de retornar
                return productosCliente.OrderBy(p => p.Deposito).ToList();
            }
        }

        public List<Cliente> Clientes { get; private set; }
        public List<Deposito> Depositos { get; private set; }

        public ConsultaStockModel()
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
    }
}
