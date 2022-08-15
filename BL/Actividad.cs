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
    }
}
