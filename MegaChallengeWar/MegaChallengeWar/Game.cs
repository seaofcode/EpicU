﻿using System;
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
        private List<Card> _bounty;


        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player() { Name = player1Name};
            _player2 = new Player() { Name = player2Name };
            _bounty = new List<Card>();
        }

        public string Play()
        {
            Deck deck = new Deck();
            string result = deck.Deal(_player1, _player2);

            int round = 0;
            while (_player1.Cards.Count != 0 && _player2.Cards.Count != 0)
            {
                Card player1Card = getCard(_player1);
                Card player2Card = getCard(_player2);

                performEvaluation(_player1, _player2, player1Card, player2Card);

                round++;
                if (round > 20)
                    break;
            }
            result += determineWinner();
            return result;
        }


       

        private string determineWinner()
        {
            string result = "";
            if (_player1.Cards.Count > _player2.Cards.Count)
                result += "<br/> Player 1 Wins";
            else
                result += "<br/> Player 2 Wins";
            
            result += "<br/>Player1: " + _player1.Cards.Count + " Player2: " + _player2.Cards.Count;
            return result;
        }
    }
}