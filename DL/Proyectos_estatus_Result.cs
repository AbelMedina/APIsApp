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
    
    public partial class Proyectos_estatus_Result
    {
        public int ID { get; set; }
        public string Clave_Proyecto { get; set; }
        public int ID_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public Nullable<System.DateTime> Fecha_Inicio { get; set; }
        public int ID_Socio { get; set; }
        public string Socio { get; set; }
        public int ID_Gerente { get; set; }
        public string Gerente { get; set; }
        public Nullable<int> ID_Área { get; set; }
        public string Área { get; set; }
        public Nullable<System.DateTime> Fecha_Final_Estimada { get; set; }
        public string Carga_de_Tiempo { get; set; }
        public string Estatus { get; set; }
    }
}
