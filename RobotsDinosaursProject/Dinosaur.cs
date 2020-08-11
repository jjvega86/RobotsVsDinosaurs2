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
        public int dinosaurDefaultAttackPower;
        public DinosaurAttack dinosaurAttack1;
        public DinosaurAttackTypes attackTypes1;

        //Robots will be all the same type but have different weapon choices and less energy
        //Dinosaurs will have different types with different attributes, and different in battle attack types

        public Dinosaur(string type)
        {
            this.dinosaurType = type;
            this.dinosaurHealth = 100;
            this.dinosaurEnergy = 20;
            this.dinosaurAttackPower = 20;
            dinosaurDefaultAttackPower = this.dinosaurAttackPower;
            dinosaurAttack1 = new DinosaurAttack("Intimidating Stare", 1);
            attackTypes1 = new DinosaurAttackTypes();
        }

        public int ChooseAttackType()
        {
            int index = 1;

            Console.WriteLine($"Choose {dinosaurType}'s attack!");
            Console.WriteLine("Press the number of your selection, then press enter.");

            foreach (DinosaurAttack attack in attackTypes1.attacktypes)
            {
                Console.WriteLine($"{index}: {attack.type}");
                index += 1;
            }
            int UserInput = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            dinosaurAttackPower *= attackTypes1.attacktypes[UserInput - 1].multiplier;
            return dinosaurAttackPower;


        }

        public bool RollforAttack()
        {
            Random random = new Random();
            bool attackSuccess;

            if (random.Next(21) > 10)
            {
                attackSuccess = true;
            }
            else
            {
                attackSuccess = false;
            }

            return attackSuccess;

        }

        public void Attack(Robot robot)
        {
            bool attackRoll = RollforAttack();

            if(attackRoll == true)
            {
                dinosaurAttackPower = ChooseAttackType();
                dinosaurAttackPower = DrainEnergyAndRest();

                robot.robotHealth -= dinosaurAttackPower;

                if (robot.robotHealth <= 0) //never display less than 0 as health to the user
                {
                    robot.robotHealth = 0;
                    Console.WriteLine($"Oh no! {robot.robotName} is destroyed.");
                    Console.WriteLine("");
                }
                else if (dinosaurAttackPower == 0)
                {
                    Console.WriteLine($"{dinosaurType} is too tired to attack!");
                    Console.WriteLine("");

                }
                else
                {
                    Console.WriteLine($"Hit! {robot.robotName}'s health is down to {robot.robotHealth}.");
                    Console.WriteLine("");

                }


                dinosaurAttackPower = dinosaurDefaultAttackPower; //this keeps from compounding the attack multipliers over iterations

            }

            else
            {
                Console.WriteLine($"{dinosaurType} failed to attack!");

            }





        }

        public int DrainEnergyAndRest()
        {
            //Every time Dinosaur attacks, Dinosaur's Energy goes down.
            //When Energy reaches 0, Dinosaur must rest. Resting means that Dinosaur must
            //skip the next round before being able to attack again.

            if (dinosaurEnergy > 0)
            {
                dinosaurEnergy -= 10;

            }
            else
            {
                dinosaurEnergy = 20;
            }

            if (dinosaurEnergy == 0)
            {
                dinosaurAttackPower = 0;
            }

            return dinosaurAttackPower;
        }

        
    }
}
