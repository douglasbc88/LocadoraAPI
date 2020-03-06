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
    public class ClienteControllerTest
    {
        [TestMethod]
        public void Post()
        {
            // Arrange
            ClienteController controller = new ClienteController();
            Cliente cliente = new Cliente()
            {
                Nome = "Osvaldo",
                Cpf = "21469739003"
            };

            // Act
            IActionResult result = controller.Post(cliente);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void PostClienteRepetido()
        {
            // Arrange
            ClienteController controller = new ClienteController();
            Cliente cliente = new Cliente()
            {
                Nome = "Osvaldo",
                Cpf = "21469739003"
            };

            Cliente cliente2 = new Cliente()
            {
                Nome = "Joao",
                Cpf = "22093309041"
            };

            Cliente clienteRepetido = new Cliente()
            {
                Nome = "Osvaldo",
                Cpf = "21469739003"
            };

            // Act
            controller.Post(cliente);
            controller.Post(cliente2);
            IActionResult resultRepetido = controller.Post(clienteRepetido);

            // Assert
            Assert.IsInstanceOfType(resultRepetido, typeof(BadRequestObjectResult));
        }
    }
}
