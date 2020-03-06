using Locadora.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Business
{
    public class LocacoesBusiness : Business
    {
        public LocacoesBusiness() : base() { }

        public bool CadastrarLocacao(Locacoes locacao)
        {
            try
            {
                //Verificando se o filme esta disponivel
                IEnumerable<Locacoes> filmesAlugados = _contexto.Locacoes.Where(
                    x => x.IdFilme == locacao.IdFilme
                    && x.LocacaoAtiva == true
                );

                if (filmesAlugados != null && filmesAlugados.Count() > 0)
                {
                    return false;
                }

                locacao.LocacaoAtiva = true;

                _contexto.Locacoes.Add(locacao);
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DevolucaoDeFilme(int IdLocacao)
        {
            try
            {
                Locacoes locacao = _contexto.Locacoes.Find(IdLocacao);
                if (locacao.DataFimLocacao < DateTime.Now)
                {
                    return false;
                }
                
                locacao.LocacaoAtiva = false;
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
