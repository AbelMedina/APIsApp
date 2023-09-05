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
                    var query = context.Loginuser(num_empleado, pwd).FirstOrDefault();
                    if (query != null)
                    {
                        if (query.estado == 1)
                        {
                            result.Object = new List<object>();
                            ML.LoginData loginData = new ML.LoginData();
                            loginData.id_empleado = query.id_empleado;
                            loginData.num_empleado = query.num_empleado;
                            loginData.nom_empleado = query.nom_empleado;
                            loginData.apellido = query.apellido;
                            loginData.NombreCompleto = query.NombreCompleto;
                            loginData.email = query.email;
                            loginData.nom_departamento = query.nom_departamento;
                            loginData.cuota = query.cuota.Value;
                            loginData.costo = query.costo.Value;
                            loginData.ProfilePicture = query.ProfilePicture;
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
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result ImgInsertOrUpdate(ML.ImgInsertOrUpdate imgInsertOrUpdate)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.InsertOrUpdateIMG(imgInsertOrUpdate.id_empleado, imgInsertOrUpdate.ProfilePicture);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        throw new ArgumentException("No se ha encontrado al empleado");
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

        public static ML.Result DeleteImg(ML.ImgDelete imgDelete)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.DeleteImg(imgDelete.id_empleado);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        throw new ArgumentException("No se ha podido eliminar la imagen del empleado o no se ha encontrado al empleado");
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

        public static ML.Result ActualizaContrasena(ML.Login login)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.ActualizaContrasena(login.num_empleado, login.pwd);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        throw new ArgumentException("No se ha podido actualizar la contraseña");
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

        public static ML.Result ExisteCorreo(ML.ExisteCorreo existeCorreo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.ExisteCorreo(existeCorreo.Email).FirstOrDefault();
                    if (query != null)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontro el correo";
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
