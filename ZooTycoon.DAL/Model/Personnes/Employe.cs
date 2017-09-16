using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.DAL.Model.Personnes
{
    public class Employe : Personnes
    {
        private int NumEmploye { get; set; }
        private bool EstManager { get; set; }

        public Employe(string nom, int age, int num, bool estManager) : base (nom, age)
        {
            NumEmploye = num;
            EstManager = estManager;
        }

    }
}
