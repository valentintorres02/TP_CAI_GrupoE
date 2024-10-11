﻿using System;
using System.Collections.Generic;
using System.Linq;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.OrdenDePreparacion.Model
{

    class OrdenDePreparacionModel
    {
        public int DniTransportista { get; set; }
        public List<Producto> ProductosDisponibles { get; private set; }
        public List<Producto> ProductosAgregados { get; private set; }

        public OrdenDePreparacionModel()
        {
            ProductosDisponibles = new List<Producto>
    {
        new Producto { Id = "001", Descripcion = "Producto A", Cantidad = 10 },
        new Producto { Id = "002", Descripcion = "Producto B", Cantidad = 20 },
        new Producto { Id = "003", Descripcion = "Producto C", Cantidad = 15 },
        new Producto { Id = "004", Descripcion = "Producto D", Cantidad = 25 },
        new Producto { Id = "005", Descripcion = "Producto E", Cantidad = 30 }
    };
            ProductosAgregados = new List<Producto>();
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

        public string? ValidarCantidades(int cantidad1, int cantidad2, string descripcion, string cantidadItem)
        {
            if (cantidad1 < 1 && cantidad2 == null)
            {
                return "No pueden agregarse a la órden de preparación " + cantidad1 + " unidades del producto " + descripcion + " ya que debe ser igual o superior a 1. Por favor intente con un valor igual o menor a " + cantidadItem + " pero mayor que 0.";
            }

            if (cantidad1 > cantidad2)
            {
                return "No pueden agregarse a la órden de preparación " + cantidad1 + " unidades del producto " + descripcion + " ya que solo se cuentan con " + cantidadItem + " unidades. Por favor intente con un valor igual o menor a " + cantidadItem;
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
                // Eliminar el producto de la lista de agregados
                ProductosAgregados.Remove(producto);

                // Buscar el producto en la lista de disponibles
                var productoDisponible = ProductosDisponibles.FirstOrDefault(p => p.Id == id);
                if (productoDisponible != null)
                {
                    // Aumentar la cantidad disponible
                    productoDisponible.Cantidad += producto.Cantidad; // Regresar la cantidad al stock
                }
                else
                {
                    // Si no existe, agregar un nuevo producto disponible con la cantidad
                    ProductosDisponibles.Add(new Producto
                    {
                        Id = producto.Id,
                        Descripcion = producto.Descripcion,
                        Cantidad = producto.Cantidad // Regresar la cantidad al stock
                    });
                }
            }
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
