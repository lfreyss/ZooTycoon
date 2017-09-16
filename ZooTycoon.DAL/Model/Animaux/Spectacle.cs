
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Personnes;

namespace ZooTycoon.DAL.Model.Animaux
{
    public class Spectacle
    {
        private string Nom { get; set; }
        private DateTime Horraire { get; set; }

        private Enclos Enclos { get; set; }
        private List<Animateur> listAnimateurs { get; set; }
        public Spectacle(string nom, DateTime horraire, Enclos enclos, List<Animateur> listAnimateurs)
        {
            Nom = nom;
            Horraire = horraire;
            Enclos = enclos;
            this.listAnimateurs = listAnimateurs;
        }
    }
}