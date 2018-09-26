using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Card
    {
        private string _suit;
        private string _value;
        public int Point
        {
            get
            {
                if (_value != null)
                {
                    switch (_value)
                    {
                        case "Two":
                            return 2;
                        case "Three":
                            return 3;
                        case "Four":
                            return 4;
                        case "Five":
                            return 5;
                        case "Six":
                            return 6;
                        case "Seven":
                            return 7;
                        case "Eight":
                            return 8;
                        case "Nine":
                            return 9;
                        default:
                            return 10;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public Card(string value, string suit)
        {
            this._value = value;
            this._suit = suit;
        }

        public bool IsAce()
        {
            if(this._value.Equals("Ace"))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return _value + " of " + _suit + "\t";
        }
    }
}
