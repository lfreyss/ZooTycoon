
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model.Personnes;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Spectacle : BaseEntity
    {
        private string Nom { get; set; }
        private DateTime Horraire { get; set; }
        private int nbSpectateur { get; set; }

        private Enclos Enclos { get; set; }
        private List<Animateur> listAnimateurs { get; set; }
        public Spectacle(string nom, DateTime horraire, Enclos enclos, List<Animateur> listAnimateurs) : base()
        {
            Nom = nom;
            Horraire = horraire;
            Enclos = enclos;
            this.listAnimateurs = listAnimateurs;
            nbSpectateur = 0;
        }

        public void AddSpectateur()
        {
            nbSpectateur++;
        }

        public string Description()
        {
            return "Spectacle : " + Nom + " aura lieu : " + Horraire.ToString() + " dans l'enclos : " + Enclos.getName() + "  . C'est animé par : "
                + String.Join(" ,", listAnimateurs.Select(x => x.getName())) + ". Il y a actuellement " + nbSpectateur + " spectateurs.";
        }


        public string DescriptionAnimateur()
        {
            return String.Join("\n", listAnimateurs.Select(x => x.Description()));
        }
    }
}