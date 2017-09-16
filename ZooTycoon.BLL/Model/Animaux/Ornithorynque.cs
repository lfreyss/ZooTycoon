using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Ornithorynque : Animal
    {
        private int TailleGriffes { get; set; }
        public Ornithorynque(string nom, int age, string race, bool sexe, int tailleGriffes) : base(nom, age, race, sexe)
        {
            TailleGriffes = tailleGriffes;
        }

        public override string Cri()
        {
            return "***griiifffeee***";
        }

        public override Animal Reproduction(Animal animal)
        {
            if (this.Sexe != animal.Sexe)
                return new Ornithorynque("Bebe", 1, "poil long", true, 10);
            else
                return null;
        }

        public override void Mange()
        {
            throw new NotImplementedException();
        }
    }
}
