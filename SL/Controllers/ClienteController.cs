using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class ClienteController : ApiController
    {
        [Route("api/cliente/gerentesConProyecto")]
        [HttpGet]
        public IHttpActionResult gerentesConProyecto()
        {
            ML.Result result = BL.Cliente.GerenteByEstatus();
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }
        [Route("api/cliente/clientesPorGerente")]
        [HttpPost]
        public IHttpActionResult clientesPorGerente([FromBody] ML.CliGenCons cliGenCons)
        {
            ML.Result result = BL.Cliente.clientesPorGerente(cliGenCons.id_gerente);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }

        [Route("api/cliente/proyectosPorClienteGerente")]
        [HttpPost]
        public IHttpActionResult proyectosPorClienteGerente([FromBody] ML.Proporcli proporcli)
        {
            ML.Result result = BL.Cliente.proyectosPorClienteGerente(proporcli.id_gerente, proporcli.id_cliente);
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
