using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Animaux;
using ZooTycoon.DAL.Model.Personnes;

namespace ZooTycoon.DAL.Model
{
    public class Zoo
    {

        private string Nom { get; set; }
        private string Location { get; set; }
        private int NumTel { get; set; }
        private int PrixAdulte { get; set; }
        private int PrixEnfant { get; set; }
        private List<Enclos> listEnclos { get; set; }
        private List<Employe> listEmploye{ get; set; }

        private static Zoo _instance;
        private Zoo(string nom, string location, int numTel, int prixAdulte,int prixEnfant, List<Enclos> listEnclos, List<Employe> listEmploye)
        {
            Nom = nom;
            Location = location;
            NumTel = numTel;
            PrixAdulte = prixAdulte;
            PrixEnfant = prixEnfant;
            this.listEnclos = listEnclos;
            this.listEmploye = listEmploye;
        }
        private Zoo(string nom, string location, int numTel, int prixAdulte, int prixEnfant)
        {
            Nom = nom;
            Location = location;
            NumTel = numTel;
            PrixAdulte = prixAdulte;
            PrixEnfant = prixEnfant;
            this.listEnclos = null;
            this.listEmploye = null;
        }

        public static Zoo getInstance()
        {
            if (_instance == null) 
				_instance = new Zoo("ZooTycoon", "NY", 038854782, 25, 10);

            return _instance;
        }
    }
}
