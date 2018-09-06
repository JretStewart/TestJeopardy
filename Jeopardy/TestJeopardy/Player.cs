using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJeopardy
{
    public class Player
    {
        String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public Player(String n)
        {
            Name = n;
        }

        public void updateScore(int amt)
        {
            Score = Score + amt;
        }
    }
}
