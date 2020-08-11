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
            this.robotAttackPower = 50;
            weapon = new Weapon("laser cannon", 1);
            //default weapon is a laser cannon that adds no multiplier. Standard attack power
            armory1 = new Armory();

        }

        public void ChooseWeapon()
        {
            //I want to display a list of options for the user to choose from
            //Then, based on their typed in choice, I want to assign that weapon
            //to the robot in question

            int index = 1;
            

            Console.WriteLine($"Choose {robotName}'s weapon!");
            Console.WriteLine("Press the number of your selection, then press enter.");
            
            foreach (Weapon weapon in armory1.armory)
            {
                Console.WriteLine($"{index}: {weapon.type}");
                index += 1;
            }
            int UserInput = int.Parse(Console.ReadLine());

            weapon = armory1.armory[UserInput - 1];

        }

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.dinosaurHealth -= robotAttackPower;

        }
    }
}
