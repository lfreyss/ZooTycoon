using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.DAL.Model.Animaux
{
    public class Lama : Animal
    {
        private string Pelages { get; set; }
        public Lama(string nom, int age, string race, bool sexe, string pelages) : base(nom, age, race, sexe)
        {
            Pelages = pelages;
        }
    }
}
