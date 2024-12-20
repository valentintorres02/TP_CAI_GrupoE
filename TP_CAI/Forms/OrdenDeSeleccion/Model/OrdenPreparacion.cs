﻿using TP_CAI.Almacenes;

namespace TP_CAI.Forms.OrdenDeSeleccion.Forms.Model
{
    // Clase que representa una orden de preparación
    public class OrdenPreparacion
    {
        public int Id { get; set; }
        public string DocumentoCliente{ get; set; }
        public string NombreCliente{ get; set; }
        public int DNITransportista { get; set; }
        public PrioridadOrdenPreparacion Prioridad { get; set; }
        public EstadoOrdenPreparacion Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEntrega { get; set; }

        public OrdenPreparacion(int id, string documentoCliente, string nombreCliente, int dniTransportista, PrioridadOrdenPreparacion prioridad, EstadoOrdenPreparacion estado, DateTime fechaEntrega)
        {
            Id = id;
            DocumentoCliente = documentoCliente;
            NombreCliente = nombreCliente;
            DNITransportista = dniTransportista;
            Prioridad = prioridad;
            Estado = estado;
            FechaEmision = DateTime.Now;
            FechaEntrega = fechaEntrega;
        }
    }
}
