namespace TP_CAI.Forms.GestionOrdenSeleccion.Model
{
    public class Producto
        {
            public string Ubicacion { get; set; }
            public int Cantidad {  get; set; }
            public string IdProducto { get; set; }
            public string DescripcionProducto { get; set; }

            public Producto(string ubicacion, int cantidad, string idProducto, string descripcionProducto)
            {
                Ubicacion = ubicacion;
                Cantidad = cantidad;
                IdProducto = idProducto;
                DescripcionProducto = descripcionProducto;
            }
        }

}
