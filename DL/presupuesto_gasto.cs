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
    
    public partial class presupuesto_gasto
    {
        public int id_presupuesto_gasto { get; set; }
        public Nullable<int> presupuesto { get; set; }
        public Nullable<int> gasto { get; set; }
        public Nullable<decimal> monto { get; set; }
        public Nullable<int> area { get; set; }
    
        public virtual gasto gasto1 { get; set; }
        public virtual presupuesto presupuesto1 { get; set; }
    }
}