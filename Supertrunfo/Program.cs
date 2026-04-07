using System;
using System.Collections.Generic;

namespace Supertrunfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tela.ExibirCabecalho();

            Console.Write("Digite o nome do Jogador 1: ");
            string nome1 = Console.ReadLine()!;

            Jogador jogador1 = new Jogador(nome1);
            Jogador jogador2 = new Jogador("Computador");

            List<Carta> baralho = new List<Carta>
        {
            new Carta("Pelé", "Atacante", 90, 95, 89, 60),
            new Carta("Jairzinho", "Atacante", 89, 90, 80, 58),
            new Carta("Rivelino", "Meia", 82, 88, 91, 62),
            new Carta("Zico", "Meia", 84, 91, 94, 55),
            new Carta("Romário", "Atacante", 88, 94, 80, 50),
            new Carta("Bebeto", "Atacante", 85, 89, 82, 52),
            new Carta("Ronaldo", "Atacante", 94, 96, 78, 45),
            new Carta("Rivaldo", "Meia", 83, 92, 90, 57),
            new Carta("Ronaldinho", "Meia", 87, 90, 95, 55),
            new Carta("Kaká", "Meia", 89, 88, 91, 58),
            new Carta("Neymar", "Atacante", 92, 91, 89, 48),
            new Carta("Cafu", "Lateral", 90, 75, 85, 82),
            new Carta("Roberto Carlos", "Lateral", 91, 82, 84, 80),
            new Carta("Taffarel", "Goleiro", 50, 20, 65, 93)
        };

            Jogo jogo = new Jogo(jogador1, jogador2);
            jogo.DistribuirCartas(baralho);

            Tela.ExibirCabecalho();

            for (int i = 0; i < jogador1.Cartas.Count; i++)
            {
                Carta carta1 = jogador1.Cartas[i];
                Carta carta2 = jogador2.Cartas[i];

                Console.WriteLine("======================================");
                Console.WriteLine("Rodada " + (i + 1));
                Console.WriteLine("======================================");
                Console.WriteLine("Vez de escolher: " + jogo.JogadorAtual.Nome);
                Console.WriteLine();

                if (jogo.JogadorAtual == jogador1)
                {
                    Tela.MostrarCarta(carta1, jogador1.Nome);
                }
                else
                {
                    Tela.MostrarCarta(carta2, jogador2.Nome);
                }

                int atributoEscolhido = Tela.PedirAtributo();

                jogo.CompararCartas(carta1, carta2, atributoEscolhido);

                jogo.ExibirPlacar();
                Console.WriteLine();
            }

            jogo.ExibirVencedor();
            Console.ReadLine();
        }
    }
}