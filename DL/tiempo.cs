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
    
    public partial class tiempo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tiempo()
        {
            this.hora_no_asignable = new HashSet<hora_no_asignable>();
        }
    
        public int id_tiempo { get; set; }
        public Nullable<int> quincena { get; set; }
        public string mes { get; set; }
        public Nullable<int> ano { get; set; }
        public Nullable<int> horas_asignables { get; set; }
        public Nullable<int> horas_no_asignables { get; set; }
        public Nullable<int> total { get; set; }
        public Nullable<int> empleado { get; set; }
        public Nullable<int> estatus { get; set; }
        public Nullable<int> envio { get; set; }
        public Nullable<int> usuario { get; set; }
        public Nullable<int> userupd { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_reporte { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hora_no_asignable> hora_no_asignable { get; set; }
    }
}
