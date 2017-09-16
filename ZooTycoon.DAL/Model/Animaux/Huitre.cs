using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Interface;

namespace ZooTycoon.DAL.Model.Animaux
{
    public class Huitre : Animal, IAnimal
    {
        private bool APerle { get; set; }

        public Huitre (string nom, int age, string race, bool sexe,bool aPerle) : base(nom, age, race, sexe)
        {
            APerle = aPerle;
        }
    }
}
