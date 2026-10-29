namespace Exercicio2;

public class Carro
{
    private string modelo;
    private int velocidadeAtual;

    public Carro(string modelo)
    {
        this.modelo = modelo;
        velocidadeAtual = 0;
    }

    public void Acelerar(int valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de aceleração inválido.");
            return;
        }

        velocidadeAtual += valor;
    }

    public void Frear(int valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de frenagem inválido.");
            return;
        }

        velocidadeAtual -= valor;

        // A velocidade nunca pode ficar abaixo de 0
        if (velocidadeAtual < 0)
        {
            velocidadeAtual = 0;
        }
    }

    public void ExibirVelocidade()
    {
        Console.WriteLine($"{modelo} - Velocidade atual: {velocidadeAtual} km/h");
    }
}
