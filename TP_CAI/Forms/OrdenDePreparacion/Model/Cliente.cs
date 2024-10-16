﻿namespace TP_CAI.Forms.OrdenDePreparacion.Model
{
    partial class OrdenDePreparacionModel
    {
        public class Cliente
        {
            public string Documento { get; set; }
            public string Nombre { get; set; }
            public string DisplayText
            {
                get { return $"CUIT/CUIL: {Documento}. Nombre: {Nombre}"; }
            }
        }
    }
}
