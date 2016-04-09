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
                Card player1Card = _player1.Cards.ElementAt(0);
                Card player2Card = _player2.Cards.ElementAt(0);
            }
        }
    }
}