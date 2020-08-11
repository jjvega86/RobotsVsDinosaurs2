using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class Armory
    {
        public List<Weapon> armory;
        public Weapon sword = new Weapon("Sword", 2);
        public Weapon pulsarcannon = new Weapon("Pulsar Cannon", 3);
        public Weapon sonicwave = new Weapon("Sonic Wave", 4);

        public Armory()
        {
            armory = new List<Weapon>();
            armory.Add(sonicwave);
            armory.Add(sword);
            armory.Add(pulsarcannon);
        }
    }
}
