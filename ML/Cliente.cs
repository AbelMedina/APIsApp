using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ML
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Abierto { get; set; }
    }

    public class ClienteGerente
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public int Abierto { get; set; }
    }

    public class CliGenCons
    {
        public int id_gerente { get; set; }
    }


    public class ClienteGerenteProyecto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }

    public class Proporcli
    {
        public int id_gerente { get; set; }
        public int id_cliente { get; set; }
    }
}
