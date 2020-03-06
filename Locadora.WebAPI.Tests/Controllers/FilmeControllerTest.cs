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
    public class FilmeControllerTest
    {
        [TestMethod]
        public void Post()
        {
            // Arrange
            FilmeController controller = new FilmeController();
            Filme filme = new Filme()
            {
                Nome = "A Espera de um Milagre"
            };

            // Act
            IActionResult result = controller.Post(filme);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
    }
}
