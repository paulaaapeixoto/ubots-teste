using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ubots.Negocio;

namespace Ubots.API.Controllers
{
    [RoutePrefix("api/Relatorio")]
    public class RelatorioController : ApiController
    {
        //1 - Liste os clientes ordenados pelo maior valor total em compras.
        [HttpPost]
        [Route("ListarClientesMaioresVendas")]
        public HttpResponseMessage ListarClientesMaioresVendas()
        {
            var relatorio = RelatorioNeg.ListarClientesMaioresVendas();

            return Request.CreateResponse(HttpStatusCode.OK, relatorio);
        }

        //2 - Mostre o cliente com maior compra única no último ano (2016).
        [HttpPost]
        [Route("ClienteMaiorCompra2016")]
        public HttpResponseMessage ClienteMaiorCompra2016()
        {
            var relatorio = RelatorioNeg.ClienteMaiorCompra2016();

            return Request.CreateResponse(HttpStatusCode.OK, relatorio);
        }

        //3- Liste os clientes mais fiéis = Compram mais indiferente do valor
        [HttpPost]
        [Route("ListarClientesFieis")]
        public HttpResponseMessage ListarClientesFieis()
        {
            var relatorio = RelatorioNeg.ListarClientesFieis();

            return Request.CreateResponse(HttpStatusCode.OK, relatorio);
        }

       // 4 - Recomende um vinho para um determinado cliente a partir do histórico de compras.
        [HttpPost]
        [Route("RecomendarVinho")]
        public HttpResponseMessage RecomendarVinho()
        {
            var relatorio = RelatorioNeg.RecomendarVinho();

            return Request.CreateResponse(HttpStatusCode.OK, relatorio);
        }
    }
}
