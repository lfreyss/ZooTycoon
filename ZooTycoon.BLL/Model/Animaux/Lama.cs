using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Lama : Animal
    {
        private string Pelages { get; set; }
        public Lama(string nom, int age, string race, bool sexe, string pelages) : base(nom, age, race, sexe)
        {
            Pelages = pelages;
        }
        public override string Cri()
        {
            return "***Craaaache***";
        }

        public override Animal Reproduction(Animal animal)
        {
            if (this.Sexe != animal.Sexe)
                return new Lama("Bebe", 1, "poil long", true, "brun");
            else
                return null;
        }

    }
}
