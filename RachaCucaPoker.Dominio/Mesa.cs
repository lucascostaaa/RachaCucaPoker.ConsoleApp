using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RachaCucaPoker.Dominio
{
    public class Mesa
    {
        public Mao MaoJogador1;
        public Mao MaoJogador2;

        public string MostraJogadorVencedor() 
        {
            int ClassificacaoMaoJogador1 = MaoJogador1.ClassificarMao();
            int ClassificacaoMaoJogador2 = MaoJogador2.ClassificarMao();

            if (ClassificacaoMaoJogador1 < ClassificacaoMaoJogador2)
                return "Jogador 1";
            else if (ClassificacaoMaoJogador1 > ClassificacaoMaoJogador2)
                return "Jogador 2";
            else 
                return "Empate";
        }
    }
}
