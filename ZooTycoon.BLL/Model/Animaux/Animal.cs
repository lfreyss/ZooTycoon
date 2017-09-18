using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Model.Animaux
{
    public abstract class  Animal : BaseEntity, IAnimal
    {
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public bool Sexe {  get; protected set; }

        public List<Prod_Alim> listAlim { get; set; }

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

        public virtual string Mange(Produit item) {
            return Nom + " se précipite sur la nouritture. \n";
        }

        public abstract string Cri();

        public abstract Animal Reproduction(Animal animal);

    }
}
