using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.DAL.Model.Animaux
{
    public class Baleine : Animal
    {
        private int NbNageoire { get; set; }
        public Baleine(string nom, int age, string race, bool sexe, int nbNageoire) : base(nom, age, race, sexe)
        {
            NbNageoire = nbNageoire;
        }
    }
}
