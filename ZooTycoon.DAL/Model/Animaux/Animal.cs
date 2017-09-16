using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Interface;

namespace ZooTycoon.DAL.Model.Animaux
{
    public class Animal : IAnimal
    {
        private string Nom { get; set; }
        private int Age { get; set; }
        private string Race { get; set; }
        private bool Sexe { get; set; }

        public List<Animal> listParents { get; set; }
        public List<Animal> listEnfants{ get; set; }

        public List<Enclos> enclos { get; set;}
        public Animal(string nom, int age, string race, bool sexe)
        {
            Nom = nom;
            Age = age;
            Race = race;
            Sexe = sexe;
        }

    }
}
