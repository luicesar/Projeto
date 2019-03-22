using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcTest.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalcTest.API.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class CalculaJurosController : ControllerBase
  {

    [HttpGet]
    public ActionResult<decimal> Get([FromQuery] CalculaJurosView param)
    {
      var juros = (double)(1 / 100m);
      var valorFinal = (double)param.ValorInicial * Math.Pow((1 + juros), param.Meses);
      var resultadoFinal = (decimal)Math.Truncate(100 * valorFinal) / 100;

      return Ok(resultadoFinal.ToString("N2"));
    }

  }
}