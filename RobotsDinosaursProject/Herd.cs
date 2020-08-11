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



        public void AddDinosaurToHerd(Dinosaur dinosaur)
        {
            dinosaurHerd.Add(dinosaur);

        }
    }
}
