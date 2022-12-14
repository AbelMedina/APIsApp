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
    
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            this.contactoes = new HashSet<contacto>();
            this.presupuestoes = new HashSet<presupuesto>();
            this.proyectoes = new HashSet<proyecto>();
        }
    
        public int id_cliente { get; set; }
        public string nom_cliente { get; set; }
        public string clave_cliente { get; set; }
        public string calle { get; set; }
        public string colonia { get; set; }
        public string ciudad { get; set; }
        public string cp { get; set; }
        public Nullable<int> grupo { get; set; }
        public string rfc { get; set; }
        public string telefono { get; set; }
        public Nullable<int> tasa_iva { get; set; }
        public string aplicar_iva { get; set; }
        public Nullable<int> dias_credito { get; set; }
        public string horario_cobro { get; set; }
        public string observaciones { get; set; }
        public string giro_empresa { get; set; }
        public Nullable<int> sector { get; set; }
        public Nullable<System.DateTime> fecha_baja_alta { get; set; }
        public Nullable<int> estatus { get; set; }
        public Nullable<int> vulnerable { get; set; }
        public Nullable<int> usuario { get; set; }
        public Nullable<int> userupd { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public Nullable<int> id_zona { get; set; }
        public Nullable<int> id_concepto { get; set; }
    
        public virtual grupo_clientes grupo_clientes { get; set; }
        public virtual iva iva { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contacto> contactoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<presupuesto> presupuestoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proyecto> proyectoes { get; set; }
    }
}
