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
        public int robotAttackPower;
        public Weapon weapon;

        public Robot(string name)
        {
            this.robotName = name;
            this.robotHealth = 100;
            this.robotPowerLevel = 100;
            this.robotAttackPower = 50;
            weapon = new Weapon("laser cannon", 10); //a weapon can add a multiplier variable to increase attack power

        }
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.dinosaurHealth -= robotAttackPower;

        }
    }
}
