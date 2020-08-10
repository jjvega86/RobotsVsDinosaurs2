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

        public Robot(string name)
        {
            this.robotName = name;
            this.robotHealth = 100;
            this.robotPowerLevel = 100;
            weapon = new Weapon("laser cannon", 10);

        }
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.dinosaurHealth -= robotPowerLevel;

        }
    }
}
