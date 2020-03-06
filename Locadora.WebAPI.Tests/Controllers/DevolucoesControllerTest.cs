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
    public class DevolucoesControllerTest
    {
        [TestMethod]
        public void Post()
        {
            // Arrange
            LocacoesController locacoesController = new LocacoesController();
            DevolucoesController devolucoesController = new DevolucoesController();
            Util util = new Util();
            util.CadastraClientes();
            util.CadastraFilmes();

            Locacoes locacao = new Locacoes();
            locacao.IdCliente = 1;
            locacao.IdFilme = 1;
            locacao.DataInicioLocacao = new DateTime(2020, 3, 1);
            locacao.DataFimLocacao = DateTime.Now.AddDays(2);

            // Act
            locacoesController.Post(locacao);
            IActionResult result = devolucoesController.Post(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void PostFilmeAtrasado()
        {
            // Arrange
            LocacoesController locacoesController = new LocacoesController();
            DevolucoesController devolucoesController = new DevolucoesController();
            Util util = new Util();
            util.CadastraClientes();
            util.CadastraFilmes();

            Locacoes locacao = new Locacoes();
            locacao.IdCliente = 1;
            locacao.IdFilme = 1;
            locacao.DataInicioLocacao = new DateTime(2020, 3, 1);
            locacao.DataFimLocacao = new DateTime(2020, 3, 3);

            // Act
            locacoesController.Post(locacao);
            IActionResult result = devolucoesController.Post(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }
    }
}
