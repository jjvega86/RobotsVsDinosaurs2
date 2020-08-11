using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class Weapon
    {
        //A weapon is a multiplier (1, 1.5., 2, etc) that multiplies robot attack power
        public string type;
        public int multiplier;

        public Weapon(string type, int multiplier)
        {
            this.type = type;
            this.multiplier = multiplier;
        }
    }
}
