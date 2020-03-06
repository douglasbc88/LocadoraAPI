using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Entity
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options){ }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Filme> Filmes { get; set; }

        public DbSet<Locacoes> Locacoes { get; set; }
    }
}