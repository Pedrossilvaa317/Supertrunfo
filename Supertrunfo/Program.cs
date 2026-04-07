// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supertrunfo
{
    public static class Tela
    {
        public static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("       SUPER TRUNFO: LENDAS DA SELEÇÃO            ");
            Console.WriteLine("==================================================");
            Console.WriteLine();
        }

        public static void MostrarCarta(Carta carta, string nomejogador)
        {
            Console.WriteLine($"--- CARTA DE {nomejogador} ---");
            Console.WriteLine($" Jogador : {carta.Nome}");
            Console.WriteLine($" Posição : {carta.Posicao}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($" [1] Velocidade  : {carta.Velocidade}");
            Console.WriteLine($" [2] Finalização : {carta.Finalizacao}");
            Console.WriteLine($" [3] Passe       : {carta.Passe}");
            Console.WriteLine($" [4] Defesa      : {carta.Defesa}");
            Console.WriteLine("--------------------------------\n");
        }
        public static int PedirAtributo()
        {
            Console.WriteLine("Qual atributo você escolhe para a batalha?");
            Console.Write("Digite o número (1 a 4): ");

            int escolha = int.Parse(Console.ReadLine()!);
            // O "!" (Null-Forgiving) garante ao C# que o usuário vai digitar algo e o valor não será nulo.

            Console.WriteLine();

            return escolha;

        }
        // PASSO 5: Telas de Resultado e Fim de Jogo
        public static void ExibirResultadoRodada(string nomeVencedor)
        {
            Console.WriteLine("==================================================");
            if (nomeVencedor == "Empate")
            {
                Console.WriteLine("                DEU EMPATE!                       ");
            }
            else
            {
                Console.WriteLine($"     O VENCEDOR DA RODADA FOI: {nomeVencedor}!");
            }
            Console.WriteLine("==================================================\n");

            Console.WriteLine("Pressione ENTER para continuar para a próxima rodada...");
            Console.ReadLine(); // Trava a tela para dar tempo de ler, até o jogador apertar Enter
            Console.Clear(); // Limpa a tela para a próxima rodada começar limpa
        }

        public static void ExibirPlacarFinal(Jogador j1, Jogador j2)
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("                  FIM DE JOGO!                    ");
            Console.WriteLine("==================================================");
            Console.WriteLine($" {j1.Nome}: {j1.Pontuacao} pontos");
            Console.WriteLine($" {j2.Nome}: {j2.Pontuacao} pontos");
            Console.WriteLine("==================================================");

            if (j1.Pontuacao > j2.Pontuacao)
            {
                Console.WriteLine($" PARABÉNS {j1.Nome}, VOCÊ É O CAMPEÃO!");
            }
            else if (j2.Pontuacao > j1.Pontuacao)
            {
                Console.WriteLine($" PARABÉNS {j2.Nome}, VOCÊ É O CAMPEÃO!");
            }
            else
            {
                Console.WriteLine(" O JOGO TERMINOU EM EMPATE!");
            }
            Console.WriteLine("==================================================\n");
        }
    }
}
   




