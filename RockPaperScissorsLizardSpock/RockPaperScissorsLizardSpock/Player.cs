using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        public string name;
        public string gesture;
        public int score;
        public List<string> gestureList;

        public Player()
        {
            this.gestureList = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        public virtual string ChooseGesture()
        {
            Random random = new Random();
            int randomInt = random.Next(5);
            return this.gestureList[randomInt];
        }

    }

}