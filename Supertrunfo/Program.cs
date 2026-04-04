// See https://aka.ms/new-console-template for more information
using Supertrunfo;

Carta carta1 = new Carta("Neymar", "Atacante", 88, 85, 83, 50);
Jogador j1 = new Jogador("Pedro");
j1.Cartas.Add(carta1);

Console.WriteLine(j1.Nome);
Console.WriteLine(j1.Cartas[0].Nome);
