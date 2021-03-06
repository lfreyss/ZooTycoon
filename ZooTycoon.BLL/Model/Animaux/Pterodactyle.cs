﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Model.Animaux
{
    public class Pterodactyle : Animal
    {
        private int LongueurBec { get; set; }
        public Pterodactyle(string nom, int age, string race, bool sexe, int longueurBec) : base(nom, age, race, sexe)
        {
            Prix = 1500;
            EspaceNecessaire = 75;
            LongueurBec = longueurBec;
            listAlim = new List<Magasins.Prod_Alim>()
            {
                EntiteGestionnaire<Prod_Alim>.Add( new Magasins.Prod_Alim("Blé","Céréale", 400,false,false)),
                EntiteGestionnaire<Prod_Alim>.Add(new Magasins.Prod_Alim("Viande","Viande", 900,false,false)),
            };
        }

        public override string Cri()
        {
            return "***Bouraka***";
        }

        public override Animal Reproduction(Animal animal)
        {
            if (this.Sexe != animal.Sexe)
                return new Pterodactyle("Bebe", 1, "poil long", true, 10);
            else
                return null;
        }

    }
}
