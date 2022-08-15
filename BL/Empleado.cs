using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Empleado
    {
        public static ML.Result ReportesByIdEmpleado(int idEmpleado)
        {
            ML.Result result = new ML.Result();
            try
            {
                int reg = 0;
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.ReportesByIdEmpleado(idEmpleado).ToList();
                    result.Objects = new List<object>();
                    if (query.Count != 0)
                    {
                        foreach (var obj in query)
                        {
                            reg++;
                            ML.Empleado empleado = new ML.Empleado();
                            empleado.id_tiempo = obj.id_tiempo.Value;
                            empleado.quincena = obj.quincena.Value;
                            empleado.mes = obj.mes;
                            empleado.ano = obj.ano.Value;
                            empleado.horas_asignables = obj.horas_asignables.Value;
                            empleado.horas_no_asignables = obj.horas_no_asignables.Value;
                            empleado.total = obj.total.Value;
                            empleado.envio = obj.envio.Value;
                            result.Objects.Add(empleado);
                            if (reg == 10)
                            {
                                break;
                            }
                            
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = true;
                        //result.ErrorMessage = "Sin datos registrados.";
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
