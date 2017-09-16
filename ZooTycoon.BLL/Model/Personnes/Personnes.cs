using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Personnes
{
    public class Personnes : BaseEntity
    {
        public string Nom { get; protected set; }
        public int Age { get; protected set; }

        public Personnes(string nom, int age) : base() {
            Nom = nom;
            Age = age;
        }

        public string getName()
        {
            return Nom;
        }

    }
}
