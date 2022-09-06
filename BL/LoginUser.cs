using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class LoginUser
    {
        public static ML.Result LoginUsr(int num_empleado, string pwd)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.Loginuser(num_empleado,pwd).FirstOrDefault();
                    if (query != null)
                    {
                        if (query.estado == 1)
                        {
                            result.Object = new List<object>();
                            ML.LoginData loginData = new ML.LoginData();
                            loginData.id_empleado = query.id_empleado;
                            loginData.num_empleado = int.Parse(query.num_empleado);
                            loginData.nom_empleado = query.nom_empleado;
                            loginData.apellido = query.apellido;
                            loginData.nom_departamento = query.nom_departamento;
                            loginData.email = query.email;
                            result.Object = loginData;
                            result.Correct = true;
                        }
                        else if (query.estado == 0)
                        {
                            result.Correct = true;
                            result.ErrorMessage = "Usuario Inactivo";
                        }
                    }
                    else
                    {
                        result.Correct = true;
                        result.ErrorMessage = "Error de inicio de sesion, favor de revisar sus credenciales";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex= ex;
            }
            return result;
        }
    }
}
