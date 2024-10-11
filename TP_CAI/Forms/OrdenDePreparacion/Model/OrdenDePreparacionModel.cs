using System;
using System.Collections.Generic;
using System.Linq;

namespace TP_CAI.Forms.OrdenDePreparacion.Model
{

    class OrdenDePreparacionModel
    {
        public int DniTransportista { get; set; }
        public List<Producto> ProductosDisponibles { get; private set; }
        public List<Producto> ProductosAgregados { get; private set; }

        public OrdenDePreparacionModel()
        {
            ProductosDisponibles = new List<Producto>();
            ProductosAgregados = new List<Producto>();
        }

        public string? ValidarDniTransportista(string dniText)
        {
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

        public string? ValidarCantidades(int cantidad1, int cantidad2, string descripcion, string cantidadItem)
        {
            if (cantidad1 < 1 && cantidad2 == null)
            {
                return "No pueden agregarse a la órden de preparación " + cantidad1 + " unidades del producto " + descripcion + " ya que debe ser igual o superior a 1. Por favor intente con un valor igual o menor a " + cantidadItem + " pero mayor que 0.";
            }

            if (cantidad1 > cantidad2)
            {
                MessageBox.Show("No pueden agregarse a la órden de preparación " + cantidad1 + " unidades del producto " + descripcion + " ya que solo se cuentan con " + cantidadItem + " unidades. Por favor intente con un valor igual o menor a " + cantidadItem);
                return "No pueden agregarse a la órden de preparación " + cantidad1 + " unidades del producto " + descripcion + " ya que solo se cuentan con " + cantidadItem + " unidades. Por favor intente con un valor igual o menor a " + cantidadItem;
            }

            return null;
        }

        public void AgregarProducto(string id, string descripcion, int cantidad)
        {
            var producto = ProductosDisponibles.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                ProductosDisponibles.Remove(producto);
                ProductosAgregados.Add(new Producto { Id = id, Descripcion = descripcion, UnidadesDisponibles = cantidad });
            }
        }

        public void EliminarProducto(string id)
        {
            var producto = ProductosAgregados.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                ProductosAgregados.Remove(producto);
                ProductosDisponibles.Add(producto); // Regresar el producto a la lista de disponibles
            }
        }

        public ListViewItem[] CargarElementos()
        {
            // Crear un array de ListViewItem
            ListViewItem[] elementos = new ListViewItem[3];

            // Inicializar los elementos
            elementos[0] = new ListViewItem(new[] { "1", "Remeras", "10" });
            elementos[1] = new ListViewItem(new[] { "2", "Zapatillas", "20" });
            elementos[2] = new ListViewItem(new[] { "3", "Pantalones", "30" });

            // Devolver el array de ListViewItem
            return elementos;
        }

        public void CargarElementosDisponibles()
        {
            this.ProductosDisponibles.Add(new Producto { Id = "1", Descripcion = "Remeras", UnidadesDisponibles = 10 });
            this.ProductosDisponibles.Add(new Producto { Id = "2", Descripcion = "Zapatillas", UnidadesDisponibles = 20 });
            this.ProductosDisponibles.Add(new Producto { Id = "3", Descripcion = "Pantalones", UnidadesDisponibles = 30 });
        }
    }
}
