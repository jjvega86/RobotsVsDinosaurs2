using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class Battlefield
    {
        public Fleet fleet1;
        public Herd herd1;

        public Battlefield()
        {
            fleet1 = new Fleet();
            herd1 = new Herd();

        }

        public void ChooseYourTeam() 
        {
            //How can I make this a user option to pick which type of robot or dinosaur
            //they want to add to their fleets/herds?




        }

        public string EngageBattle()
        {

            //As a developer, I want a Robot to have the ability to attack a Dinosaur and a Dinosaur
            //to have the ability to attack a robot on a Battlefield
            //As a developer, I want to pick a Robot and a Dinosaur at random to fight each other from the lists.
            //As a developer, I want them to attack each other, and based on a random roll, have one win and take
            //health from the other based on their attack power
            //As a developer, I want losing combatants to no longer be an option to fight
            //As a developer, I want the last one standing to be shown as the winning team

            string winningTeam = "Robots";
            int robotDice = 0;
            int dinosaurDice = 0;
            int robotSelection = 0;
            int dinosaurSelection = 0;
            //A random roll will determine which dinosaur and which robot gets selected to fight
            //A different random roll determines which one gets to damage the other

            for (int index = 0 )

            

            return winningTeam;
        }

        public void PrintBattleResult(string winningTeam)
        {
            Console.WriteLine($"{winningTeam} win!");
            Console.ReadLine();
        }
    }
}
