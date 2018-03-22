//this is to denote that i edited the file. man, that sure is edited!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSerialization
{
    public class Game
    {
        public string teamOne { get; set; }
        public string teamTwo { get; set; }
        public int team1Score { get; set; }
        public int team2Score { get; set; }

        public Game() { }

        public Game(string teamOne, int team1Score, string teamTwo, int team2Score)
        {
            this.teamOne = teamOne;
            this.teamTwo = teamTwo;
            this.team1Score = team1Score;
            this.team2Score = team2Score;
        }

        public override string ToString()
        {
            return "Results: " + teamOne + " (" + team1Score + ")" + " - " + teamTwo + " (" + team2Score + ")";
        }
        
//this is another modification for step 10

    }
}
