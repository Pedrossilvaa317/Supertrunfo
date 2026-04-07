// See https://aka.ms/new-console-template for more information
using Supertrunfo;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criando jogadores
        Jogador jogador1 = new Jogador("Pedro");
        Jogador jogador2 = new Jogador("Igor");

        // Criando baralho de cartas
        List<Carta> baralho = new List<Carta>
        {
            new Carta("Pelé", "Atacante", 98, 95, 89, 60),
            new Carta("Pelé", "Atacante", 90, 95, 89, 60),
            new Carta("Romário", "Atacante", 88, 94, 80, 50),
            new Carta("Ronaldo", "Atacante", 94, 96, 78, 45),
            new Carta("Ronaldinho", "Meia", 87, 90, 95, 55),
            new Carta("Kaká", "Meia", 89, 88, 91, 58),
            new Carta("Neymar", "Atacante", 92, 91, 89, 48),
            new Carta("Cafu", "Lateral", 90, 75, 85, 82),
            new Carta("Roberto Carlos", "Lateral", 91, 82, 84, 80)
        };
        // Criando o jogo
        Jogo jogo = new Jogo(jogador1, jogador2);

        // Distribuindo as cartas
        jogo.DistribuirCartas(baralho);

        // Iniciando o jogo
        for (int i = 0; i < jogador1.Cartas.Count; i++)
        {
            Carta carta1 = jogador1.Cartas[i];
            Carta carta2 = jogador2.Cartas[i];

            Console.WriteLine("\n==============================");
            Console.WriteLine("Rodada " + (i + 1));
            Console.WriteLine("==============================");

            Console.WriteLine(jogador1.Nome + " jogou: " + carta1.Nome);
            Console.WriteLine(jogador2.Nome + " jogou: " + carta2.Nome);

            int atributoEscolhido = jogo.EscolherAtributo();
            jogo.CompararCartas(carta1, carta2, atributoEscolhido);
            jogo.ExibirPlacar();
        }


        // Exibir vencedor final
        jogo.ExibirVencedor();

        Console.WriteLine("\nFim do jogo!");
        Console.ReadLine();
    }
}



