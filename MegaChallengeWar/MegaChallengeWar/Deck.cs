using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MegaChallengeWar
{
    public class Deck
    {
        private List<Card> _deck;
        private Random _random;
        private StringBuilder sb;

        //Constructor
        public Deck()
        {
            _deck = new List<Card>();
            _random = new Random();
            sb = new StringBuilder();

            string[] suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] kinds = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};

            foreach (var suit in suits)
            {
                foreach (var kind in kinds)
                {
                    _deck.Add(new Card() {Suit = suit, Kind = kind });
                }
            }
        } 

        public string Deal(Player player1, Player player2)
        {
            while (_deck.Count > 0)
            {
                dealCard(player1);
                dealCard(player2);
            }
            return sb.ToString();
        }

        private void dealCard(Player player)
        {
            Card card = _deck.ElementAt(_random.Next(_deck.Count));
            player.Cards.Add(card);
            _deck.Remove(card);

            sb.Append("</br>");
            sb.Append(player.Name);
            sb.Append("is dealt ");
            sb.Append(card.Kind);
            sb.Append(" of ");
            sb.Append(card.Suit);
        }
    }
}