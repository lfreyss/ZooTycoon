using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.DAL.Model.Animaux
{
    public class Ornithorynque : Animal
    {
        private string TailleGriffes { get; set; }
        public Ornithorynque(string nom, int age, string race, bool sexe, string tailleGriffes) : base(nom, age, race, sexe)
        {
            TailleGriffes = tailleGriffes;
        }
    }
}
