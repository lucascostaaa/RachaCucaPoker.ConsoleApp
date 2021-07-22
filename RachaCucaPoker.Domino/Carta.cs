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
            if ((Naipe.Equals("d") || (Naipe.Equals("h")) || (Naipe.Equals("s")) || (Naipe.Equals("c"))))
                return true;
            return false;
        }

        public bool ValidarCarta() 
        {
            return (ValidarNaipe() && ValidarValor());
        }

    }
}
