using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Ornithorynque : Animal
    {
        private int TailleGriffes { get; set; }
        public Ornithorynque(string nom, int age, string race, bool sexe, int tailleGriffes) : base(nom, age, race, sexe)
        {
            Prix = 500;
            EspaceNecessaire = 125;
            TailleGriffes = tailleGriffes;
            listAlim = new List<Magasins.Prod_Alim>()
            {
                EntiteGestionnaire<Prod_Alim>.Add(new Magasins.Prod_Alim("Avoine","Céréale", 500,false,false)),
                EntiteGestionnaire<Prod_Alim>.Add( new Magasins.Prod_Alim("Herbe","Plante", 500,false,false)),
            };
        }

        public override string Cri()
        {
            return "***griiifffeee***";
        }

        public override Animal Reproduction(Animal animal)
        {
            if (this.Sexe != animal.Sexe)
                return new Ornithorynque("Bebe", 1, "poil long", true, 10);
            else
                return null;
        }

    }
}
