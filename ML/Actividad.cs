using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Actividad
    {
        public int IdActividad { get; set; }
        public string NomActividad { get; set; }
        public string Descripcion { get; set; }
    }

    public class ActividadEmpleado
    {
        public string IdEmpleado { get; set; }
    }

    public class HorasPorActividad
    {
        public int IdActividad { get; set; }
        public string IdEmpleado { get; set; }
    }

    public class ResultadoHorasPorActividad
    {
        public int horas { get; set; }
    }
}
