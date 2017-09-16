using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Animaux
{
    public abstract class  Animal : BaseEntity, IAnimal
    {
        private string Nom { get; set; }
        private int Age { get; set; }
        private string Race { get; set; }
        public bool Sexe {  get; protected set; }

        protected List<Animal> listParents { get; set; }
        protected List<Animal> listEnfants{ get; set; }
        protected List<Enclos> enclos { get; set;}
        public Animal(string nom, int age, string race, bool sexe) : base()
        {
            Nom = nom;
            Age = age;
            Race = race;
            Sexe = sexe;
        }

        public abstract void Mange();

        public abstract string Cri();

        public abstract Animal Reproduction(Animal animal);

    }
}
