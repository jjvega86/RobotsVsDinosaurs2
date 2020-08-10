using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class Robot
    {
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public Weapon weapon;

        public Robot(string name, int health, int powerLevel)
        {
            this.robotName = name;
            this.robotHealth = health;
            this.robotPowerLevel = powerLevel;
            weapon = new Weapon("laser cannon", 10);

        }
    }
}
