using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP_CAI.Forms.Despacho.Model
{
    internal partial class DespachoModel
    {
        public class Transportista
        {
            public string Documento{ get; set; }
            public string DisplayText
            {
                get { return $"DNI: {Documento}"; }
            }

            public Transportista(string documento)
            {
                Documento = documento;

            }
        }
    }
}
