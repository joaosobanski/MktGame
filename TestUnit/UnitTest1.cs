using FluentAssertions;
using Funcao;

namespace TestUnit;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var a = 1;
        a.Should().NotBe(2);
    }

    [TestCase(10)]
    [TestCase(15)]
    [TestCase(5)]
    [TestCase(20)]
    [TestCase(30)]
    public void Test2(int x)
    {
        x.Should().BeGreaterThanOrEqualTo(5);
    }

    [TestCase(10, 5)]
    [TestCase(15, 10)]
    [TestCase(5, 1)]
    [TestCase(20, 10)]
    [TestCase(30, 90)]
    public void Deve_Somar_Valores_Com_Sucesso(int x, int y)
    {
        var resultado = Calculadora.Soma(x, y);
        resultado.Should().NotBe(null);
        resultado.Should().Be(x + y);
    }



}