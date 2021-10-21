using System; 
using Amazonia.DAL;
using Amazonia.DAL.Repositorios;

namespace Amazonia.ConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var repo = new RepositorioCliente();
            var listaClientes = repo.ObterTodosQueComecemPor("J");

            foreach (var item in listaClientes)
            {
                Console.WriteLine(item);
            }


            var listaClientesAdultos = repo.ObterTodosQueTenhamPeloMenos18Anos();
            foreach (var item in listaClientesAdultos)

             {
                Console.WriteLine(item);
            }

             var listaClientesAdultosComecandoComJ = repo.ObterTodosQueTenhamPeloMenos18Anos();
            foreach (var item in listaClientesAdultosComecandoComJ)

             {
                Console.WriteLine(item);
            }

            var joao = repo.ObterPorNome("Joao");
            System.Console.WriteLine(joao);
            System.Console.WriteLine($"Database contem: {listaClientes.Count} clientes");
            repo.Apagar(joao);


            var listagemAposApagar = repo.ObterTodos();
            System.Console.WriteLine($"Database contem: {listagemAposApagar.Count} clientes");


            var clienteNovo = repo.Atualizar(joao.Nome, "Joao da Silva");
            System.Console.WriteLine(clienteNovo);

            /*
            Console.WriteLine("Criacao de Novos Clientes no Database");
            do {
                var novoCliente = new Cliente();
                Console.WriteLine("Informe o nome");
                novoCliente.Nome = Console.ReadLine();
                repo.Criar(novoCliente);
                Console.WriteLine($"{novoCliente.Nome} Criado");
            }while(Console.ReadKey().Key != ConsoleKey.Tab);

             var listaClientesNovosEAntigos = repo.ObterTodos();
            foreach (var item in listaClientesNovosEAntigos)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}
