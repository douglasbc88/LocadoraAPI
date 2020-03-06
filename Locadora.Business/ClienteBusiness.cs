using Locadora.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Business
{
    public class ClienteBusiness : Business
    {
        public ClienteBusiness() : base() { }

        public bool CadastrarCliente(Cliente cliente)
        {
            try
            {
                //Verificando se o cliente já existe na base
                IEnumerable<Cliente> clientesExistentes = _contexto.Clientes.Where(x => x.Cpf == cliente.Cpf);
                if (clientesExistentes != null && clientesExistentes.Count() > 0)
                {
                    return false;
                }

                _contexto.Clientes.Add(cliente);
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }
    }
}
