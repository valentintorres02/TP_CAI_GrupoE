namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {
        public class OrdenDespacho
        {
            public string Id { get; set; }
            public string NumeroIdentificacion { get; set; }
            public string Cliente { get; set; }
            public string Codigo { get; set; }
            public string Categoria { get; set; }
            public string Estado { get; set; }

            public OrdenDespacho(string id, string numeroIdentificacion, string cliente, string codigo, string categoria, string estado)
            {
                Id = id;
                NumeroIdentificacion = numeroIdentificacion;
                Cliente = cliente;
                Codigo = codigo;
                Categoria = categoria;
                Estado = estado;
            }
        }
    }
}
