using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CAI.Forms.ConsultaStock.Model
{
    internal class Stock
    {
        public int Id{ get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Ubicacion{ get; set; }
        public string Deposito { get; set; }
    }
}
