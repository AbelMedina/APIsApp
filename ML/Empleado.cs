using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Empleado
    {
        //public int idEmpleado { get; set; }
        public int id_tiempo { get; set; }
        public int quincena { get; set; }
        public string mes { get; set; }
        public int ano { get; set; }
        public int horas_asignables { get; set; }
        public int horas_no_asignables { get; set; }
        public int total { get; set; }
        public int envio { get; set; }
    }

    public class Emp
    {
        public string idEmpleado { get; set; }
    }
}
