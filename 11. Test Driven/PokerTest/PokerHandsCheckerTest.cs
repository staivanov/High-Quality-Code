using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTest
{
    [TestClass]
    public class PokerHandsCheckerTest
    {
        [TestMethod]
        public void CheckinitializationTest()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
        }

        [TestMethod]
        public void IsValidHandTest()
        {
            Card ten = new Card(CardFace.Queen, CardSuit.Clubs);
            Card jack = new Card(CardFace.Ace, CardSuit.Clubs);
            Card queen = new Card(CardFace.King, CardSuit.Clubs);
            Card king = new Card(CardFace.Queen, CardSuit.Clubs);
            Card ace = new Card(CardFace.Ace, CardSuit.Clubs);
            IPokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>() { ten, jack, queen, king, ace });
            bool result = checker.IsValidHand(hand);
            Assert.AreEqual(true, result);
        }
        // ** ONE PAIR **
        [TestMethod]
        public void IsOnePairTest()
        {
            Card queen = new Card(CardFace.Queen, CardSuit.Clubs);
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card king = new Card(CardFace.King, CardSuit.Clubs);
            Card queenD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card ace = new Card(CardFace.Ace, CardSuit.Diamonds);
            IPokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>() { queen, ten, king, queenD, ace });
            bool result = checker.IsOnePair(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsOnePairFalseTest()
        {
            Card two = new Card(CardFace.Two, CardSuit.Clubs);
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card king = new Card(CardFace.King, CardSuit.Clubs);
            Card queenD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card ace = new Card(CardFace.Ace, CardSuit.Diamonds);
            IPokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>() { two, ten, king, queenD, ace });
            bool result = checker.IsOnePair(hand);
            Assert.AreEqual(false, result);
        }
        // ** TWO PAIR **
        [TestMethod]
        public void IsTwoPairTest()
        {
            Card queen = new Card(CardFace.Queen, CardSuit.Clubs);
            Card queenD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card tenD = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card ace = new Card(CardFace.Ace, CardSuit.Diamonds);
            IPokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>() { queen, ten, tenD, queenD, ace });
            bool result = checker.IsTwoPair(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsTwoPairFalseTest()
        {
            Card two = new Card(CardFace.Two, CardSuit.Clubs);
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card king = new Card(CardFace.King, CardSuit.Clubs);
            Card queenD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card ace = new Card(CardFace.Ace, CardSuit.Diamonds);
            IPokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>() { two, ten, king, queenD, ace });
            bool result = checker.IsTwoPair(hand);
            Assert.AreEqual(false, result);
        }
        // ** THREE OF KIND **
        [TestMethod]
        public void IsThreeOfKindTest()
        {
            Card queen = new Card(CardFace.Queen, CardSuit.Clubs);
            Card queenD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card queenS = new Card(CardFace.Queen, CardSuit.Spades);
            Card tenD = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card ace = new Card(CardFace.Ace, CardSuit.Diamonds);
            IPokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>() { queen, queenS, tenD, queenD, ace });
            bool result = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsThreeOfKindFalseTest()
        {
            Card two = new Card(CardFace.Two, CardSuit.Clubs);
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card king = new Card(CardFace.King, CardSuit.Clubs);
            Card queenD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card ace = new Card(CardFace.Ace, CardSuit.Diamonds);
            IPokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>() { two, ten, king, queenD, ace });
            bool result = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(false, result);
        }

        // ** FOUR OF KIND **
        [TestMethod]
        public void IsFourOfKindTest()
        {
            Card queen = new Card(CardFace.Queen, CardSuit.Clubs);
            Card queenD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card queenS = new Card(CardFace.Queen, CardSuit.Spades);
            Card queenH = new Card(CardFace.Queen, CardSuit.Hearts);
            Card ace = new Card(CardFace.Ace, CardSuit.Diamonds);
            IPokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>() { queen, queenS, queenH, queenD, ace });
            bool result = checker.IsFourOfAKind(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsFourOfKindFalseTest()
        {
            Card two = new Card(CardFace.Two, CardSuit.Clubs);
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card king = new Card(CardFace.King, CardSuit.Clubs);
            Card queenD = new Card(CardFace.Queen, CardSuit.Diamonds);
            Card ace = new Card(CardFace.Ace, CardSuit.Diamonds);
            IPokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>() { two, ten, king, queenD, ace });
            bool result = checker.IsFourOfAKind(hand);
            Assert.AreEqual(false, result);
        }

        // ** FLUSH **
        [TestMethod]
        public void IsFlushTest()
        {
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card jack = new Card(CardFace.Jack, CardSuit.Clubs);
            Card queen = new Card(CardFace.Queen, CardSuit.Clubs);
            Card two = new Card(CardFace.Two, CardSuit.Clubs);
            Card ace = new Card(CardFace.Ace, CardSuit.Clubs);
            Hand hand = new Hand(new List<ICard>() { ten, jack, queen, two, ace });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsFlush(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsFlushFalseTest()
        {
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card jack = new Card(CardFace.Jack, CardSuit.Clubs);
            Card queen = new Card(CardFace.Queen, CardSuit.Clubs);
            Card king = new Card(CardFace.King, CardSuit.Clubs);
            Card ace = new Card(CardFace.Ace, CardSuit.Diamonds);
            Hand hand = new Hand(new List<ICard>() { ten, jack, queen, king, ace });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsFlush(hand);
            Assert.AreEqual(false, result);
        }

        // ** STRAIGHT FLUSH **
        [TestMethod]
        public void IsStraightFlushTest()
        {
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card jack = new Card(CardFace.Jack, CardSuit.Clubs);
            Card queen = new Card(CardFace.Queen, CardSuit.Clubs);
            Card king = new Card(CardFace.King, CardSuit.Clubs);
            Card ace = new Card(CardFace.Ace, CardSuit.Clubs);
            Hand hand = new Hand(new List<ICard>() { ten, jack, queen, king, ace });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsStraightFlush(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsStraightFlushFalseTest()
        {
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card jack = new Card(CardFace.Jack, CardSuit.Diamonds);
            Card queen = new Card(CardFace.Queen, CardSuit.Clubs);
            Card king = new Card(CardFace.King, CardSuit.Clubs);
            Card ace = new Card(CardFace.Ace, CardSuit.Clubs);
            Hand hand = new Hand(new List<ICard>() { ten, jack, queen, king, ace });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsStraightFlush(hand);
            Assert.AreEqual(false, result);
        }

        // ** STRAIGHT **
        [TestMethod]
        public void IsStraightTest()
        {
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card jack = new Card(CardFace.Jack, CardSuit.Hearts);
            Card queen = new Card(CardFace.Queen, CardSuit.Spades);
            Card king = new Card(CardFace.King, CardSuit.Clubs);
            Card ace = new Card(CardFace.Ace, CardSuit.Diamonds);
            Hand hand = new Hand(new List<ICard>() { ten, jack, queen, king, ace });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsStraight(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsStraightFalseTest()
        {
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card jack = new Card(CardFace.Jack, CardSuit.Diamonds);
            Card two = new Card(CardFace.Two, CardSuit.Clubs);
            Card king = new Card(CardFace.King, CardSuit.Clubs);
            Card ace = new Card(CardFace.Ace, CardSuit.Clubs);
            Hand hand = new Hand(new List<ICard>() { ten, jack, two, king, ace });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsStraight(hand);
            Assert.AreEqual(false, result);
        }

        // ** FULL HOUSE **
        [TestMethod]
        public void FullHouseTest()
        {
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card tenD = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card tenS = new Card(CardFace.Ten, CardSuit.Spades);
            Card aceD = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card ace = new Card(CardFace.Ace, CardSuit.Clubs);
            Hand hand = new Hand(new List<ICard>() { ten, tenD, tenS, aceD, ace });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsFullHouse(hand);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void FullHouseFalseTest()
        {
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card tenD = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card tenS = new Card(CardFace.Ten, CardSuit.Spades);
            Card king = new Card(CardFace.King, CardSuit.Diamonds);
            Card ace = new Card(CardFace.Ace, CardSuit.Clubs);
            Hand hand = new Hand(new List<ICard>() { ten, tenD, tenS, king, ace });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsFullHouse(hand);
            Assert.AreEqual(false, result);
        }

        // ** HiGH CARD **
        [TestMethod]
        public void HighCardTest()
        {
            Card ace = new Card(CardFace.Ace, CardSuit.Spades);
            Card ten = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card queen = new Card(CardFace.Queen, CardSuit.Spades);
            Card aceD = new Card(CardFace.Two, CardSuit.Diamonds);
            Card three = new Card(CardFace.Three, CardSuit.Clubs);
            Hand hand = new Hand(new List<ICard>() { three, ten, queen, aceD, ace });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsHighCard(hand);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void HighCardFalseTest()
        {
            Card ten = new Card(CardFace.Ten, CardSuit.Clubs);
            Card tenD = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card tenS = new Card(CardFace.Ten, CardSuit.Spades);
            Card king = new Card(CardFace.King, CardSuit.Diamonds);
            Card ace = new Card(CardFace.Ace, CardSuit.Clubs);
            Hand hand = new Hand(new List<ICard>() { ten, tenD, tenS, king, ace });
            IPokerHandsChecker checker = new PokerHandsChecker();
            bool result = checker.IsHighCard(hand);
            Assert.AreEqual(false, result);
        }

    }
}
