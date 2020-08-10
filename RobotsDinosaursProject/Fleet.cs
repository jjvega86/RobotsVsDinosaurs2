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
        }

        public Robot CreateRobot(string name, int health, int powerLevel)
        {
            Robot robot = new Robot(name, health, powerLevel);

            return robot;

        }

        public void AddRobottoFleet(Robot robot)
        {
            robotFleet.Add(robot);
        }
    }
}
}
