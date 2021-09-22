using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        public Human(string name, int score, string gesture)
        {
            this.name = name;
            this.score = score;
            this.gesture = gesture;
        }

        public override string ChooseGesture()
        {
            Console.WriteLine("Choose your gesture: Type 1 for Rock, 2 for Paper, 3 for Scissors, 4 for Lizard, or 5 for Spock");
            int gesture = Convert.ToInt32(Console.ReadLine()) - 1;
            return this.gestureList[gesture];

        }
    }
}
