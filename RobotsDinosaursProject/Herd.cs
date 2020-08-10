using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaursProject
{
    class Herd
    {
        public List<Dinosaur> dinosaurHerd;
        Dinosaur dinosaur1 = new Dinosaur("T-Rex");
        Dinosaur dinosaur2 = new Dinosaur("Stegga");
        Dinosaur dinosaur3 = new Dinosaur("Raptor");
        

        public Herd()
        {
            dinosaurHerd = new List<Dinosaur>();
            dinosaurHerd.Add(dinosaur1);
            dinosaurHerd.Add(dinosaur2);
            dinosaurHerd.Add(dinosaur3);

        }

        //public Dinosaur CreateDinosaur(string type, int health, int energy, int attackPower)
        //{
        //    Dinosaur dinosaur = new Dinosaur(type, health, energy, attackPower);
        //    return dinosaur;
        //}
        //Probably don't need this method if the user is always given set options to choose from

        public void AddDinosaurToHerd(Dinosaur dinosaur)
        {
            dinosaurHerd.Add(dinosaur);

        }
    }
}
