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

        public void PopulateBattlefield()
        {
            fleet1.AddRobottoFleet(fleet1.CreateRobot("Smasher", 100, 100)); //fleet[0]
            fleet1.AddRobottoFleet(fleet1.CreateRobot("Metal Mouth", 100, 100)); //fleet[1]
            fleet1.AddRobottoFleet(fleet1.CreateRobot("Rusty Bicep", 100, 100)); //fleet[2]

            herd1.AddDinosaurToHerd(herd1.CreateDinosaur("T-Rex", 100, 100, 20)); //herd[0]
            herd1.AddDinosaurToHerd(herd1.CreateDinosaur("Stegga", 100, 100, 20)); //herd[1]
            herd1.AddDinosaurToHerd(herd1.CreateDinosaur("Raptor", 100, 100, 20)); //herd[2]

        }

        public string EngageBattle()
        {

            //As a developer, I want a Robot to have the ability to attack a Dinosaur and a Dinosaur
            //to have the ability to attack a robot on a Battlefield

            string winningTeam = "Robots";

            return winningTeam;
        }

        public void PrintBattleResult(string winningTeam)
        {
            Console.WriteLine($"{winningTeam} wins!");
            Console.ReadLine();
        }
    }
}
