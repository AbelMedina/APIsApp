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
            Thread.Sleep(TimeSpan.FromSeconds(10));
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
    }
}
