
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Enclos : BaseEntity
    {
        private string Nom { get; set; }
        private int Taille { get; set; }
        private string Type { get; set; }

        private List<Spectacle> listSpectacles { get; set; }
        private List<Animal> listAnimaux { get; set; }

        public Enclos (string nom, int taille, string type, List<Animal> listAnimaux, List<Spectacle> listSpectacles) : base()
        {
            Nom = nom;
            Taille = taille;
            Type = type;
            this.listSpectacles = listSpectacles;
            this.listAnimaux = listAnimaux;
        }

        public string Description()
        {
            return "Enclos : " + Nom + " de taille : " + Taille.ToString() + " m². C'est un(e) " + Type;
        }

        public string getName()
        {
            return Nom;
        }
    }
}