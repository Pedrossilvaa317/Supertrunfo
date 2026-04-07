using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supertrunfo
{
    public class Jogo
    {
        public Jogador Jogador1 { get; set; }
        public Jogador Jogador2 { get; set; }
        public Jogador JogadorAtual { get; set; }

        public Jogo(Jogador jogador1, Jogador jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
            JogadorAtual = jogador1;
        }


        public void DistribuirCartas(List<Carta> baralho)
        {
            Random random = new Random();

            // Embaralhar o baralho
            for (int i = 0; i < baralho.Count; i++)
            {
                int indiceAleatorio = random.Next(i, baralho.Count);

                Carta temp = baralho[i];
                baralho[i] = baralho[indiceAleatorio];
                baralho[indiceAleatorio] = temp;
            }

            // Limpar cartas antigas, se houver
            Jogador1.Cartas.Clear();
            Jogador2.Cartas.Clear();

            for (int i = 0; i < baralho.Count; i++)
            {
                if (i % 2 == 0)
                    Jogador1.Cartas.Add(baralho[i]);
                else
                    Jogador2.Cartas.Add(baralho[i]);
            }
        }

        public int EscolherAtributo()
        {
            // Menu de escolhas do jogador para fazer a jogada
            Console.WriteLine("\nEscolha um atributo:");
            Console.WriteLine("1 - Velocidade");
            Console.WriteLine("2 - Finalização");
            Console.WriteLine("3 - Passe");
            Console.WriteLine("4 - Defesa");
            Console.WriteLine("Digite sua escolha: ");

            //Recebe a escolha do usuario e converte através do parse para inteiro
            int opcao = int.Parse(Console.ReadLine()!);
            if (opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
            return opcao;

        }

        public void CompararCartas(Carta carta1, Carta carta2, int atributo)
        {
            int valor1 = 0;
            int valor2 = 0;
            string nomeAtributo = "";

            switch (atributo)
            {
                case 1:
                    valor1 = carta1.Velocidade;
                    valor2 = carta2.Velocidade;
                    nomeAtributo = "Velocidade";
                    break;
                case 2:
                    valor1 = carta1.Finalizacao;
                    valor2 = carta2.Finalizacao;
                    nomeAtributo = "Finalização";
                    break;
                case 3:
                    valor1 = carta1.Passe;
                    valor2 = carta2.Passe;
                    nomeAtributo = "Passe";
                    break;
                case 4:
                    valor1 = carta1.Defesa;
                    valor2 = carta2.Defesa;
                    nomeAtributo = "Defesa";
                    break;
            }

            Console.WriteLine("\nAtributo escolhido: " + nomeAtributo);
            Console.WriteLine(Jogador1.Nome + " (" + carta1.Nome + "): " + valor1);
            Console.WriteLine(Jogador2.Nome + " (" + carta2.Nome + "): " + valor2);

            if (valor1 > valor2)
            {
                Console.WriteLine(Jogador1.Nome + " venceu a rodada!");
                Jogador1.Pontuacao++;
                JogadorAtual = Jogador1;
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine(Jogador2.Nome + " venceu a rodada!");
                Jogador2.Pontuacao++;
                JogadorAtual = Jogador2;
            }
            else
            {
                Console.WriteLine("Empate! As cartas voltam para os jogadores.");
            }
        }

        public void ExibirPlacar()
        {
            Console.WriteLine("\n -- Placar --");
            Console.WriteLine(Jogador1.Nome + ": " + Jogador1.Pontuacao + " ponto(s)");
            Console.WriteLine(Jogador2.Nome + ": " + Jogador2.Pontuacao + " ponto(s)");
        }

        public void ExibirVencedor()
        {
            Console.WriteLine("\n -- Resultado Final --");

            if (Jogador1.Pontuacao > Jogador2.Pontuacao)
            {
                Console.WriteLine("Vencedor final: " + Jogador1.Nome);
            }
            else if (Jogador2.Pontuacao > Jogador1.Pontuacao)
            {
                Console.WriteLine("Vencedor final: " + Jogador2.Nome);
            }
            else
            {
                Console.WriteLine("A partida empatou!");
            }
        }
    }
}
