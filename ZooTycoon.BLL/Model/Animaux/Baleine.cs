using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Baleine : Animal
    {
        private int NbNageoire { get; set; }
        public Baleine(string nom, int age, string race, bool sexe, int nbNageoire) : base(nom, age, race, sexe)
        {
            NbNageoire = nbNageoire;
            EspaceNecessaire = 250;
            Prix = 1000;
            listAlim = new List<Magasins.Prod_Alim>()
            {
                EntiteGestionnaire<Prod_Alim>.Add(new Magasins.Prod_Alim("Algue", "Plante", 300, false, false)),
                EntiteGestionnaire<Prod_Alim>.Add(new Magasins.Prod_Alim("Petite crustacé","Poisson", 500,false,false)),
                EntiteGestionnaire<Prod_Alim>.Add(new Magasins.Prod_Alim("Plancton","Poisson", 700,false,false))
            };
        }

        public override string Cri()
        {
            return "Baleiiiiiine";
        }

        public override Animal Reproduction(Animal animal)
        {
            if (this.Sexe != animal.Sexe)
                return new Baleine("Bebe", 1, "poil long", true, 2);
            else
                return null;
        }


    }
}
