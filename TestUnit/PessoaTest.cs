using FluentAssertions;
using Funcao;

namespace TestUnit;

public class PessoaTest
{

    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void Deve_Criar_Pessoa_Com_Sucesso()
    {
        DateTime nascimento = new DateTime(1990, 4, 29);

        var pessoa = new Pessoa(1, "Pedro Presente", nascimento);
        pessoa.Nome.Should().Be(pessoa.Nome);
        pessoa.Nascimento.Should().Be(nascimento);
    }

    [Test]
    public void Deve_Falhar_Criar_Pessoa_Com_Nome_Invalido()
    {
        DateTime nascimento = new DateTime(1990, 4, 29);

        var pessoa = new Pessoa(1, "", nascimento);
        pessoa.Nome.Should().Be(pessoa.Nome);
        pessoa.Nascimento.Should().Be(nascimento);
    }

    [Test]
    public void Deve_Adicionar_Endereco_Com_Sucesso()
    {
        var _pessoa = new Pessoa(1, "Pedro Presente", new DateTime(1990, 4, 29));

        var end = new Endereco(1, "Av brasil", "Centro", 100, "algum");

        _pessoa.Should().NotBeNull();
        end.Should().NotBeNull();
        end.Should().BeOfType(typeof(Endereco));

        _pessoa.AdicionarEndereco(end);

        _pessoa.OutrosEnderecos.Should().Contain(end);
    }

}