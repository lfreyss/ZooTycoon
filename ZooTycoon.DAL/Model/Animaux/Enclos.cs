
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Interface;

namespace ZooTycoon.DAL.Model.Animaux
{
    public class Enclos
    {
        private string Nom { get; set; }
        private int Taille { get; set; }
        private string Type { get; set; }

        private List<Spectacle> listSpectacles { get; set; }
        private List<Animal> listAnimaux { get; set; }

        public Enclos (string nom, int taille, string type, List<Animal> listAnimaux, List<Spectacle> listSpectacles)
        {
            Nom = nom;
            Taille = taille;
            Type = type;
            this.listSpectacles = listSpectacles;
            this.listAnimaux = listAnimaux;
        }
    }
}