using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Actividad
    {
        public static ML.Result actividadesPorEmpleado(int idEmpleado)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.actividadesPorEmpleado(idEmpleado).ToList();
                    result.Objects = new List<object>();
                    if (query.Count != 0)
                    {
                        foreach (var obj in query)
                        {
                            ML.Actividad actividad = new ML.Actividad();
                            actividad.IdActividad = obj.id_actividad;
                            actividad.NomActividad = obj.nom_actividad;
                            actividad.Descripcion = obj.descripcion;
                            result.Objects.Add(actividad);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = true;
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

        public static ML.Result HorasPorActividad(ML.HorasPorActividad horasPorActividad)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.HorasPorActividad(horasPorActividad.IdActividad, horasPorActividad.IdEmpleado).FirstOrDefault();
                    if (query != null)
                    {
                        result.Object = new List<object>();
                        ML.ResultadoHorasPorActividad resultado = new ML.ResultadoHorasPorActividad();
                        resultado.horas = int.Parse(query);
                        result.Object = resultado;
                        result.Correct = true;
                    }
                    else
                    {
                        throw new ArgumentException("No se encontraron datos");
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
