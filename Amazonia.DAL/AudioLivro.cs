using System;
namespace Amazonia.DAL.Entidades
{
    public class AudioLivro : Livro
    {
        public string FormatoFicheiro { get; set; }  //PDF, DOC, EPUB ....
        public int DuracaoLivro { get; set; }  
    }
}
