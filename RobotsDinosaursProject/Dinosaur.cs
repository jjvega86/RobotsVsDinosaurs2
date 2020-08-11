using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class Dinosaur
    {
        public string dinosaurType;
        public int dinosaurHealth;
        public int dinosaurEnergy;
        public int dinosaurAttackPower;

        public Dinosaur(string type)
        {
            this.dinosaurType = type;
            this.dinosaurHealth = 100;
            this.dinosaurEnergy = 100;
            this.dinosaurAttackPower = 20;
        }

        public void Attack(Robot robot)
        {
            robot.robotHealth -= dinosaurAttackPower;

        }
    }
}
