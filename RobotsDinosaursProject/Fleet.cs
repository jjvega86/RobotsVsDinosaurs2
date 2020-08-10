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
        public Robot robot1 = new Robot("Smasher");
        public Robot robot2 = new Robot("Metal Mouth");
        public Robot robot3 = new Robot("Rusty Bicep");



        public Fleet()
        {
            robotFleet = new List<Robot>();
            robotFleet.Add(robot1);
            robotFleet.Add(robot2);
            robotFleet.Add(robot3);
            
        }


        public void AddRobottoFleet(Robot robot)
        {
            robotFleet.Add(robot);
        }

        public void PopulateFleet()
        {
           

        }
    }
}

