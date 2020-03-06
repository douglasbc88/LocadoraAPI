using Locadora.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Business
{
    public class Business
    {
        protected readonly Contexto _contexto;

        public Business()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();
            optionsBuilder.UseInMemoryDatabase("Locadora");
            _contexto = new Contexto(optionsBuilder.Options);
        }

    }
}
