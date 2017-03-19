using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace BlackJack.Tests.Given_Deck
{
    [TestClass]
    public class When_initialized : Scenario
    {
        private Deck _deck;
        public override void When()
        {
            _deck = new Deck();
        }

        [Then]
        public void Should_have_52_cards()
        {
            Assert.AreEqual(52, _deck.Cards.Count);
        }

        [Then]
        public void Should_have_4_distinct_suits()
        {
            Assert.AreEqual(4, _deck.Cards.Select(x => (int)x.Suit).Distinct().ToList().Count);
        }
    }
}
