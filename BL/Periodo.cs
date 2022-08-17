using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Periodo
    {
        public static ML.Result Anios()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context  = new DL.administracionEntities())
                {
                    var query = context.Anios().ToList();
                    result.Objects = new List<object>();
                    if (query.Count!=0)
                    {
                        foreach (var obj in query)
                        {
                            ML.Periodo periodo = new ML.Periodo();
                            periodo.Año = obj.Value;
                            result.Objects.Add(periodo);
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
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }
            return result;
        }
    }
}
