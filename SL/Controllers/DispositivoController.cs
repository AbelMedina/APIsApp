using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class DispositivoController : ApiController
    {
        [Route("api/dispositivo/registrar")]
        [HttpPost]
        public IHttpActionResult Registrar([FromBody]ML.Dispositivo dispositivo)
        {
            ML.Result result = BL.Dispositivo.RegistraDispositivo(dispositivo);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, result);
            }
        }

        [Route("api/dispositivo/eliminar")]
        [HttpPost]
        public IHttpActionResult Eliminar([FromBody]ML.EliminarDispositivo dispositivo)
        {
            ML.Result result = BL.Dispositivo.EliminarDispositivo(dispositivo.IdDispositivo);
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
