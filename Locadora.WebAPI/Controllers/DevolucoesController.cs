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
    public class DevolucoesController : ControllerBase
    {
        public IActionResult Post([FromBody]int IdLocacao)
        {
            try
            {
                LocacoesBusiness business = new LocacoesBusiness();
                bool cadastro = business.DevolucaoDeFilme(IdLocacao);
                if (!cadastro)
                {
                    return BadRequest("Atraso na devolução");
                }
                else
                {
                    return Ok("Devolução realizada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}