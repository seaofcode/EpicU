using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Battle
    {
        private List<Card> _bounty;

        public Battle()
        {
            _bounty = new List<Card>();
        }

        public void PerformBattle(Player player1, Player player2)
        {
            Card player1Card = getCard(player1);
            Card player2Card = getCard(player2);

            performEvaluation(player1, player2, player1Card, player2Card);

        }

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
            _bounty.Clear();
        }
    }
}