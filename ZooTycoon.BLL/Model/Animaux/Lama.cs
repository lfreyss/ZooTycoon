using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Lama : Animal
    {
        private string Pelages { get; set; }
        public Lama(string nom, int age, string race, bool sexe, string pelages) : base(nom, age, race, sexe)
        {
            Prix = 300;
            EspaceNecessaire = 100;
            Pelages = pelages;
            listAlim = new List<Magasins.Prod_Alim>()
            {
               
                EntiteGestionnaire<Prod_Alim>.Add( new Magasins.Prod_Alim("Avoine","Céréale", 500,false,false)),
                EntiteGestionnaire<Prod_Alim>.Add(new Magasins.Prod_Alim("Herbe","Plante", 500,false,false)),
            };
        }
        public override string Cri()
        {
            return "***Craaaache***";
        }

        public override Animal Reproduction(Animal animal)
        {
            if (this.Sexe != animal.Sexe)
                return new Lama("Bebe", 1, "poil long", true, "brun");
            else
                return null;
        }

    }
}
