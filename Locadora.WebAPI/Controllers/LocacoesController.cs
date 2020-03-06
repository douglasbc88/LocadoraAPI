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
    public class LocacoesController : ControllerBase
    {
        public IActionResult Post([FromBody]Locacoes locacao)
        {
            try
            {
                LocacoesBusiness business = new LocacoesBusiness();
                bool cadastro = business.CadastrarLocacao(locacao);
                if (!cadastro)
                {
                    return BadRequest("Filme indisponível");
                }
                else
                {
                    return Ok(locacao);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}