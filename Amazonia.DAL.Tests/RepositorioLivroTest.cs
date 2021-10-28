using Amazonia.DAL.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amazonia.DAL.Tests
{
    [TestClass]
    public class RepositorioLivroTest
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void DeveCriarUmObjectoDoTipoRepositorioLivros()
        {
            ///Arrange
            RepositorioLivro repositorio;

            ///Act
            repositorio = new RepositorioLivro();

            ///Assert
            Assert.IsNotNull(repositorio);
        }


        [TestMethod]
        public void DeveCriarUmaListaDeLivrosNoObjectoDoTipoRepositorioLivros()
        {
            ///Arrange
            RepositorioLivro repositorio;
            List<Livro> livros;
            var minElementos = 1;

            ///Act
            repositorio = new RepositorioLivro();
            livros = repositorio.ObterTodos();
            var quantidadeLivrosNoRepositorio = livros.Count();

            ///Assert
            Assert.IsNotNull(repositorio);
            Assert.IsNotNull(livros);
            //Assert.IsNotNull(quantidadeLivrosNoRepositorio >= quantidadeElementos);
            Assert.AreEqual()(quantidadeLivrosNoRepositorio >= quantidadeElementos);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DeveApagarUmLivroDaLista()
        {
            ///Arrange
            var repo = new RepositorioLivro();
            var livros = repo.ObterTodos();
            var livroAApagar = livros.FirstOrDefault();

            ///Act
            var livrosInicialmente = livros.Count;
            repo.Apagar~(livroAApagar);
            var livrosDepoisDeApagar = livros.Count;

            ///Assert
            Assert.Istrue(livrosInicialmente > livrosDepoisDeApagar);
        }












    }
}
