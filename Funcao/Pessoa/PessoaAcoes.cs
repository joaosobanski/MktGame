namespace Funcao;

public partial class Pessoa
{
    public void AlterarEnderecoPrincipal(Endereco novoPrincipal)
    {
        // valida se o endereco novo nao eh null e se eh valido
        this.Principal = novoPrincipal;
        // expressao lambda
        if (this.OutrosEnderecos.Find(e => e.Id == novoPrincipal.Id) == null)
        {
            this.OutrosEnderecos.Add(novoPrincipal);
        }
    }

    public void RemoverEndereco(Endereco endereco)
    {
        this.OutrosEnderecos.Remove(endereco);
    }

    public void AdicionarEndereco(Endereco novoPrincipal)
    {
        this.OutrosEnderecos.Add(novoPrincipal);
    }
}