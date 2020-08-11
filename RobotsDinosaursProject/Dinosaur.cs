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
        public DinosaurAttack dinosaurAttack1;
        public DinosaurAttackTypes attackTypes1;

        //Robots will be all the same type but have different weapon choices and less energy
        //Dinosaurs will have different types with different attributes, and different in battle attack types

        public Dinosaur(string type)
        {
            this.dinosaurType = type;
            this.dinosaurHealth = 100;
            this.dinosaurEnergy = 100;
            this.dinosaurAttackPower = 50;
            dinosaurAttack1 = new DinosaurAttack("Intimidating Stare", 1);
            attackTypes1 = new DinosaurAttackTypes();
        }

        public void Attack(Robot robot)
        {
            int modifiedAttackPower = ChooseAttackType();

            robot.robotHealth -= modifiedAttackPower;
            Console.WriteLine($"Hit! {robot.robotName}'s health is down to {robot.robotHealth}.");
            Console.WriteLine("");


        }

        public int ChooseAttackType()
        {
            int index = 1;

            Console.WriteLine($"Choose {dinosaurType}'s attack!");
            Console.WriteLine("Press the number of your selection, then press enter.");
            Console.WriteLine("");

            foreach (DinosaurAttack attack in attackTypes1.attacktypes)
            {
                Console.WriteLine($"{index}: {attack.type}");
                index += 1;
            }
            int UserInput = int.Parse(Console.ReadLine());

            dinosaurAttackPower *= attackTypes1.attacktypes[UserInput - 1].multiplier;
            return dinosaurAttackPower;


        }
    }
}
