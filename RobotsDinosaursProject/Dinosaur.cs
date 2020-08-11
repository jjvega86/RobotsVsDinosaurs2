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

        //Robots will be all the same type but have different weapon choices and less energy
        //Dinosaurs will have different types with different attributes, and different in battle attack types

        public Dinosaur(string type)
        {
            this.dinosaurType = type;
            this.dinosaurHealth = 100;
            this.dinosaurEnergy = 100;
            this.dinosaurAttackPower = 50;
        }

        public void Attack(Robot robot)
        {
            robot.robotHealth -= dinosaurAttackPower;

        }
    }
}
