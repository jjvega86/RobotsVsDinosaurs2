using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class DinosaurAttackTypes
    {
        public DinosaurAttack[] attacktypes;
        public DinosaurAttack bite = new DinosaurAttack("Bite", 2);
        public DinosaurAttack slash = new DinosaurAttack("Slash", 3);
        public DinosaurAttack stomp = new DinosaurAttack("Stomp", 4);

        public DinosaurAttackTypes()
        {
            attacktypes = new DinosaurAttack[3];
            attacktypes[0] = bite;
            attacktypes[1] = slash;
            attacktypes[2] = stomp;

        }
    }
}
