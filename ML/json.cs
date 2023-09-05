using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class body
    {
        public string to { get; set; }
        public ML.notification notification { get; set; }
        public bool content_available { get; set; }
        public string priority { get; set; }
        public ML.data data { get; set; }
    }

    public class data
    {
        public bool existeNotificacion { get; set; }
        public ML.dataNotificacion dataNotificacion { get; set; }

    }

    public class dataNotificacion
    {
        public object ExtensionData { get; set; }
        public ML.periodo periodo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int IdTiempo { get; set; }
        public int Leido { get; set; }
        public string Mensaje { get; set; }
        public string Tipo { get; set; }
        public string Titulo { get; set; }
    }

    public class notification
    {
        public string title { get; set; }
        public string body { get; set; }
        public string sound { get; set; }
        public string icon { get; set; }
        public string color { get; set; }
        public string badge { get; set; }
    }

    public class JsonRequest
    {
        public string to { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public ML.periodo periodo { get; set; }
        public int leido { get; set; }
        public string mensaje { get; set; }
        public string tipo { get; set; }
        public string titulo { get; set; }
    }

    public class periodo
    {
        public int quincena { get; set; }
        public string mes { get; set; }
        public int anio { get; set; }
    }

}
