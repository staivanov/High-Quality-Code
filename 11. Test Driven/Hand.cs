﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.Cards)
            {
                sb.Append(item.Face + " ");
            }

            return String.Format("{0}", sb);
          
        }
    }
}
