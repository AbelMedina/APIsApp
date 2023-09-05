using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Dispositivo
    {
        public static ML.Result RegistraDispositivo(ML.Dispositivo dispositivo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.Registraoactualizadispositivo(dispositivo.Token, dispositivo.IdDispositivo, dispositivo.IdEmpleado, dispositivo.SistemaOperativo, dispositivo.VersionSO, dispositivo.Manufactura);
                    if (query  >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        throw new ArgumentException("Error al procesar la petición");
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result EliminarDispositivo(string IdDispositivo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.EliminaDispositivo(IdDispositivo);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        throw new ArgumentException("No se ha podido eliminar el dispositivo o este no existe.");
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
