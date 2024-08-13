using Microsoft.Toolkit.Diagnostics;

namespace Funcao;


public partial class Pessoa
{
    public int Id { get; private set; }

    public string Nome { get; private set; }

    public DateTime Nascimento { get; private set; }

    public Endereco? Principal { get; private set; }

    public List<Endereco> OutrosEnderecos { get; private set; }

    public Pessoa() { }

    public Pessoa(int id, string nome, DateTime nascimento)
    {
        Guard.IsNotDefault(id, nameof(id));
        Guard.IsNotNullOrWhiteSpace(nome, nameof(nome));
        Guard.IsGreaterThan(nome.Length, 5, nameof(nome));
        Guard.IsNotDefault(nascimento, nameof(nascimento));

        Id = id;
        Nome = nome;
        Nascimento = nascimento;
        this.OutrosEnderecos = new List<Endereco>();
    }
}