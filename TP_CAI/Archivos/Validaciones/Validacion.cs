using TP_CAI.Archivos.Validaciones;

namespace TP_CAI.Archivos.Validaciones
{
    internal class Validacion<T>
    {
        public Validacion()
        { }

        public ValidacionEstados Estado { get; set; }
        public string Mensaje { get; set; }
        public T Data { get; set; }
    }
}
