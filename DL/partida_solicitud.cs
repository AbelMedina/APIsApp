//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class partida_solicitud
    {
        public int id_partida_solicitud { get; set; }
        public string concepto { get; set; }
        public Nullable<decimal> monto { get; set; }
        public Nullable<int> id_solicitud_factura { get; set; }
        public Nullable<int> id_proyecto { get; set; }
        public Nullable<int> id_tipo_servicio { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public Nullable<int> usuario { get; set; }
        public Nullable<int> userupd { get; set; }
    
        public virtual solicitud_factura solicitud_factura { get; set; }
        public virtual tipo_servicio tipo_servicio { get; set; }
    }
}
