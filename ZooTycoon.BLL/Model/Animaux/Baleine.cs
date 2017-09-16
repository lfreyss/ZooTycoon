using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Baleine : Animal
    {
        private int NbNageoire { get; set; }
        public Baleine(string nom, int age, string race, bool sexe, int nbNageoire) : base(nom, age, race, sexe)
        {
            NbNageoire = nbNageoire;
        }

        public override string Cri()
        {
            return "Baleiiiiiine";
        }

        public override Animal Reproduction(Animal animal)
        {
            if (this.Sexe != animal.Sexe)
                return new Baleine("Bebe", 1, "poil long", true, 2);
            else
                return null;
        }

        public override void Mange()
        {
            throw new NotImplementedException();
        }
    }
}
