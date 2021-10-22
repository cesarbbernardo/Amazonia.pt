using System;

namespace Amazonia.DAL.Entidades
{
    public abstract class Entidade
    {
        public Guid Identificador { get; }
        public string Nome { get; set; }

        public Entidade()
        {
            Identificador = Guid.NewGuid();
        }

        public Entidade(string nome)
        {
            Nome = nome;
            Identificador = Guid.NewGuid();
        }


        public override string Tostring()
        {
            return $"Nome: {Nome} => Identificador: {Identificador}";
        }
    }
}