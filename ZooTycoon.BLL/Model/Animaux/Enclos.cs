
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Enclos : BaseEntity
    {
        public string Nom { get; set; }
        public int Taille { get; set; }
        public string Type { get; set; }
        public List<Spectacle> listSpectacles { get; set; }
        public List<Animal> listAnimaux { get; set; }

        public Enclos (string nom, int taille, string type, List<Animal> listAnimaux, List<Spectacle> listSpectacles) : base()
        {
            Nom = nom;
            Taille = taille;
            Type = type;
            this.listSpectacles = listSpectacles;
            this.listAnimaux = listAnimaux;
        }

        public Enclos(string nom, int taille, string type) : base()
        {
            Nom = nom;
            Taille = taille;
            Type = type;
            this.listSpectacles = new List<Spectacle>();
            this.listAnimaux = new List<Animal>();
        }

        public string Description()
        {
            return "Enclos : " + Nom + " de taille : " + Taille.ToString() + " m². C'est un(e) " + Type;
        }

        public string getName()
        {
            return Nom;
        }

        public int GetPrix()
        {
            return Taille * 2;
        }
        
    }
}