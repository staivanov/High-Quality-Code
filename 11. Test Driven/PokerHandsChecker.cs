using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const byte CARDS_NUMBER = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count == CARDS_NUMBER)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool IsStraightFlush(IHand hand)
        {

            bool isItStraght = IsStraight(hand);
            bool isItFlush = IsFlush(hand);

            if ((isItFlush && isItStraght) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsFourOfAKind(IHand hand)
        {
            byte counter = 0;
            byte fourOfKind = 3;

            List<byte> cd = new List<byte>();

            foreach (var item in hand.Cards)
            {
                cd.Add((byte)item.Face);
            }

            cd.Sort();

            if (cd[0] < cd[1])
            {
                for (int i = 2; i < cd.Count; i++)
                {
                    if (cd[1] == cd[i])
                    {
                        counter++;
                    }
                }
            }
            else if (cd[0] >= cd[1])
            {
                for (int i = 1; i < cd.Count; i++)
                {
                    if (cd[0] == cd[i])
                    {
                        counter++;
                    }
                }
            }

            if (counter == fourOfKind)
            {
                return true;
            }

            return false;

        }

        public bool IsFullHouse(IHand hand)
        {
            HashSet<CardFace> cardFaceToNumber = new HashSet<CardFace>();
            HashSet<CardSuit> cardSuitToNumber = new HashSet<CardSuit>();

            foreach (var card in hand.Cards)
            {
                cardFaceToNumber.Add(card.Face);
                cardSuitToNumber.Add(card.Suit);
            }

            var cardSuitToNumberCount = cardSuitToNumber.Count;
            var cardFaceToNumberCount = cardFaceToNumber.Count;


            if ((cardSuitToNumberCount > 1) && (cardFaceToNumberCount == 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFlush(IHand hand)
        {
            bool isFlush = true;

            for (int cardPosition = 1; cardPosition < hand.Cards.Count; cardPosition++)
            {
                if (hand.Cards[0].Suit != hand.Cards[cardPosition].Suit)
                {
                    isFlush = false;
                }
            }

            return isFlush;
        }

        public bool IsStraight(IHand hand)
        {

            bool straight = false;

            List<int> cd = new List<int>();

            foreach (var item in hand.Cards)
            {
                cd.Add((int)item.Face);
            }
            cd.Sort();

            for (int i = 1; i < cd.Count; i++)
            {
                if ((cd[i] - cd[0]) == i)
                {
                    straight = true;
                }
                else
                {
                    return false;
                }
            }

            return straight;
        }

        public bool IsThreeOfAKind(IHand hand)
        { //Algorithm for Three of Kind is  the same as One Pair, but counter need to be 3, because two matches.
            bool isItThreePair = true;
            byte counter = 0;
            byte ThreePair = 3;

            for (int cardPosition = 0; cardPosition < hand.Cards.Count; cardPosition++)
            {
                for (int i = cardPosition + 1; i < hand.Cards.Count; i++)
                {
                    if (hand.Cards[cardPosition].Face == hand.Cards[i].Face)
                    {
                        counter++;
                    }
                }
            }

            if (ThreePair == counter)
            {
                return isItThreePair;
            }
            else
            {
                return isItThreePair = false;
            }

        }

        public bool IsTwoPair(IHand hand)
        { //Algorithm for TwoPair is  the same as One Pair, but counter need to be 2, because two matches.
            bool isItTwoPair = true;
            byte counter = 0;
            byte TwoPair = 2;

            for (int cardPosition = 0; cardPosition < hand.Cards.Count; cardPosition++)
            {
                for (int i = cardPosition + 1; i < hand.Cards.Count; i++)
                {
                    if (hand.Cards[cardPosition].Face == hand.Cards[i].Face)
                    {
                        counter++;
                    }
                }
            }

            if (TwoPair == counter)
            {
                return isItTwoPair;
            }
            else
            {
                return isItTwoPair = false;
            }

        }

        public bool IsOnePair(IHand hand)
        {
            bool isItOnePair = true;
            byte counter = 0;
            byte onePair = 1;

            for (int cardPosition = 0; cardPosition < hand.Cards.Count; cardPosition++)
            {
                for (int i = cardPosition + 1; i < hand.Cards.Count; i++)
                {
                    if (hand.Cards[cardPosition].Face == hand.Cards[i].Face)
                    {
                        counter++;
                    }
                }
            }

            if (onePair == counter)
            {
                return isItOnePair;
            }
            else
            {
                return isItOnePair = false;
            }

        }

        public bool IsHighCard(IHand hand)
        {
            bool isItOnePair = IsOnePair(hand);
            bool isItTwoPair = IsTwoPair(hand);
            bool isItThreeOfKind = IsThreeOfAKind(hand);
            bool isItStraight = IsStraight(hand);
            bool isItFlush = IsFlush(hand);
            bool isItFullHouse = IsFullHouse(hand);
            bool isItFourOfKind = IsFourOfAKind(hand);
            bool isItStraightFlush = IsStraightFlush(hand);

            if ((isItOnePair || isItTwoPair || isItThreeOfKind || isItStraight || isItFlush || isItFullHouse || isItFourOfKind || isItStraightFlush) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
