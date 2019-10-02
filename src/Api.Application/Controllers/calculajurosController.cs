using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("[controller]/{valorInicial}/{meses}")]
    [ApiController]
    public class calculajurosController : ControllerBase
    {
        ICalculaJurosService _CalculaJurosService;
        ITaxaJuros _taxaJuros;

        public calculajurosController(ICalculaJurosService calculaJurosService, ITaxaJuros taxaJuros)
        {
            _CalculaJurosService = calculaJurosService;
            _taxaJuros = taxaJuros;
        }

        [HttpGet]
        public ActionResult<double> Get(double valorInicial, int meses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Task<double> Calc = _CalculaJurosService.Get(valorInicial, meses);
                Calc.Wait();
                return Ok( Calc.Result.ToString());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

    }
}