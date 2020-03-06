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
    public class ClienteController : ControllerBase
    {
        public IActionResult Post([FromBody]Cliente cliente)
        {
            try
            {
                ClienteBusiness business = new ClienteBusiness();
                bool cadastro = business.CadastrarCliente(cliente);
                if (!cadastro)
                {
                    return BadRequest("Cliente já cadastrado");
                }
                else
                {
                    return Ok(cliente);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}