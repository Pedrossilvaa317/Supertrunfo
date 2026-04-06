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

        public Jogo(Jogador jogador1, Jogador jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
        }
    }
}
