
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace SL.Controllers
{
    public class EmpleadoController : ApiController
    {
        [Route("api/empleado/reportes")]
        [HttpPost]
        public IHttpActionResult ReportesByIdEmpleado([FromBody] ML.Emp emp)
        {
            ML.Result result = BL.Empleado.ReportesByIdEmpleado(int.Parse(emp.idEmpleado));
            Thread.Sleep(TimeSpan.FromSeconds(5));
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
