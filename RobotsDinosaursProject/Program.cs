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
            Battlefield robotdinosaurbattle = new Battlefield();
            robotdinosaurbattle.BattleIntroduction();
            robotdinosaurbattle.PrintBattleResult(robotdinosaurbattle.EngageBattle());

        }
    }
}
