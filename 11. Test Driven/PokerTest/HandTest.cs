using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void PokerHandInitializationTest()
        {
            Card myCard = new Card(CardFace.Ace, CardSuit.Spades);
            Card secondCard = new Card(CardFace.King, CardSuit.Hearts);
            Card anotherCard = new Card(CardFace.Queen, CardSuit.Clubs);
            Card fourCard = new Card(CardFace.Five, CardSuit.Hearts);
            Card fiveCard = new Card(CardFace.Six, CardSuit.Diamonds);

            Hand myHand = new Hand(new List<ICard>() { myCard, secondCard, anotherCard, fourCard, fiveCard });
        }
    }
}
