using RachaCucaPoker.Domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RachaCucaPoker.Dominio
{
    public class Mao
    {
        public Carta carta1;
        public Carta carta2;
        public Carta carta3;
        public Carta carta4;
        public Carta carta5;
 

        public Mao(Carta carta1, Carta carta2, Carta carta3, Carta carta4, Carta carta5)
        {
            this.carta1 = carta1;
            this.carta2 = carta2;
            this.carta3 = carta3;
            this.carta4 = carta4;
            this.carta5 = carta5;
            AlterarCartasParaOrdemCrescente();
        }

        public int ClassificarMao()
        {
            if (EhRoyalFlush())
                return 1;
            if (EhStraightFlush())
                return 2;
            if (EhQuadra())
                return 3;
            if (EhFullHouse())
                return 4;
            if (EhFlush())
                return 5;
            if (EhSequencia())
                return 6;
            if (EhTrinca())
                return 7;
            if (EhDoisPares())
                return 8;
            if (EhUmPar())
                return 9;
            if (EhUmaCarta())
                return 10;

            return 0;
        }

        public bool EhRoyalFlush()
        {
            if (TodasCartasPossuemNaipesIguais() && EhSequenciaRoyalFlush())
                return true;
            return true;
        }

        public bool EhStraightFlush()
        {
            if (TodasCartasPossuemNaipesIguais() && EhSequencia())
                return true;
            return false;
        }

        public bool EhQuadra()
        {
            //ordenar as cartas
            if (((carta1.Valor == carta2.Valor) &&
                (carta2.Valor == carta3.Valor) &&
                (carta3.Valor == carta4.Valor)) 
                ||
                ((carta2.Valor == carta3.Valor) &&
                (carta3.Valor == carta4.Valor) &&
                (carta4.Valor == carta5.Valor)))
                return true;
            return false;
        }

        public bool EhFullHouse()
        {
            if (((carta1.ObterValorNumerico() == carta2.ObterValorNumerico()) &&
               (carta2.ObterValorNumerico() == carta3.ObterValorNumerico()) &&
               (carta4.ObterValorNumerico() == carta4.ObterValorNumerico())) ||
               ((carta1.ObterValorNumerico() == carta2.ObterValorNumerico()) &&
               (carta3.ObterValorNumerico() == carta4.ObterValorNumerico()) &&
               (carta4.ObterValorNumerico() == carta5.ObterValorNumerico())))


                return true;
            return false;
        }

        public bool EhFlush()
        {
            return (TodasCartasPossuemNaipesIguais());
        }

        public bool EhSequencia()
        {
            if(((carta1.ObterValorNumerico() + 1) == carta2.ObterValorNumerico()) &&
                ((carta2.ObterValorNumerico() + 1) == carta3.ObterValorNumerico()) &&
                ((carta3.ObterValorNumerico() + 1) == carta4.ObterValorNumerico()) &&
                ((carta4.ObterValorNumerico() + 1) == carta5.ObterValorNumerico()))
                return true;
            return false;
        }

        public bool EhTrinca()
        {
            if (((carta1.ObterValorNumerico() == carta2.ObterValorNumerico()) &&
                (carta1.ObterValorNumerico() == carta3.ObterValorNumerico())) ||
                ((carta2.ObterValorNumerico() == carta3.ObterValorNumerico()) &&
                (carta2.ObterValorNumerico() == carta4.ObterValorNumerico())) ||
                ((carta3.ObterValorNumerico() == carta4.ObterValorNumerico()) &&
                (carta3.ObterValorNumerico() == carta5.ObterValorNumerico())))
                return true;
            return false;
        }

        public bool EhDoisPares()
        {
            if (((carta1.ObterValorNumerico() == carta2.ObterValorNumerico()) && 
                (carta3.ObterValorNumerico() == carta4.ObterValorNumerico())) ||
            ((carta1.ObterValorNumerico() == carta2.ObterValorNumerico()) &&
                (carta4.ObterValorNumerico() == carta5.ObterValorNumerico())) ||
            ((carta2.ObterValorNumerico() == carta3.ObterValorNumerico()) &&
                (carta4.ObterValorNumerico() == carta5.ObterValorNumerico())))
                return true;
            return false;
        }

        public bool EhUmPar()
        {
            if((carta1.ObterValorNumerico() == carta2.ObterValorNumerico()) || 
            (carta2.ObterValorNumerico() == carta3.ObterValorNumerico()) ||
            (carta3.ObterValorNumerico() == carta4.ObterValorNumerico()) ||
            (carta4.ObterValorNumerico() == carta5.ObterValorNumerico()) )
                return true;
            return false;
        }

        public bool EhUmaCarta()
        {
            return (!EhUmPar() && !TodasCartasPossuemNaipesIguais() && !EhSequencia());
        }

        private bool TodasCartasPossuemNaipesIguais()
        {
            if ((carta1.Naipe == carta2.Naipe) &&
                (carta2.Naipe == carta3.Naipe) &&
                (carta3.Naipe == carta4.Naipe) &&
                (carta4.Naipe == carta5.Naipe))
                return true;
            return false;
        }

        private bool EhSequenciaRoyalFlush()
        {
            //Ordenar Cartas
            if ((carta1.Valor == "T") &&
                (carta2.Valor == "J") &&
                (carta3.Valor == "Q") &&
                (carta4.Valor == "K") &&
                (carta5.Valor == "A"))
                return true;
            return false;
        }

        private void AlterarCartasParaOrdemCrescente() 
        {
            List<Carta> cartas = new List<Carta>();
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);

            List<Carta> cartasOrdenadas = cartas.OrderBy(o => o.ObterValorNumerico()).ToList();

            carta1 = cartasOrdenadas[0];
            carta2 = cartasOrdenadas[1];
            carta3 = cartasOrdenadas[2];
            carta4 = cartasOrdenadas[3];
            carta5 = cartasOrdenadas[4];
        }

    }
}
