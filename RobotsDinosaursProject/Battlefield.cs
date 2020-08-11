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

        public void BattleIntroduction()
        {
            Console.WriteLine("Welcome to Robots vs. Dinosaurs!");
            Console.WriteLine("Excitement and adventure await! Who will win in a fight? Dinosaurs? Robots?");
            Console.WriteLine("It's the question of the century, and you're about to find out the answer!");
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine("");
            Console.ReadLine();
        }

        public bool StartingRoll()
        {
            Random robotDice = new Random();
            Random dinosaurDice = new Random();
            bool robotsStart;

            if (robotDice.Next(21) > dinosaurDice.Next(21))
            {
                robotsStart = true;
            }
            else
            {
                robotsStart = false;
            }



            return robotsStart;

        }

        public string EngageBattle()
        {
            fleet1.AssignWeapons();

            Console.WriteLine("Excellent. All robots are assigned weapons!");
            Console.WriteLine("Each round, dinosaurs will be able to pick their attack.");
            Console.WriteLine("May the best fantasy combatant win!");
            Console.WriteLine("");
            Console.ReadLine();

            

            while (fleet1.robotFleet.Count != 0 && herd1.dinosaurHerd.Count != 0)
            {
                bool robotsStart = StartingRoll();

                if (robotsStart == true)
                {
                    Console.WriteLine("Robots go first this round!");
                    Console.WriteLine("");
                    fleet1.robotFleet[0].Attack(herd1.dinosaurHerd[0]);
                    herd1.dinosaurHerd[0].Attack(fleet1.robotFleet[0]);


                    if (herd1.dinosaurHerd[0].dinosaurHealth <= 0)
                    {
                        herd1.dinosaurHerd.RemoveAt(0);

                    }

                    if (fleet1.robotFleet[0].robotHealth <= 0)
                    {
                        fleet1.robotFleet.RemoveAt(0);
                    }

                }
                else
                {
                    Console.WriteLine("Dinosaurs go first this round!");
                    Console.WriteLine("");
                    herd1.dinosaurHerd[0].Attack(fleet1.robotFleet[0]);
                    fleet1.robotFleet[0].Attack(herd1.dinosaurHerd[0]);

                    if (herd1.dinosaurHerd[0].dinosaurHealth <= 0)
                    {
                        herd1.dinosaurHerd.RemoveAt(0);

                    }

                    if (fleet1.robotFleet[0].robotHealth <= 0)
                    {
                        fleet1.robotFleet.RemoveAt(0);
                    }

                }
               

            }

            string winningTeam;

            if (fleet1.robotFleet.Count == 0)
            {
                winningTeam = "Dinosaurs";
            }
            else
            {
                winningTeam = "Robots";
            }


            return winningTeam;
        }

        public void PrintBattleResult(string winningTeam)
        {
            Console.WriteLine("");
            Console.WriteLine($"{winningTeam} win!");
            Console.ReadLine();
        }
    }
}
