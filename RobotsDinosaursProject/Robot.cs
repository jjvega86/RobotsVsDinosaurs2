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
        public Weapon weapon;
        public Armory armory1;

        //Robots will be all the same type but have different weapon choices and less energy
        //Dinosaurs will have different types with different attributes, and different in battle attack types

        public Robot(string name)
        {
            this.robotName = name;
            this.robotHealth = 100;
            this.robotPowerLevel = 100;
            weapon = new Weapon("laser cannon", 1); //default weapon is a laser cannon that adds no multiplier. Standard attack power
            armory1 = new Armory();
            this.robotAttackPower = 10;

        }

        public void ChooseWeapon()
        {
            
            //Instead of assigning the weapon by trying to change the weapon, just
            //change the attack modifier

            int index = 1;
            
            Console.WriteLine($"Choose {robotName}'s weapon!");
            Console.WriteLine("Press the number of your selection, then press enter.");
            Console.WriteLine("");


            foreach (Weapon weapon in armory1.armory)
            {
                Console.WriteLine($"{index}: {weapon.type}");
                index += 1;
            }
            int UserInput = int.Parse(Console.ReadLine());

            robotAttackPower *= armory1.armory[UserInput - 1].multiplier; 

        }

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.dinosaurHealth -= robotAttackPower;
            Console.WriteLine($"Hit! {dinosaur.dinosaurType}'s health is down to {dinosaur.dinosaurHealth}.");
            Console.WriteLine("");



        }
    }
}
