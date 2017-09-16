using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Animaux;

namespace ZooTycoon.DAL.Model.Personnes
{
    public class Animateur : Employe
    {
        private Animal AnimalFavoris { get; set; }


        public Animateur(string nom, int age, int num, bool estManager, Animal animalFavoris ) : base (nom, age, num, estManager)
        {
            AnimalFavoris = animalFavoris;
            this.listSpectacle = listSpectacle;
        }
    }
}
