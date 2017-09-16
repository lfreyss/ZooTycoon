using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.DAL.Model.Animaux
{
    public class Pterodactyle : Animal
    {
        private string LongueurBec { get; set; }
        public Pterodactyle(string nom, int age, string race, bool sexe, string longueurBec) : base(nom, age, race, sexe)
        {
            LongueurBec = longueurBec;
        }
    }
}
