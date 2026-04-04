using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supertrunfo
{
    public class Carta
    {
        // criação da classe Carta, abaixo guarda o nome e a posição do jogador
        public string Nome { get; set; }
        public string Posicao { get; set; }
        // guarda os atributos do jogador
        public int Velocidade { get; set; }
        public int Finalizacao { get; set; }
        public int Passe { get; set; }
        public int Defesa { get; set; }

        public Carta(string nome, string posicao, int velocidade, int finalizacao, int passe, int defesa)
        {
            Nome = nome;
            Posicao = posicao;
            Velocidade = velocidade;
            Finalizacao = finalizacao;
            Passe = passe;
            Defesa = defesa;
        }
    }
}
