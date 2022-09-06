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
    
    public partial class solicitud_factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public solicitud_factura()
        {
            this.archivo_documento_digital = new HashSet<archivo_documento_digital>();
            this.envio_correo = new HashSet<envio_correo>();
            this.partida_solicitud = new HashSet<partida_solicitud>();
        }
    
        public int id_solicitud { get; set; }
        public Nullable<int> datos { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<decimal> importe { get; set; }
        public Nullable<decimal> iva { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<int> anio { get; set; }
        public Nullable<int> mes { get; set; }
        public Nullable<int> estatus { get; set; }
        public Nullable<int> referencia { get; set; }
        public Nullable<int> tipo_cambio { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> usuario { get; set; }
        public Nullable<int> userupd { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public Nullable<int> cfdi { get; set; }
        public Nullable<int> metodo_pago { get; set; }
        public Nullable<int> forma_pago { get; set; }
        public Nullable<int> id_factura { get; set; }
        public string serie { get; set; }
        public Nullable<decimal> porcent_iva { get; set; }
        public Nullable<int> condicionada { get; set; }
        public Nullable<int> subestatus { get; set; }
        public string motivo_cancelacion { get; set; }
        public Nullable<int> id_rechazada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<archivo_documento_digital> archivo_documento_digital { get; set; }
        public virtual datos_factura datos_factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<envio_correo> envio_correo { get; set; }
        public virtual estatu estatu { get; set; }
        public virtual forma_de_pago forma_de_pago { get; set; }
        public virtual metodo_de_pago metodo_de_pago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<partida_solicitud> partida_solicitud { get; set; }
        public virtual rechazada rechazada { get; set; }
        public virtual uso_de_cfdi uso_de_cfdi { get; set; }
        public virtual tipo_cambio tipo_cambio1 { get; set; }
    }
}