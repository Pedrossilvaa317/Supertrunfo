// See https://aka.ms/new-console-template for more information
using Supertrunfo;

Carta carta1 = new Carta("Neymar", "Atacante", 88, 85, 83, 50);
Jogador jogador1 = new Jogador("Pedro");
Jogador jogador2 = new Jogador("Enzo");
jogador1.Cartas.Add(carta1);

Jogo jogo = new Jogo(jogador1, jogador2);

Console.WriteLine(jogador1.nome);
Console.WriteLine(jogador1.Cartas[0].Nome);
