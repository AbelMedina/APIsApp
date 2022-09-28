using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace SL.Controllers
{
    public class ActividadController : ApiController
    {
        [Route("api/actividad/actividadesPorEmpleado")]
        [HttpPost]
        public IHttpActionResult actividadesPorEmpleado([FromBody] ML.ActividadEmpleado actividadEmpleado)
        {
            ML.Result result = BL.Actividad.actividadesPorEmpleado(int.Parse(actividadEmpleado.IdEmpleado));
            //Thread.Sleep(TimeSpan.FromSeconds(10));
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
