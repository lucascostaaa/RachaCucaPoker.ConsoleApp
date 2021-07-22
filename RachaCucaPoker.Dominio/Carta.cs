using System;

namespace RachaCucaPoker.Domino
{
    public class Carta
    {
        public string Naipe;
        public string Valor;

        public Carta(string Naipe, string Valor)
        {
            this.Naipe = Naipe.ToLower();
            this.Valor = Valor.ToLower();
        }

        public bool ValidarNaipe() 
        {
            if ((Naipe.Equals("d") || (Naipe.Equals("h")) || (Naipe.Equals("s")) || (Naipe.Equals("c"))))
                return true;
            return false;
        }

        public bool ValidarValor()
        {
            if (Valor.Equals("a") || (Valor.Equals("2")) || (Valor.Equals("3")) || 
               (Valor.Equals("4")) || (Valor.Equals("5")) || (Valor.Equals("6")) || 
               (Valor.Equals("7")) || (Valor.Equals("8")) || (Valor.Equals("9")) || 
               (Valor.Equals("t")) || (Valor.Equals("q")) || (Valor.Equals("j")) || 
               (Valor.Equals("k")))
                return true;
            return false;
        }

        public bool ValidarCarta() 
        {
            return (ValidarNaipe() && ValidarValor());
        }

        public int ObterValorNumerico()
        {
            switch (Valor)
            {
                case "a":
                    return 14;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "t":
                    return 10;
                case "j":
                    return 11;
                case "q":
                    return 12;
                case "k":
                    return 13;

                default: return 0;
            }
            
        }

        public bool Equals(Carta cartaComparada)
        {
            if ((this.Naipe.Equals(cartaComparada.Naipe)) && (this.Valor.Equals(cartaComparada.Valor)))
                return true;
            return false;
        }
    }
}
