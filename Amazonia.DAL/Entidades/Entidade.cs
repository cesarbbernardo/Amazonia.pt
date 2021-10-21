namespace Amazonia.DAL.Entidades
{
    publicabstract class Entidade
}
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
}


