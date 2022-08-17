using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class PeriodoController : ApiController
    {
        [Route("api/periodo/anios")]
        [HttpGet]
        public IHttpActionResult Anios()
        {
            ML.Result result = BL.Periodo.Anios();
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
