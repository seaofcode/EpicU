using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MegaChallengeWar
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player() { Name = player1Name};
            _player2 = new Player() { Name = player2Name };
        }

        public string Play()
        {
            Deck deck = new Deck();
            return deck.Deal(_player1, _player2);

            while (_player1.Cards.Count != 0 && _player2.Cards.Count != 0)
            {
                Card player1Card = getCard(_player1);
                Card player2Card = getCard(_player2);
            

            }
        }

        private List<Card> _bounty;

        private Card getCard(Player player)
        {
            Card card = player.Cards.ElementAt(0);
            player.Cards.Remove(card);
            _bounty.Add(card);
            return card;
        }

        private void performEvaluation(Player player1, Player player2, Card card1, Card card2)
        {
            if (card1.CardValue() > card2.CardValue())
                player1.Cards.AddRange(_bounty);
            else
                player2.Cards.AddRange(_bounty);
        }
    }
}