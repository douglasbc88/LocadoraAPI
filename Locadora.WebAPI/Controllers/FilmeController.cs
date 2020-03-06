using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locadora.Business;
using Locadora.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        public IActionResult Post([FromBody]Filme filme)
        {
            try
            {
                FilmeBusiness business = new FilmeBusiness();
                business.CadastrarFilme(filme);
                return Ok(filme);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}