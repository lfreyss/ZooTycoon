using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model.Animaux;

namespace ZooTycoon.BLL.Model.Personnes
{
    public class Animateur : Employe
    {
        private Animal AnimalFavoris { get; set; }

        public Animateur(string nom, int age, int num, bool estManager, Animal animalFavoris ) : base (nom, age, num, estManager)
        {
            AnimalFavoris = animalFavoris;
        }

        public string Description()
        {
            return "Applaudissez " + Nom + ", il a " + Age.ToString() + " ans." + (EstManager ? "Il est manager !" : "Il occupe le poste d'animateur principale");
        }
    }
}
