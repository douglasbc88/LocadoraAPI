using Locadora.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Business
{
    public class FilmeBusiness : Business
    {
        public FilmeBusiness() : base() { }

        public bool CadastrarFilme(Filme filme)
        {
            try
            {
                _contexto.Filmes.Add(filme);
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
