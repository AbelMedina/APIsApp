using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class NotificacionController : ApiController
    {
        [Route("api/notificacion/crear")]
        [HttpPost]
        public IHttpActionResult enviarNotificacion([FromBody]ML.JsonRequest jsonRequest)
        {
            ML.Result result = BL.notificacion.RecordatorioDeTiempo(jsonRequest);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }
        }
    }
}
