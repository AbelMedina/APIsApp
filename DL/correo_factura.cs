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
    
    public partial class correo_factura
    {
        public int id_correo { get; set; }
        public Nullable<int> datos { get; set; }
        public string correo { get; set; }
        public Nullable<int> userupd { get; set; }
        public Nullable<System.DateTime> stamp { get; set; }
        public Nullable<int> dirigido { get; set; }
    
        public virtual datos_factura datos_factura { get; set; }
    }
}
