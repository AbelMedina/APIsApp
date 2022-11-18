using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class TiempoController : ApiController
    {
        [Route("api/tiempo/reporte")]
        [HttpPost]
        public IHttpActionResult ReporteByIdTiempo([FromBody] ML.Tiemp tiemp)
        {
            ML.Result result = BL.Tiempo.ReporteByIdTiempo(int.Parse(tiemp.idTiempo));
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }

        [Route("api/tiempo/horasNoAsignables")]
        [HttpPost]
        public IHttpActionResult horasNoAsignables([FromBody] ML.Tiemp tiemp)
        {
            ML.Result result = BL.Tiempo.horasNoAsignables(int.Parse(tiemp.idTiempo));
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }
        [Route("api/tiempo/reportePorEmpleado")]
        [HttpPost]
        public IHttpActionResult reportePorEmpleado([FromBody] ML.Tiemp tiemp)
        {
            ML.Result result = BL.Tiempo.reportePorEmpleado(int.Parse(tiemp.idTiempo));
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }
        [Route("api/tiempo/EliminaHoraNoAsignable")]
        public IHttpActionResult EliminaHoraNoAsignable([FromBody]ML.EliminaHoraNoAsignable eliminaHoraNoAsignable)
        {
            ML.Result result = BL.Tiempo.EliminaHoraNoAsignable(eliminaHoraNoAsignable);
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
