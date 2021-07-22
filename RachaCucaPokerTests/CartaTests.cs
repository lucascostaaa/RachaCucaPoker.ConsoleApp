using Microsoft.VisualStudio.TestTools.UnitTesting;
using RachaCucaPoker.Domino;
using System;

namespace RachaCucaPokerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CartaComNaipeValido()
        {
            Carta carta = new Carta("D", "A");
            Assert.AreEqual(true, carta.ValidarNaipe());
        }

        [TestMethod]
        public void CartaComNaipeInvalido()
        {
            Carta carta = new Carta("2", "1");
            Assert.AreEqual(false, carta.ValidarNaipe());
        }

        [TestMethod]
        public void CartaComValorValido()
        {
            Carta carta = new Carta("D", "A");
            Assert.AreEqual(true, carta.ValidarValor());
        }

        [TestMethod]
        public void CartaComValorInvalido()
        {
            Carta carta = new Carta("D", "M");
            Assert.AreEqual(false, carta.ValidarValor());
        }

        [TestMethod]
        public void CartaValida()
        {
            Carta carta = new Carta("D","2");
            Assert.AreEqual(true, carta.ValidarCarta());
        }

        [TestMethod]
        public void CartaInvalida()
        {
            Carta carta = new Carta("X", "Z");
            Assert.AreEqual(false, carta.ValidarCarta());
        }
    }
}
