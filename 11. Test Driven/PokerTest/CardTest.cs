using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void CardInitializationTest()
        {
            Card myCard = new Card(CardFace.Ace, CardSuit.Spades);
        }

        [TestMethod]
        public void AllCardFaceSuitInitializationTest()
        {
            Card two = new Card(CardFace.Ace, CardSuit.Clubs);
            Card three = new Card(CardFace.King, CardSuit.Clubs);
            Card four = new Card(CardFace.Queen, CardSuit.Clubs);
            Card five = new Card(CardFace.Ace, CardSuit.Clubs);
            Card six = new Card(CardFace.King, CardSuit.Clubs);
            Card seven = new Card(CardFace.Queen, CardSuit.Clubs);
            Card eight = new Card(CardFace.Ace, CardSuit.Clubs);
            Card nine = new Card(CardFace.King, CardSuit.Clubs);
            Card ten = new Card(CardFace.Queen, CardSuit.Clubs);
            Card jack = new Card(CardFace.Ace, CardSuit.Clubs);
            Card queen = new Card(CardFace.King, CardSuit.Clubs);
            Card king = new Card(CardFace.Queen, CardSuit.Clubs);
            Card ace = new Card(CardFace.Ace, CardSuit.Clubs);

            Card twoD = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card threeD = new Card(CardFace.King, CardSuit.Diamonds);
            Card fourD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card fiveD = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card sixD = new Card(CardFace.King, CardSuit.Diamonds);
            Card sevenD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card eightD = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card nineD = new Card(CardFace.King, CardSuit.Diamonds);
            Card tenD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card jackD = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card queenD = new Card(CardFace.King, CardSuit.Diamonds);
            Card kingD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card aceD = new Card(CardFace.Ace, CardSuit.Diamonds);

            Card twoH = new Card(CardFace.Ace, CardSuit.Hearts);
            Card threeH = new Card(CardFace.King, CardSuit.Hearts);
            Card fourH = new Card(CardFace.Queen, CardSuit.Hearts);
            Card fiveH = new Card(CardFace.Ace, CardSuit.Hearts);
            Card sixH = new Card(CardFace.King, CardSuit.Hearts);
            Card sevenH = new Card(CardFace.Queen, CardSuit.Hearts);
            Card eightH = new Card(CardFace.Ace, CardSuit.Hearts);
            Card nineH = new Card(CardFace.King, CardSuit.Hearts);
            Card tenH = new Card(CardFace.Queen, CardSuit.Hearts);
            Card jackH = new Card(CardFace.Ace, CardSuit.Hearts);
            Card queenH = new Card(CardFace.King, CardSuit.Hearts);
            Card kingH = new Card(CardFace.Queen, CardSuit.Hearts);
            Card aceH = new Card(CardFace.Ace, CardSuit.Hearts);

            Card twoS = new Card(CardFace.Ace, CardSuit.Spades);
            Card threeS = new Card(CardFace.King, CardSuit.Spades);
            Card fourS = new Card(CardFace.Queen, CardSuit.Spades);
            Card fiveS = new Card(CardFace.Ace, CardSuit.Spades);
            Card sixS = new Card(CardFace.King, CardSuit.Spades);
            Card sevenS = new Card(CardFace.Queen, CardSuit.Spades);
            Card eightS = new Card(CardFace.Ace, CardSuit.Spades);
            Card nineS = new Card(CardFace.King, CardSuit.Spades);
            Card tenS = new Card(CardFace.Queen, CardSuit.Spades);
            Card jackS = new Card(CardFace.Ace, CardSuit.Spades);
            Card queenS = new Card(CardFace.King, CardSuit.Spades);
            Card kingS = new Card(CardFace.Queen, CardSuit.Spades);
            Card aceS = new Card(CardFace.Ace, CardSuit.Spades);
        }
    }
}
