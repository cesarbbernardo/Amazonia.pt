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
            var listaClientes = repo.ObterTodos();

            foreach (var item in listaClientes)
            {
                System.Console.WriteLine(item);
            }


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
                System.Console.WriteLine(item);
            }
        }
    }
}
