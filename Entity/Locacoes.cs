using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Entity
{
    public class Locacoes
    {
        [Key]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdFilme { get; set; }
        public DateTime DataInicioLocacao { get; set; }
        public DateTime DataFimLocacao { get; set; }
        //Flag para identificar so o filme ainda está alugado
        public bool LocacaoAtiva { get; set; }
    }
}
