using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
   public class Dispositivo
    {
        public string Token { get; set; }
        public string IdDispositivo { get; set; }
        public int IdEmpleado { get; set; }
        public string SistemaOperativo { get; set; }
        public string VersionSO { get; set; }
        public string Manufactura { get; set; }
    }

    public class EliminarDispositivo
    {
        public string IdDispositivo { get; set; }
    }
}
