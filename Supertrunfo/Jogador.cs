using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supertrunfo
{
    public class Jogador
    {
        // guarda o nome do jogador ex: "Pedro" ou "Enzo"
        public string Nome { get; set; }
        // guarda as cartas do jogador em uma lista 
        public List<Carta> Cartas { get; set; }
        // guarda a pontuação do jogador
        public int Pontuacao { get; set; }

        // construtor da classe jogador, recebe o nome do jogador e inicializa a lista de cartas e a pontuação
        public Jogador(string nome) 
        {
            Nome = nome;
            Cartas = new List<Carta>();
            Pontuacao = 0;
        }
    }
}
