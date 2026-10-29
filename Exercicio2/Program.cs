using Exercicio2;

Console.WriteLine("--- Exercício 02: Carro com controle de velocidade ---");

Carro c = new Carro("Ferrari");
c.Acelerar(50);
c.ExibirVelocidade(); // Deve exibir 50
c.Frear(30);
c.ExibirVelocidade(); // Deve exibir 20
c.Frear(50);
c.ExibirVelocidade(); // Deve exibir 0

// c.velocidadeAtual = -100; // ERRO: só pode ser alterada por Acelerar() e Frear()
