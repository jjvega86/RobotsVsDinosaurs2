﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Battlefield robotdinosaurbattle = new Battlefield();
            //robotdinosaurbattle.PrintBattleResult(robotdinosaurbattle.EngageBattle());

            Robot robot1 = new Robot("Dalek");
            robot1.ChooseWeapon();

        }
    }
}
