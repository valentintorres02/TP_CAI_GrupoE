using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using TP_CAI.Forms.Empaquetado.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.OrdenDeEntrega.Model
{

    internal partial class OrdenDeEntregaModel
    {

        public List<OrdenPreparacion> OrdenesDePreparacion{ get; private set; }

        public OrdenDeEntregaModel()
        {
            OrdenesDePreparacion = new List<OrdenPreparacion>
            {
               new OrdenPreparacion(019, "20-44444444-4", "GrupoE S.R.L", 35012345, PrioridadEnum.Baja, EstadoOrdenPreparacionEnum.Preparada, DateTime.Now),
               new OrdenPreparacion(025, "20-44444444-4", "C.A.I S.A", 35012345, PrioridadEnum.Media, EstadoOrdenPreparacionEnum.Preparada, DateTime.Now),
               new OrdenPreparacion(034, "20-44444444-4", "Grupo-Z S.A", 35012345, PrioridadEnum.Alta, EstadoOrdenPreparacionEnum.Preparada, DateTime.Now),
               new OrdenPreparacion(055, "20-44444444-4", "Molinos S.R.L", 35012345, PrioridadEnum.Alta, EstadoOrdenPreparacionEnum.Preparada, DateTime.Now)
            };
        }

        public void CrearOrdenEntrega()
        {
            if(OrdenesDePreparacion.Count == 0)
            {
                MessageBox.Show("Debe haber al menos una orden de preparacion para crear una orden de entrega");
                return;
            }

            var ordenEntrega = new OrdenEntrega(1, "20-44444444");

            MessageBox.Show("Se registró correctamente la orden de entrega ID " + ordenEntrega.Id);
            OrdenesDePreparacion = new List<OrdenPreparacion>();
        }
    }
}
