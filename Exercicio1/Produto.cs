namespace Exercicio1;

public class Produto
{
    private string nome;
    private decimal preco;

    public Produto(string nome, decimal preco)
    {
        this.nome = nome;

        if (preco < 0)
        {
            Console.WriteLine("Erro: o preço não pode ser negativo. O preço foi definido como 0.");
            this.preco = 0;
        }
        else
        {
            this.preco = preco;
        }
    }

    public string GetNome()
    {
        return nome;
    }

    public decimal GetPreco()
    {
        return preco;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {nome} | Preço: R$ {preco:N2}");
    }

    public void AlterarPreco(decimal novoPreco)
    {
        if (novoPreco < 0)
        {
            Console.WriteLine($"Erro: o preço não pode ser negativo (valor informado: {novoPreco:N2}).");
            return;
        }

        preco = novoPreco;
        Console.WriteLine($"Preço alterado para R$ {preco:N2}.");
    }
}
