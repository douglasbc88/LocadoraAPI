using Locadora.Business;
using Locadora.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.WebAPI.Tests
{
    public class Util
    {
        public void CadastraClientes()
        {
            Dictionary<string, string> dictClientes = new Dictionary<string, string>();
            dictClientes.Add("21469739003", "Osvaldo");
            dictClientes.Add("22093309041", "Joao");
            dictClientes.Add("96522727013", "Marcelo");

            foreach (KeyValuePair<string, string> kvp in dictClientes)
            {
                Cliente cliente = new Cliente()
                {
                    Nome = kvp.Value,
                    Cpf = kvp.Key,
                    Ativo = true
                };

                ClienteBusiness business = new ClienteBusiness();
                business.CadastrarCliente(cliente);
            }
        }

        public void CadastraFilmes()
        {
            List<string> filmes = new List<string>();
            filmes.Add("A Espera de um Milagre");
            filmes.Add("Homens de Honra");
            filmes.Add("A vida é bela");

            foreach (string nomeFilme in filmes)
            {
                Filme filme = new Filme()
                {
                    Nome = nomeFilme,
                    Ativo = true
                };

                FilmeBusiness business = new FilmeBusiness();
                business.CadastrarFilme(filme);
            }
        }
    }
}
