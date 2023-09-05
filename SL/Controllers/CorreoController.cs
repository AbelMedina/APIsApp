using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class CorreoController : ApiController
    {
        [Route("api/correo/enviar_correo")]
        [HttpPost]
        public IHttpActionResult enviarCorreo([FromBody] ML.Email email)
        {
            ML.Result result = BL.Email.emailSender(email);
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
