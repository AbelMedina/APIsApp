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
    
    public partial class cuota
    {
        public int id_cuota { get; set; }
        public Nullable<decimal> cuota1 { get; set; }
        public Nullable<decimal> costo { get; set; }
        public Nullable<int> area { get; set; }
        public Nullable<int> nivel { get; set; }
        public Nullable<int> ano { get; set; }
        public Nullable<int> estatus { get; set; }
        public Nullable<int> usuario { get; set; }
        public Nullable<int> userupd { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
    
        public virtual departamento departamento { get; set; }
        public virtual nivel nivel1 { get; set; }
    }
}