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

        public Herd()
        {
            dinosaurHerd = new List<Dinosaur>();

        }

        public Dinosaur CreateDinosaur(string type, int health, int energy, int attackPower)
        {
            Dinosaur dinosaur = new Dinosaur(type, health, energy, attackPower);
            return dinosaur;
        }

        public void AddDinosaurToHerd(Dinosaur dinosaur)
        {
            dinosaurHerd.Add(dinosaur);

        }
    }
}
