using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
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

        [Route("api/periodo/meses")]
        [HttpGet]
        public IHttpActionResult Meses()
        {
            ML.Result result = BL.Periodo.Meses();
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }

        [Route("api/periodo/existePeriodo")]
        [HttpPost]
        public IHttpActionResult existePeriodo([FromBody] ML.EntradaExistePeriodo entrada)
        {
            ML.Result result = BL.Periodo.ExistePeriodo(entrada);
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

        [Route("api/periodo/registraNuevoReporte")]
        [HttpPost]
        public IHttpActionResult registraNuevoReporte([FromBody] ML.RegistrarNuevoReporte registrarNuevoReporte)
        {
            ML.Result result = BL.Tiempo.RegistrarNuevoReporte(registrarNuevoReporte);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }

        [Route("api/periodo/EliminarReporte")]
        [HttpPost]
        public IHttpActionResult EliminarReporte([FromBody] ML.EliminarReporte eliminarReporte)
        {
            ML.Result result = BL.Tiempo.EliminarReporte(eliminarReporte);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }

        [Route("api/periodo/ActualizarReporte")]
        [HttpPost]
        public IHttpActionResult ActualizarReporte([FromBody] ML.ActualizarReporte actualizarReporte)
        {
            ML.Result result = BL.Tiempo.ActualizarReporte(actualizarReporte);
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
