using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Huitre : Animal, IEntity
    {
        private bool APerle { get; set; }

        public Huitre (string nom, int age, string race, bool sexe,bool aPerle) : base(nom, age, race, sexe)
        {
            EspaceNecessaire = 25;
            Prix = 150;
            APerle = aPerle;
            listAlim = new List<Magasins.Prod_Alim>()
            {
                EntiteGestionnaire<Prod_Alim>.Add(new Magasins.Prod_Alim("Algue","Plante",300,false,false)),
                EntiteGestionnaire<Prod_Alim>.Add(new Magasins.Prod_Alim("Petite crustacé","Poisson", 500,false,false)),
            };
        }

        public override string Cri()
        {
            return "Peeeeeeerle";
        }

        public override Animal Reproduction(Animal animal)
        {
            if (this.Sexe != animal.Sexe)
                return new Huitre("Bebe", 1, "poil long", true, true);
            else
                return null;
        }

    }
}
