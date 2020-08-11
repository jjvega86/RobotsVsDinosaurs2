using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class Robot
    {
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public int robotAttackPower;
        public int modifiedAttackPower;
        public Weapon weapon;
        public Armory armory;

        //Robots will be all the same type but have different weapon choices and less energy
        //Dinosaurs will have different types with different attributes, and different in battle attack types

        public Robot(string name)
        {
            this.robotName = name;
            this.robotHealth = 100;
            this.robotPowerLevel = 20;
            weapon = new Weapon("robo punch", 1); //default weapon is a punch that adds no multiplier. Standard attack power
            armory = new Armory();
            this.robotAttackPower = 20;
            this.modifiedAttackPower = robotAttackPower;

        }

        public void ChooseWeapon()
        {
            
            //Instead of assigning the weapon by trying to change the weapon, just
            //change the attack modifier

            int index = 1;
            
            Console.WriteLine($"Choose {robotName}'s weapon!");
            Console.WriteLine("Press the number of your selection, then press enter.");


            foreach (Weapon weapon in armory.armory)
            {
                Console.WriteLine($"{index}: {weapon.type}");
                index += 1;
            }
            int UserInput = int.Parse(Console.ReadLine());
            Console.WriteLine("");


            robotAttackPower *= armory.armory[UserInput - 1].multiplier; 

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

        public void Attack(Dinosaur dinosaur)
        {
            bool attackRoll = RollforAttack();

            if (attackRoll == true)
            {
                modifiedAttackPower = DrainEnergyAndRecharge();
                dinosaur.dinosaurHealth -= modifiedAttackPower;

                if (dinosaur.dinosaurHealth <= 0)
                {
                    dinosaur.dinosaurHealth = 0;
                    Console.WriteLine($"Oh no! {dinosaur.dinosaurType} is dead.");
                    Console.WriteLine("");
                }
                else if (modifiedAttackPower == 0)
                {
                    Console.WriteLine($"{robotName} is too tired to attack!");
                    Console.WriteLine("");

                }
                else
                {
                    Console.WriteLine($"Hit! {dinosaur.dinosaurType}'s health is down to {dinosaur.dinosaurHealth}.");
                    Console.WriteLine("");
                }

            }
            else
            {
                Console.WriteLine($"{robotName} failed to attack!");
            }

            

            

        }

        public int DrainEnergyAndRecharge()
        {
            //Every time Robot attacks, Robot's Energy goes down.
            //When Energy reaches 0, Robot must recharge. Recharging means that Robot must
            //skip the next round before being able to attack again.

            if (robotPowerLevel > 0)
            {
                robotPowerLevel -= 10;

            }
            else
            {
                robotPowerLevel = 20;
            }

            if (robotPowerLevel == 0)
            {
                modifiedAttackPower = 0;
            }
            else
            {
                modifiedAttackPower = robotAttackPower; //resets attack power in case it was previously set to 0
            }

            return modifiedAttackPower;
        }
    }
}
