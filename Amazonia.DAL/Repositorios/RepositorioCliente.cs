using System.Collections.Generic;
using Amazonia.DAL.Entidades;
using System;
using System.Linq;

namespace Amazonia.DAL.Repositorios
{
    public class RepositorioCliente : IRepositorio<Cliente>
    {
        private List<Cliente> ListaClientes;
        public RepositorioCliente()
        {
            ListaClientes = new List<Cliente>();
            var joao = new Cliente();
            joao.Nome = "Joao";
            joao.DataNascimento = new DateTime(1984, 05, 29);

            var maria = new Cliente { Nome = "Maria", DataNascimento = new DateTime(1950, 01, 01) };
            var marta = new Cliente { Nome = "Marta", DataNascimento = new DateTime(2021, 01, 02) };

            ListaClientes.Add(joao);
            ListaClientes.Add(maria);
            ListaClientes.Add(marta);
        }

        public void Apagar(Cliente obj)
        {
            ListaClientes.Remove(obj);
        }

        public Cliente Atualizar(string nomeAntigo, string nomeNovo)
        {
            var clienteTemporario = ObterPorNome(nomeAntigo));
            clienteTemporario.Nome = nomeNovo;

            return clienteTemporario;

        }

        public void Criar(Cliente obj)
        {
            ListaClientes.Add(obj);

        }

        public Cliente ObterPorNome(string Nome){
            var resultado = ListaClientes
                   .Where(x => x.Nome. == Nome)
                   .OrderByDescending(x => x.Idade)
                   .FirstOrDefault();
            return resultado;
        }

        public List<Cliente> ObterTodos()
        {
            return ListaClientes;
        }
       public List<Cliente> ObterTodosQueComecemPor(string comeco)
       {
            var resultado = ListaClientes
                            .Where(x => x.Nome.StartsWith(comeco))
                            .ToList();
            return resultado;
       }

        public List<Cliente> ObterTodosQueTenhamPeloMenos18Anos()
        {

            var resultado = ListaClientes
                            .Where(x => x.Idade >= 18)
                            .ToList();
            return resultado;
         }

        public List<Cliente> ObterTodosQueTenhamPeloMenos18AnosENomeComecePor(string comeco)
        {

            var resultado = ListaClientes
                            .Where(x => x.Idade >= 18)
                            .Where(x => x.Nome.StartsWith(comeco))
                            .ToList();
            return resultado;
         }

        public List<string> ObterTodosQueTenhamPeloMenos18AnosENomeComecePor(string comeco)
        {
            System.Console.WriteLine("ObterNomeDeTodosQueTenhamPeloMenos18AnosENomeComecePor");
            var resultado = ListaClientes //Conjunto
                            .Where(x => x.Idade >= 18 && x.Nome.StartsWith(comeco)) //Filtro
                            .Select(x => x.Nome.ToUpper()) //Saída/Projeção
                            .ToList();

            return resultado;
         }
    }
}