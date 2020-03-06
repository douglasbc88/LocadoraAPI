using Locadora.Entity;
using Locadora.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.WebAPI.Tests.Controllers
{
    [TestClass]
    public class LocacoesControllerTest
    {
        [TestMethod]
        public void Post()
        {
            // Arrange
            LocacoesController controller = new LocacoesController();
            Util util = new Util();
            util.CadastraClientes();
            util.CadastraFilmes();

            Locacoes locacao = new Locacoes();
            locacao.IdCliente = 1;
            locacao.IdFilme = 1;
            locacao.DataInicioLocacao = new DateTime(2020, 3, 1);
            locacao.DataFimLocacao = new DateTime(2020, 3, 3);

            // Act
            IActionResult result = controller.Post(locacao);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void PostFilmeAlugado()
        {
            // Arrange
            LocacoesController controller = new LocacoesController();
            Util util = new Util();
            util.CadastraClientes();
            util.CadastraFilmes();

            Locacoes locacao = new Locacoes();
            locacao.IdCliente = 1;
            locacao.IdFilme = 1;
            locacao.DataInicioLocacao = new DateTime(2020, 3, 1);
            locacao.DataFimLocacao = new DateTime(2020, 3, 3);

            Locacoes locacaoRepetida = new Locacoes();
            locacaoRepetida.IdCliente = 3;
            locacaoRepetida.IdFilme = 1;
            locacaoRepetida.DataInicioLocacao = new DateTime(2020, 3, 1);
            locacaoRepetida.DataFimLocacao = new DateTime(2020, 3, 3);

            // Act
            controller.Post(locacao);
            IActionResult resultRepetido = controller.Post(locacaoRepetida);

            // Assert
            Assert.IsInstanceOfType(resultRepetido, typeof(BadRequestObjectResult));
        }
    }
}
