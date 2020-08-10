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
        public Robot robot1 = new Robot("Smasher", 100, 100);
        public Robot robot2 = new Robot("Metal Mouth", 100, 100);
        public Robot robot3 = new Robot("Rusty Bicep", 100, 100);



        public Fleet()
        {
            robotFleet = new List<Robot>();
            robotFleet.Add(robot1);
            robotFleet.Add(robot2);
            robotFleet.Add(robot3);
            
        }

        //public Robot CreateRobot(string name, int health, int powerLevel)
        //{
        //    Robot robot = new Robot(name, health, powerLevel);

        //    return robot;

        //}
        //Probably don't need this method if the user is always given set options to choose from


        public void AddRobottoFleet(Robot robot)
        {
            robotFleet.Add(robot);
        }

        public void PopulateFleet()
        {
           

        }
    }
}

