using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class DinosaurAttack
    {
        public string type;
        public int multiplier;

        public DinosaurAttack(string type, int multiplier)
        {
            this.type = type;
            this.multiplier = multiplier;
        }

    }
}
