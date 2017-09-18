using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Pterodactyle : Animal
    {
        private int LongueurBec { get; set; }
        public Pterodactyle(string nom, int age, string race, bool sexe, int longueurBec) : base(nom, age, race, sexe)
        {
            LongueurBec = longueurBec;
        }

        public override string Cri()
        {
            return "***Bouraka***";
        }

        public override Animal Reproduction(Animal animal)
        {
            if (this.Sexe != animal.Sexe)
                return new Pterodactyle("Bebe", 1, "poil long", true, 10);
            else
                return null;
        }

    }
}
