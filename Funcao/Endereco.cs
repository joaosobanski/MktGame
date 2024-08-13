using Microsoft.Toolkit.Diagnostics;

namespace Funcao;


public class Endereco
{
    public Endereco(int id, string nomeRua, string bairro, int numero, string zipCode)
    {
        Guard.IsNotNullOrWhiteSpace(nomeRua, nameof(nomeRua));
        Guard.IsNotNullOrWhiteSpace(bairro, nameof(bairro));
        Guard.IsNotNullOrWhiteSpace(zipCode, nameof(zipCode));
        Guard.IsGreaterThan(numero, 0, nameof(numero));
        Id = id;
        NomeRua = nomeRua;
        Bairro = bairro;
        Numero = numero;
        ZipCode = zipCode;
    }

    public Endereco() { }

    public int Id { get; private set; }
    public string NomeRua { get; private set; }
    public string Bairro { get; private set; }
    public int Numero { get; private set; }
    public string ZipCode { get; private set; }
}