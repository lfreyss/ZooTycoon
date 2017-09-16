using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Huitre : Animal, IEntity
    {
        private bool APerle { get; set; }

        public Huitre (string nom, int age, string race, bool sexe,bool aPerle) : base(nom, age, race, sexe)
        {
            APerle = aPerle;
        }

        public override string Cri()
        {
            return "Peeeeeeerle";
        }

        public override Animal Reproduction(Animal animal)
        {
            if (this.Sexe != animal.Sexe)
                return new Huitre("Bebe", 1, "poil long", true, true);
            else
                return null;
        }

        public override void Mange()
        {
            throw new NotImplementedException();
        }
    }
}
