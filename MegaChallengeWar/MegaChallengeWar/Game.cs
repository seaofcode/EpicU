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

        public Game(Player player1, Player player2)
        {
            _player1 = new Player() { Name = player1.Name};
            _player2 = new Player() { Name = player2.Name };
        }

        public string Play()
        {
            Deck deck = new Deck();
            return deck.Deal(_player1, _player2);
        }
    }
}