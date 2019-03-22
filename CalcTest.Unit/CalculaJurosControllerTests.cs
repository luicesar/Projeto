using System;
using System.Threading.Tasks;
using CalcTest.API.Controllers;
using CalcTest.API.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace CalcTest.Unit
{
  public class CalculaJurosControllerTests
  {

    [Fact]
    public void CalcularJurosTest()
    {
      var controller = new CalculaJurosController();
      var parametros = new CalculaJurosView() { ValorInicial = 100, Meses = 5 };

      var resultController = controller.Get(parametros);
      var result = Assert.IsType<OkObjectResult>(resultController.Result);

      var ok = resultController.Result as OkObjectResult;

      Assert.Equal("105,10", ok.Value);
    }

    [Fact]
    public async Task ShowMeTheCodeTest()
    {
      var controller = new ShowMeTheCodeController();
      var resultado = await controller.Get();
      var contentResult = Assert.IsType<OkObjectResult>(resultado);

      Assert.NotNull(resultado);
    }
  }
}
