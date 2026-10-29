namespace Exercicio3;

public class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
        andarAtual = 0;
    }

    public void Subir()
    {
        if (andarAtual >= totalAndares)
        {
            Console.WriteLine("O elevador já está no último andar.");
            return;
        }

        andarAtual++;
    }

    public void Descer()
    {
        if (andarAtual <= 0)
        {
            Console.WriteLine("O elevador já está no térreo (andar 0).");
            return;
        }

        andarAtual--;
    }

    public void ExibirAndar()
    {
        Console.WriteLine($"Andar atual: {andarAtual}");
    }
}
