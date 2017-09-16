using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.DAL.Model.Personnes
{
    public class Personnes
    {
        private string Nom { get; set; }
        private int Age { get; set; }

        public Personnes(string nom, int age) {
            Nom = nom;
            Age = age;
        }
    }
}
