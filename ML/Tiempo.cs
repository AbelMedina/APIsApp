using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Tiempo
    {
        public int IDHoraAsignable { get; set; }
        public int IDProyecto { get; set; }
        public string Clave { get; set; }
        public int uno { get; set; }
        public int dos { get; set; }
        public int tres { get; set; }
        public int  cuatro { get; set; }
        public int cinco { get; set; }
        public int seis { get; set; }
        public int siete { get; set; }
        public int ocho { get; set; }
        public int nueve { get; set; }
        public int diez { get; set; }
        public int once { get; set; }
        public int doce { get; set; }
        public int trece { get; set; }
        public int catorce { get; set; }
        public int quince { get; set; }
        public int diezyseis { get; set; }
        public int Total { get; set; }
        public string Cliente { get; set; }
        public string Gerente { get; set; }
        public decimal cuota { get; set; }
        public decimal costo { get; set; }
        public decimal totalCuota { get; set; }
        public decimal totalCosto { get; set; }
        public int idCliente { get; set; }
        public int idGerente { get; set; }
    }

    public class Tiemp
    {
        public string idTiempo { get; set; }
    }

    public class TiempoNoAsignable
    {
        public int IDHoraNoAsignable { get; set; }
        public int IDActividad { get; set; }
        public string NomActividad { get; set; }
        public int uno { get; set; }
        public int dos { get; set; }
        public int tres { get; set; }
        public int cuatro { get; set; }
        public int cinco { get; set; }
        public int seis { get; set; }
        public int siete { get; set; }
        public int ocho { get; set; }
        public int nueve { get; set; }
        public int diez { get; set; }
        public int once { get; set; }
        public int doce { get; set; }
        public int trece { get; set; }
        public int catorce { get; set; }
        public int quince { get; set; }
        public int diezyseis { get; set; }
        public int Total { get; set; }
        public decimal cuota { get; set; }
        public decimal costo { get; set; }
        public decimal totalCuota { get; set; }
        public decimal totalCosto { get; set; }
        public string descripcion { get; set; }
    }
}
