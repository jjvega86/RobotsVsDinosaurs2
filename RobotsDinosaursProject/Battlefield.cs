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

        public string EngageBattle()
        {
            fleet1.AssignWeapons();


            string winningTeam = " ";

            while (fleet1.robotFleet.Count != 0 && herd1.dinosaurHerd.Count != 0)
            {
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
