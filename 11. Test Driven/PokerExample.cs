using System;
using System.Collections.Generic;

namespace Poker
{
    class PokerExample
    {
        static void Main()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Hearts),
            });

            Console.WriteLine(hand);           
        }
    }
}
