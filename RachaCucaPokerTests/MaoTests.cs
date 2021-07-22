using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RachaCucaPoker.Dominio;
using RachaCucaPoker.Domino;

namespace RachaCucaPokerTests
{
    [TestClass]
    public class MaoTests
    {
        [TestMethod]
        public void DeveOrdenarTodasCartas()
        {
            Carta carta1 = new Carta("D", "9");
            Carta carta2 = new Carta("D", "8");
            Carta carta3 = new Carta("D", "Q");
            Carta carta4 = new Carta("D", "J");
            Carta carta5 = new Carta("D", "T");
            Mao mao = new Mao(carta1, carta2, carta3, carta4, carta5);
            Assert.AreEqual(carta2.Valor, mao.carta1.Valor);
            Assert.AreEqual(carta1, mao.carta2);
            Assert.AreEqual(carta5, mao.carta3);
            Assert.AreEqual(carta4, mao.carta4);
            Assert.AreEqual(carta3, mao.carta5);
        }

        [TestMethod]
        public void MaoEhRoyalFlush()
        {
            Carta carta1 = new Carta("D", "A");
            Carta carta2 = new Carta("D", "K");
            Carta carta3 = new Carta("D", "Q");
            Carta carta4 = new Carta("D", "J");
            Carta carta5 = new Carta("D", "T");
            Mao mao = new Mao(carta1, carta2, carta3, carta4, carta5);
            Assert.AreEqual(true, mao.EhRoyalFlush());
        }

        [TestMethod]
        public void EhStraightFlush()
        {
            Carta carta1 = new Carta("D", "9");
            Carta carta2 = new Carta("D", "8");
            Carta carta3 = new Carta("D", "Q");
            Carta carta4 = new Carta("D", "J");
            Carta carta5 = new Carta("D", "T");
            Mao mao = new Mao(carta1, carta2, carta3, carta4, carta5);
            Assert.AreEqual(true, mao.EhSequencia());
            //Assert.AreEqual(true, mao.EhStraightFlush());
        }

        [TestMethod]
        public void EhQuadra()
        {
            Carta carta1 = new Carta("H", "A");
            Carta carta2 = new Carta("C", "A");
            Carta carta3 = new Carta("D", "A");
            Carta carta4 = new Carta("S", "A");
            Carta carta5 = new Carta("H", "k");
            Mao mao = new Mao(carta1, carta2, carta3, carta4, carta5);
            Assert.AreEqual(true, mao.EhQuadra());
        }

        [TestMethod]
        public void EhTrinca()
        {
            Carta carta1 = new Carta("H", "A");
            Carta carta2 = new Carta("C", "A");
            Carta carta3 = new Carta("D", "A");
            Carta carta4 = new Carta("S", "t");
            Carta carta5 = new Carta("H", "k");
            Mao mao = new Mao(carta1, carta2, carta3, carta4, carta5);
            Assert.AreEqual(true, mao.EhTrinca());
        }

        [TestMethod]
        public void EhDoisPares()
        {
            Carta carta1 = new Carta("H", "A");
            Carta carta2 = new Carta("C", "2");
            Carta carta3 = new Carta("D", "A");
            Carta carta4 = new Carta("S", "2");
            Carta carta5 = new Carta("H", "k");
            Mao mao = new Mao(carta1, carta2, carta3, carta4, carta5);
            Assert.AreEqual(true, mao.EhDoisPares());
        }

        [TestMethod]
        public void EhUmPar()
        {
            Carta carta1 = new Carta("H", "A");
            Carta carta2 = new Carta("C", "2");
            Carta carta3 = new Carta("D", "A");
            Carta carta4 = new Carta("S", "t");
            Carta carta5 = new Carta("H", "k");
            Mao mao = new Mao(carta1, carta2, carta3, carta4, carta5);
            Assert.AreEqual(true, mao.EhUmPar());
        }

        [TestMethod]
        public void EhUmaCarta()
        {
            Carta carta1 = new Carta("H", "A");
            Carta carta2 = new Carta("C", "2");
            Carta carta3 = new Carta("D", "4");
            Carta carta4 = new Carta("S", "t");
            Carta carta5 = new Carta("H", "k");
            Mao mao = new Mao(carta1, carta2, carta3, carta4, carta5);
            Assert.AreEqual(true, mao.EhUmaCarta());
        }
    }
}
