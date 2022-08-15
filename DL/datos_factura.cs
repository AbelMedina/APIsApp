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
    
    public partial class datos_factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public datos_factura()
        {
            this.archivo_factura = new HashSet<archivo_factura>();
            this.correo_factura = new HashSet<correo_factura>();
            this.solicitud_factura = new HashSet<solicitud_factura>();
        }
    
        public int id_datos { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string concepto { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> recurrente { get; set; }
        public Nullable<int> estatus { get; set; }
        public Nullable<int> usuario { get; set; }
        public Nullable<int> userupd { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public Nullable<int> trabajo_finalizado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<archivo_factura> archivo_factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<correo_factura> correo_factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitud_factura> solicitud_factura { get; set; }
    }
}
