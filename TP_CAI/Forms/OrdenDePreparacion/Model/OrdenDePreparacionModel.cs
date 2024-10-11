using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CAI.Forms.OrdenDePreparacion.Model
{
        class OrdenDePreparacionModel
        {
            public int DniTransportista { get; set; }

            public OrdenDePreparacionModel()
            {
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
        }
    }
