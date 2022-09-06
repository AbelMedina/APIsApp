using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Periodo
    {
        public int Año { get; set; }
    }

    public class Meses
    {
        public int ID { get; set; }
        public String Mes { get; set; }
    }

    public class ExistePeriod
    {
        public int ExistePeriodo { get; set; }
    }

    public class EntradaExistePeriodo
    {
        public String quincena { get; set; }
        public String mes { get; set; }
        public int anio { get; set; }
        public int empleado { get; set; }
    }
}
