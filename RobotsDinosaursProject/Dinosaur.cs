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

        public Dinosaur(string type, int health, int energy, int attackPower)
        {
            this.dinosaurType = type;
            this.dinosaurHealth = health;
            this.dinosaurEnergy = energy;
            this.dinosaurAttackPower = attackPower;
        }
    }
}
