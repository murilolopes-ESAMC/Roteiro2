using Exercicio1;

Console.WriteLine("--- Exercício 01: Classe Produto encapsulada ---");

Produto p = new Produto("Celular", 1500);
p.ExibirDetalhes();
p.AlterarPreco(-200); // Deve exibir uma mensagem de erro
p.AlterarPreco(1200);
p.ExibirDetalhes();

// p.preco = -200; // ERRO: 'preco' é privado, só pode ser alterado por AlterarPreco()
