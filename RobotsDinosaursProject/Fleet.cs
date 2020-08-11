using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class Fleet
    {
        public List<Robot> robotFleet;
       
        public Fleet()
        {
            robotFleet = new List<Robot>();
            robotFleet.Add(new Robot("Smasher"));
            robotFleet.Add(new Robot("Metal Mouth"));
            robotFleet.Add(new Robot("Rusty Bicep"));
            
        }

        public void AssignWeapons()
        {
            Console.WriteLine("First, let's start with the Robots. For each robot in your fleet, choose their weapon!");
            Console.WriteLine("Please press enter to continue.");
            Console.WriteLine("");
            Console.ReadLine();
            foreach (Robot robot in robotFleet)
            {
                
                robot.ChooseWeapon();
                

            }
            
        }


        public void AddRobottoFleet(Robot robot)
        {
            robotFleet.Add(robot);
        }

    }
}

