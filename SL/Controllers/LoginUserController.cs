using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;

namespace SL.Controllers
{
    //[AllowAnonymous]
    public class LoginUserController : ApiController
    {
        [Route("api/empleado/login")]
        [HttpPost]
        public IHttpActionResult LoginUser([FromBody] ML.Login login)
        {
            ML.Result result = BL.LoginUser.LoginUsr(login.num_empleado, login.pwd);
            //Thread.Sleep(TimeSpan.FromSeconds(10));
            if (result.Correct && result.ErrorMessage is null)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else if (result.Correct && result.ErrorMessage.Equals("Error de inicio de sesion, favor de revisar sus credenciales"))
            {
                return Content(HttpStatusCode.Unauthorized, result);
            }
            else if(result.Correct && result.ErrorMessage.Equals("Usuario Inactivo")) 
            {
                return Content(HttpStatusCode.Forbidden, result);
            }
            else
            {
                    return Content(HttpStatusCode.NotFound, result);
            }
        }

        [Route("api/empleado/ImgInsertOrUpdate")]
        [HttpPost]
        public IHttpActionResult ImgInsertOrUpdate([FromBody] ML.ImgInsertOrUpdate imgInsertOrUpdate)
        {
            ML.Result result = BL.LoginUser.ImgInsertOrUpdate(imgInsertOrUpdate);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }

        [Route("api/empleado/ImgDelete")]
        [HttpPost]
        public IHttpActionResult ImgDelete([FromBody] ML.ImgDelete imgDelete)
        {
            ML.Result result = BL.LoginUser.DeleteImg(imgDelete);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }

        [Route("api/empleado/ActualizaContrasena")]
        [HttpPost]
        public IHttpActionResult ActualizaContrasena([FromBody] ML.Login login)
        {
            ML.Result result = BL.LoginUser.ActualizaContrasena(login);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }

        [Route("api/empleado/ExisteCorreo")]
        [HttpPost]
        public IHttpActionResult ExisteCorreo([FromBody] ML.ExisteCorreo existeCorreo)
        {
            ML.Result result = BL.LoginUser.ExisteCorreo(existeCorreo);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }

    }
}
